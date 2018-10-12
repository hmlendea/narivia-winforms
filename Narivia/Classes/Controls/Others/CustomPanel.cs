using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Narivia
{
    class CustomPanel : Panel
    {
        public string TitleText { get; set; }
        public ContentAlignment TitleTextAlign { get; set; }
        public Color ShadowColor { get; set; }

        public CustomPanel()
        {
            Size = new Size(128, 16);

            Font = new Font("Palatino Linotype", Height / 2, FontStyle.Bold);
            this.Resize += delegate { Font = new Font(Font.FontFamily, Height / 2, Font.Style); };
            
            ForeColor = Color.Gold;
            BackColor = Color.DarkRed;
            ShadowColor = Color.Black;

            TitleTextAlign = ContentAlignment.MiddleCenter;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Rectangle r = new Rectangle(0, 0, Width, Height);
            Graphics g = e.Graphics;

            DrawingPlus.DrawPanel(g, r, BackColor, 2);

            // Text Formatting
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            StringFormat sf = new StringFormat();
            Int32 lNum = (Int32)Math.Log((Double)TitleTextAlign, 2);
            sf.LineAlignment = (StringAlignment)(lNum / 4);
            sf.Alignment = (StringAlignment)(lNum % 4);

            // Text Shadow
            if (ShadowColor != Color.Transparent)
                g.DrawString(TitleText, Font, new SolidBrush(ShadowColor),
                    new Rectangle(1, 1, Width, Height), sf);

            // Text
            g.DrawString(TitleText, Font, new SolidBrush(ForeColor), ClientRectangle, sf);
        }
    }
}
