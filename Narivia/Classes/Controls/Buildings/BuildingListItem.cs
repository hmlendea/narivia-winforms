using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Narivia.Game;

namespace Narivia
{
    class BuildingListItem : Control
    {
        public Color ShadowColor { get; set; }
        public Building Building { get; set; }
        public int CultureID { get; set; }
        public new string Text
        {
            get
            {
                if (Building != null)
                    return Building.Name;
                else
                    return "";
            }
        }

        public bool Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                Refresh();
            }
        } bool selected;
        public bool Clicked
        {
            get { return clicked; }
            set
            {
                clicked = value;
                Refresh();
            }
        } bool clicked;

        public BuildingListItem(Building building, int cultureID)
        {
            InitializeEvents();
            InitializeStyles();

            Building = building;
            CultureID = cultureID;

            BackColor = Color.Black;
            ForeColor = Color.Gold;
            ShadowColor = Color.Black;

            Font = new Font("Palatino Linotype", 9.75f, FontStyle.Bold);
            Size = new Size(192, 32);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush fb;
            Rectangle recBody = new Rectangle(Height, 0, Width - Height, Height);
            Rectangle recBuilding = new Rectangle(0, 0, Height, Height);

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (Enabled)
                fb = new SolidBrush(ForeColor);
            else
                fb = new SolidBrush(ColorTranslator.FromHtml("#A0A0A0"));

            if (Selected == false)
            {
                g.FillRectangle(new SolidBrush(BackColor), recBody);
                g.FillRectangle(Brushes.DarkRed, recBuilding);
            }
            else
            {
                DrawingPlus.DrawBilinearHorizontalGradient(g, recBody, BackColor, -1);
                DrawingPlus.DrawBilinearHorizontalGradient(g, recBuilding, Color.DarkRed, -1);
            }

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawImage(Building.Icon[CultureID], new Rectangle(0,4,32,25));

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;

            g.DrawString(Text, Font, new SolidBrush(ShadowColor),
                new Rectangle(recBody.X + 1, recBody.Y + 1, recBody.Width, recBody.Height), sf);
            g.DrawString(Text, Font, fb, recBody, sf);
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
