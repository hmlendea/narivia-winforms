using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Narivia
{
    class CustomButton : Control
    {
        public Color BorderColor { get; set; }
        public Color ShadowColor { get; set; }
        public bool Selected { get; set; }
        public bool Clicked { get; set; }
        public bool AutoSizeBorder { get; set; }
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

        public CustomButton()
        {
            InitializeEvents();
            InitializeStyles();

            Width = 96;
            Height = 32;

            Font = new Font("Palatino Linotype", (int)(Height * 0.35), FontStyle.Bold);
            ForeColor = Color.Gold;
            BackColor = Color.DarkRed;
            BorderColor = ColorTranslator.FromHtml("#2F2E28");
            ShadowColor = Color.Black;

            AutoSizeBorder = true;
            BorderSize = 8;
        }

        private void InitializeEvents()
        {
            base.Click += new System.EventHandler(this.base_Click);
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

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font(Font.FontFamily, Height / 3, Font.Style);
            Brush fb = new SolidBrush(ForeColor);
            Brush sb = new SolidBrush(ForeColor);
            Rectangle r = new Rectangle(0, 0, Width, Height);
            StringFormat sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            Color bg;

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (Enabled == false)
                fb = new SolidBrush(ColorTranslator.FromHtml("#A0A0A0"));

            int brdSize;
            if (AutoSizeBorder)
            {
                brdSize = Math.Max(Math.Min(8, Height / 8), 4);
                if (brdSize % 2 != 0)
                    brdSize -= 1;
            }
            else
                brdSize = BorderSize;

            if (Clicked)
                bg = DrawingPlus.DarkenColor(BackColor, -32);
            else if (Selected)
                bg = DrawingPlus.DarkenColor(BackColor, -16);
            else
                bg = BackColor;

            if (Clicked || Selected)
                brdSize += 2;

            DrawingPlus.DrawBorder(g, r, BorderColor, brdSize);
            DrawingPlus.DrawPanel(g, new Rectangle(brdSize, brdSize, Width - brdSize * 2, Height - brdSize * 2), bg, Math.Max(2, brdSize - 4));

            if (ShadowColor != Color.Transparent)
                g.DrawString(Text, f, Brushes.Black,
                    new Rectangle(1, 1, Width, Height), sf);
            g.DrawString(Text, f, fb, r, sf);
        }

        #region Events
        private void base_Click(object sender, EventArgs e)
        {
            Clicked = false;
            Selected = false;
        }
        private void base_MouseEnter(object sender, EventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");
            Sound.Play("Button\\Select.WAV");

            Selected = true;
            Refresh();
        }
        private void base_MouseLeave(object sender, EventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");

            Selected = false;
            Refresh();
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
            Refresh();
        }
        #endregion
    }
}
