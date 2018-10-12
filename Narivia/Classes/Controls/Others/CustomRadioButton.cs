using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace Narivia
{
    public class CustomRadioButton : RadioButton
    {
        public Color BoxColor { get; set; }
        public bool ClickSound { get; set; }
        public bool Selected;
        public bool Clicked;

        public CustomRadioButton()
        {
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

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(0, (base.Size.Height - 16) / 2, 16, 16);
            Image img;
            Brush fb;
            int dotSize = 5;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (Enabled)
                fb = new SolidBrush(ForeColor);
            else
                fb = new SolidBrush(ColorTranslator.FromHtml("#A0A0A0"));

            base.OnPaint(e);

            if (Selected == false)
                if (Clicked == false)
                    img = DrawingPlus.LoadImage(NarivianClass.PanelsDirectory + "RadioButton\\Idle.PNG", false);
                else
                    img = DrawingPlus.LoadImage(NarivianClass.PanelsDirectory + "RadioButton\\Clicked.PNG", false);
            else
                img = DrawingPlus.LoadImage(NarivianClass.PanelsDirectory + "RadioButton\\Selected.PNG", false);

            if (img != null)
                g.DrawImage(img, r);
            else
                g.FillEllipse(new SolidBrush(BoxColor), r);

            if(Checked)
                g.FillEllipse(fb, new Rectangle(
                    r.X + (r.Width - dotSize) / 2, r.Y + (r.Height - dotSize) / 2, dotSize, dotSize));
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