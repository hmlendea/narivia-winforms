using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Narivia.Battles
{
    class BattleBar : PictureBox
    {
        public int AttackerScore { get; set; }
        public int DefenderScore { get; set; }
        public int TotalScore
        {
            get { return AttackerScore + DefenderScore; }
        }

        public Color BorderColor { get; set; }
        public Color AttackerColor { get; set; }
        public Color DefenderColor { get; set; }
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

        public BattleBar()
        {
            InitializeStyles();
            BorderColor = ColorTranslator.FromHtml("#2F2E28");

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
            Rectangle r = new Rectangle(0, 0, Width, Height);

            int widthAttacker;
            if (TotalScore > 0)
                widthAttacker = ((AttackerScore * 100 / TotalScore) * Width) / 100;
            else
                widthAttacker = 0;

            int brdSize;
            if (AutoSizeBorder)
            {
                brdSize = Math.Max(Math.Min(8, Height / 8), 4);
                if (brdSize % 2 != 0)
                    brdSize -= 1;
            }
            else
                brdSize = BorderSize;

            DrawingPlus.DrawBorder(g, r, BorderColor, brdSize);
            DrawingPlus.DrawPanel(g, new Rectangle(brdSize, brdSize, widthAttacker, Height - brdSize * 2), AttackerColor, 2);
            DrawingPlus.DrawPanel(g, new Rectangle(brdSize + widthAttacker, brdSize, Width - brdSize * 2 - widthAttacker, Height - brdSize * 2), DefenderColor, 2);
        }
    }
}
