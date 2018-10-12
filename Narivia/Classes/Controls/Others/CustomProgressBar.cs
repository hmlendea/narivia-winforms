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
    class CustomProgressBar : ProgressBar
    {
        //public Font Font { get; set; }
        public Color BorderColor { get; set; }
        public Color FillColor { get; set; }
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

        public CustomProgressBar()
        {
            InitializeStyles();

            Font = new Font("Palatino Linotype", (int)(Height * 0.35), FontStyle.Bold);

            FillColor = Color.Gold;
            BackColor = Color.DarkRed;
            BorderColor = ColorTranslator.FromHtml("#2F2E28");
            ForeColor = Color.Gold;

            AutoSizeBorder = true;
            borderSize = 6;
        }

        private void InitializeStyles()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.Selectable, false);
        }

        protected override void OnPaint(PaintEventArgs p)
        {
            Graphics g = p.Graphics;
            Font f = new Font(Font.FontFamily, Height / 3, Font.Style);
            Brush fb = new SolidBrush(ForeColor);
            Brush sb;
            Rectangle r = new Rectangle(0, 0, Width, Height);
            StringFormat sf = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            
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

            int fillWidth = (Width - brdSize * 2) * Value / 100;

            if (Value < 50)
            {
                fb = new SolidBrush(FillColor);
                sb = new SolidBrush(BackColor);
            }
            else
            {
                fb = new SolidBrush(BackColor);
                sb = new SolidBrush(FillColor);
            }

            DrawingPlus.DrawBorder(g, r, BorderColor, brdSize);
            if(fillWidth > 0)
                DrawingPlus.DrawPanel(g, new Rectangle(brdSize, brdSize, fillWidth, Height - brdSize * 2), FillColor, 2);
            if(fillWidth < Width - brdSize * 2)
                DrawingPlus.DrawPanel(g, new Rectangle(brdSize + fillWidth, brdSize, Width - brdSize * 2 - fillWidth, Height - brdSize * 2), BackColor, 2);

            g.DrawString(Value + "%", f, sb, new Rectangle(1, 1, Width, Height), sf);
            g.DrawString(Value + "%", f, fb, r, sf);
        }
    }
}
