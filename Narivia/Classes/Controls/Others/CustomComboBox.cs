using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Narivia
{
    class CustomComboBox : ComboBox
    {
        public Color BorderColor { get; set; }
        public Color ShadowColor { get; set; }
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                if (value % 2 != 0)
                    borderSize = value - 1;
                else
                    borderSize = value;
            }
        } int borderSize;
        public bool Selected
        {
            get { return selected && !DroppedDown; }
            set { selected = value && !DroppedDown; }
        } bool selected;
        public bool Clicked
        {
            get { return clicked && !DroppedDown; }
            set { clicked = value && !DroppedDown; }
        } bool clicked;

        new public System.Windows.Forms.DrawMode DrawMode { get; set; }

        public CustomComboBox()
        {
            InitializeEvents();
            InitializeStyles();
            DropDown += delegate
            {
                Selected = false;
                Clicked = false;
            };

            base.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;

            DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            FlatStyle = FlatStyle.Flat;

            MaxDropDownItems = 8;

            BackColor = Color.DarkRed;
            ForeColor = Color.Gold;
            BorderColor = ColorTranslator.FromHtml("#2F2E28");
            ShadowColor = Color.Black;

            BorderSize = 4;

            Font = new Font("Palatino Linotype", 9.75f, FontStyle.Bold);

            DrawItem += new DrawItemEventHandler(CustomComboBox_DrawItem);
        }

        private void InitializeEvents()
        {
            base.MouseEnter += new System.EventHandler(this.base_MouseEnter);
            base.MouseLeave += new System.EventHandler(this.base_MouseLeave);
            base.MouseDown += new System.Windows.Forms.MouseEventHandler(this.base_MouseDown);
            base.MouseUp += new System.Windows.Forms.MouseEventHandler(this.base_MouseUp);
        }
        private void InitializeStyles()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.Selectable, false);
        }

        void CustomComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            ComboBox cb = (ComboBox)sender;
            Graphics g = e.Graphics;
            Color clrText;
            Color clrHighlight;
            Color clrShadow;

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                clrHighlight = ForeColor;
                clrText = BackColor;
                clrShadow = Color.Transparent;
            }
            else
            {
                clrHighlight = BackColor;

                if (Enabled)
                    clrText = ForeColor;
                else
                    clrText = ColorTranslator.FromHtml("#A0A0A0");

                clrShadow = ShadowColor;
            }

            DrawingPlus.DrawBilinearHorizontalGradient(g, e.Bounds, clrHighlight, 3);
            if (clrShadow != Color.Transparent)
                g.DrawString(cb.Items[e.Index].ToString(), e.Font, new SolidBrush(ShadowColor),
                    new Point(e.Bounds.X - 1, e.Bounds.Y + 1));

            g.DrawString(cb.Items[e.Index].ToString(), e.Font, new SolidBrush(clrText), new Point(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics g = e.Graphics;
            Rectangle rBrowse;
            Brush fb = new SolidBrush(ForeColor);
            Color bg;
            int brdSize = BorderSize;
            
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (Enabled == false)
                fb = new SolidBrush(ColorTranslator.FromHtml("#A0A0A0"));

            if (Clicked)
                bg = DrawingPlus.DarkenColor(BackColor, -32);
            else if (Selected)
                bg = DrawingPlus.DarkenColor(BackColor, -16);
            else
                bg = BackColor;

            if (Clicked || Selected)
                brdSize += 2;

            rBrowse = new Rectangle(Width - Height + brdSize, brdSize, Height - brdSize * 2, Height - brdSize * 2);

            #region alternative design
            DrawingPlus.DrawBorder(g, new Rectangle(0, 0, Width - Height, Height), BorderColor, BorderSize);
            DrawingPlus.DrawPanel(g, new Rectangle(
                BorderSize, BorderSize, Width - Height - BorderSize * 2, Height - BorderSize * 2),
                BackColor, BorderSize - 2);

            DrawingPlus.DrawBorder(g, new Rectangle(Width - Height, 0, Height, Height), BorderColor, BorderSize);
            DrawingPlus.DrawPanel(g, new Rectangle(
                    Width - Height + BorderSize, BorderSize,
                    Height - BorderSize * 2, Height - borderSize * 2),
                BackColor, BorderSize - 2);
            #endregion

            DrawingPlus.DrawBorder(g, new Rectangle(0, 0, Width, Height), BorderColor, brdSize);
            DrawingPlus.DrawPanel(g, new Rectangle(brdSize, brdSize, Width - Height, Height - brdSize * 2), bg, Math.Max(2, brdSize - 4));
            DrawingPlus.DrawPanel(g, rBrowse, bg, Math.Max(2, brdSize - 4));

            StringFormat sf = new StringFormat();
            StringFormat sfBrowse = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sfBrowse.LineAlignment = StringAlignment.Center;
            sfBrowse.Alignment = StringAlignment.Center;
            Font fBrowse = new Font(Font.FontFamily, (int)(Font.Size * 0.66));

            if (ShadowColor != Color.Transparent)
            {
                g.DrawString(Text, Font, Brushes.Black, new Rectangle(brdSize + 1, 1, Width, Height), sf);
                g.DrawString("▼", fBrowse, Brushes.Black, new Rectangle(rBrowse.X + 1, rBrowse.Y + 1, rBrowse.Width, rBrowse.Height), sfBrowse);
            }

            g.DrawString(Text, Font, fb, new Rectangle(brdSize, 0, Width, Height), sf);
            g.DrawString("▼", fBrowse, fb, rBrowse, sfBrowse);

        }

        #region Events
        private void base_MouseEnter(object sender, EventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");
            Sound.Play("Button\\Select.WAV");

            Selected = true;
        }
        private void base_MouseLeave(object sender, EventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");

            Selected = false;
        }
        private void base_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = CustomCursor.Load("Default_Pressed.CUR");
            Sound.Play("Button\\Click.WAV");

            Clicked = true;
            Refresh();
        }
        private void base_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");

            Clicked = false;
        }
        #endregion
    }
}
