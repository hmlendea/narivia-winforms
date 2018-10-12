using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Narivia
{
    class CustomLabel : Label
    {
        public Color ShadowColor { get; set; }

        public CustomLabel()
        {
            ForeColor = Color.Gold;
            BackColor = Color.Transparent;
            ShadowColor = Color.Black;

            Font = new Font("Palatino Linotype", 9.75f, FontStyle.Bold);

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush fb;

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (Enabled)
                fb = new SolidBrush(ForeColor);
            else
                fb = new SolidBrush(ColorTranslator.FromHtml("#A0A0A0"));

            g.FillRectangle(new SolidBrush(BackColor), ClientRectangle);

            if (Image != null)
                g.DrawImage(Image, ClientRectangle);
            
            StringFormat sf = new StringFormat();
            Int32 lNum = (Int32)Math.Log((Double)TextAlign, 2);
            sf.LineAlignment = (StringAlignment)(lNum / 4);
            sf.Alignment = (StringAlignment)(lNum % 4);
            
            if(ShadowColor != Color.Transparent)
                g.DrawString(Text, Font, new SolidBrush(ShadowColor),
                    new Rectangle(1, 1, Width, Height), sf);

            g.DrawString(Text, Font, fb, ClientRectangle, sf);
        }
    }
}
