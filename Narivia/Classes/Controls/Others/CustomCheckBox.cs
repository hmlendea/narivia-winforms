using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;

namespace Narivia
{
    public class CustomCheckBox : CheckBox
    {
        public Color BorderColor { get; set; }
        public Color BoxColor { get; set; }
        public bool ClickSound { get; set; }
        public bool Selected { get; set; }
        public bool Clicked { get; set; }

        public CustomCheckBox()
        {
            BorderColor = ColorTranslator.FromHtml("#2F2E28");
            BackColor = Color.Transparent;
            BoxColor = Color.DarkRed;
            ForeColor = Color.Gold;
            Font = new Font("Palatino Linotype", 9.75f, FontStyle.Bold);
            ClickSound = true;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.Selectable, false);

            InitializeEvents();
        }

        private void InitializeEvents()
        {
            base.MouseEnter += new System.EventHandler(this.base_MouseEnter);
            base.MouseLeave += new System.EventHandler(this.base_MouseLeave);
            base.MouseDown += new System.Windows.Forms.MouseEventHandler(this.base_MouseDown);
            base.MouseUp += new System.Windows.Forms.MouseEventHandler(this.base_MouseUp);
        }

        protected override void OnPaint(PaintEventArgs p)
        {
            Graphics g = p.Graphics;
            Rectangle r = new Rectangle(0, (base.Size.Height - 16) / 2, 16, 16);
            Brush fb;
            Color bg;

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (Enabled)
                fb = new SolidBrush(ForeColor);
            else
                fb = new SolidBrush(ColorTranslator.FromHtml("#A0A0A0"));

            base.OnPaint(p);

            if (Clicked)
                bg = DrawingPlus.DarkenColor(BoxColor, -32);
            else if (Selected)
                bg = DrawingPlus.DarkenColor(BoxColor, -16);
            else
                bg = BoxColor;

            DrawingPlus.DrawBorder(g, r, BorderColor, 4);
            DrawingPlus.DrawPanel(g, new Rectangle(r.X + 4, r.Y + 4, r.X + r.Width - 8, r.Height - 8), bg, 2);

            if (this.Checked)
                g.DrawString("✔", new Font("Lucida Console", 7), fb, r, new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    });
        }

        #region Events
        private void base_MouseEnter(object sender, EventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");

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
        }
        private void base_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");

            Clicked = false;
        }
        #endregion
    }
}