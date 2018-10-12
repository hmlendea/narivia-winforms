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
    class MapListItem : Control
    {
        public Color ShadowColor { get; set; }

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
        public string MapDisplayName { get; set; }
        public string MapInternalName { get; set; }
        public string MapDescription { get; set; }
        public string MapVersion { get; set; }
        public string MapLink { get; set; }
        public bool Installed { get; set; }
        public bool UpToDate { get; set; }

        public MapListItem(string internalName, string displayName, string version, string description, string link)
        {
            InitializeEvents();
            InitializeStyles();

            BackColor = Color.Black;
            ForeColor = Color.Gold;
            ShadowColor = Color.Black;

            MapInternalName = internalName;
            MapDisplayName = displayName;
            MapVersion = version;
            MapDescription = description;
            MapLink = link;

            Font = new Font("Palatino Linotype", 9.75f, FontStyle.Bold);
            Size = new Size(192, 32);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush fb;
            Rectangle recBody = new Rectangle(Width / 4, 0, Width - Width / 4, Height);
            Rectangle recMap = new Rectangle(0, 0, Width / 4, Height);

            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            if (Enabled)
                fb = new SolidBrush(ForeColor);
            else
                fb = new SolidBrush(ColorTranslator.FromHtml("#A0A0A0"));

            if (Selected == false)
            {
                g.FillRectangle(new SolidBrush(BackColor), recBody);
                g.FillRectangle(Brushes.DarkRed, recMap);
            }
            else
            {
                DrawingPlus.DrawBilinearHorizontalGradient(g, recBody, BackColor, -1);
                DrawingPlus.DrawBilinearHorizontalGradient(g, recMap, Color.DarkRed, -1);
            }

            // Status icon
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Image imgStatus;
            if (Installed)
            {
                if (UpToDate)
                    imgStatus = Properties.Resources.Success;
                else
                    imgStatus = Properties.Resources.Warning;    
            }
            else
                imgStatus = Properties.Resources.Error;
            g.DrawImage(imgStatus, new Rectangle(Width - Height, 0, Height, Height));

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;

            // Map Name
            g.DrawString(MapDisplayName + " (v" + MapVersion + ")", Font, new SolidBrush(ShadowColor),
                new Rectangle(recMap.X + 1, recMap.Y + 1, recMap.Width, recMap.Height), sf);
            g.DrawString(MapDisplayName + " (v" + MapVersion + ")", Font, fb, recMap, sf);

            // Map Description
            g.DrawString(MapDescription, Font, new SolidBrush(ShadowColor),
                new Rectangle(recBody.X + 1, recBody.Y + 1, recBody.Width, recBody.Height), sf);
            g.DrawString(MapDescription, Font, fb, recBody, sf);
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
