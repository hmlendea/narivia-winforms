using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Narivia
{
    public enum CustomGroupBoxTextPosition
    {
        Left,
        Center,
        Right
    }

    class CustomGroupBox : GroupBox
    {
        public Color BorderColor { get; set; }
        public Color ShadowColor { get; set; }
        public CustomGroupBoxTextPosition TextPosition
        {
            get { return cgbtp; }
            set
            {
                cgbtp = value;
                Refresh();
            }
        } CustomGroupBoxTextPosition cgbtp;

        public CustomGroupBox()
        {
            ForeColor = Color.Gold;
            BorderColor = Color.DarkRed;
            BackColor = Color.Transparent;
            ShadowColor = Color.Black;

            TextPosition = CustomGroupBoxTextPosition.Left;
            Font = new Font("Palatino Linotype", 9.75f, FontStyle.Bold);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Size titleSize;
            Point titlePosition;
            Color bg;
            Brush fb;
            int borderSize = 4;

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (Enabled)
                fb = new SolidBrush(ForeColor);
            else
                fb = new SolidBrush(ColorTranslator.FromHtml("#A0A0A0"));

            if (BackColor != Color.Transparent)
                bg = BackColor;
            else
                if (Parent.GetType() == typeof(CustomGroupBox))
                    bg = Color.Transparent;
                else
                    bg = Color.FromArgb(31, Color.Black);

            g.FillRectangle(new SolidBrush(bg), new Rectangle(borderSize, borderSize, Width - borderSize * 2, Height - borderSize * 2));
            DrawingPlus.DrawBorder(g, ClientRectangle, BorderColor, borderSize);

            titleSize = new Size();
            titleSize.Width = (int)g.MeasureString(Text, Font).Width + 2 + borderSize;
            titleSize.Height = (int)g.MeasureString(Text, Font).Height + 2;

            switch(TextPosition)
            {
                case CustomGroupBoxTextPosition.Left:
                    titlePosition = new Point(0, 0);
                    break;
                    
                case CustomGroupBoxTextPosition.Center:
                    titlePosition = new Point((Width - titleSize.Width) / 2, 0);
                    break;

                case CustomGroupBoxTextPosition.Right:
                    titlePosition = new Point(Width - titleSize.Width, 0);
                    break;

                default:
                    goto case CustomGroupBoxTextPosition.Left;
            }

            DrawingPlus.DrawPanel(g,
                new Rectangle(titlePosition.X, titlePosition.Y, titleSize.Width, titleSize.Height),
                BorderColor, borderSize - 2);

            if (ShadowColor != Color.Transparent)
                g.DrawString(Text, Font, new SolidBrush(ShadowColor),
                    new Point(titlePosition.X + borderSize + 1, 0));
            g.DrawString(Text, Font, fb,
                new Point(titlePosition.X + borderSize, 0));
        }
    }
}
