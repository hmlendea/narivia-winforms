using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using WMPLib;

namespace Narivia
{
    class NoticeIcon : PictureBox
    {
        WindowsMediaPlayer WMP = new WindowsMediaPlayer();

        public NoticeIcon(string icon)
        {
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Size = new Size(48, 48);

            if (File.Exists(NarivianClass.NoticesDirectory + "Icons\\" + icon + ".PNG"))
                this.Image = Image.FromFile(NarivianClass.NoticesDirectory + "Icons\\" + icon + ".PNG");
            else
                Image = Properties.Resources.MissingTexture;

            InitializeEvents();
        }

        private void InitializeEvents()
        {
            base.MouseEnter += new System.EventHandler(this.base_MouseEnter);
            base.MouseLeave += new System.EventHandler(this.base_MouseLeave);
            base.MouseDown += new System.Windows.Forms.MouseEventHandler(this.base_MouseDown);
            base.MouseUp += new System.Windows.Forms.MouseEventHandler(this.base_MouseUp);
        }

        #region Events
        private void base_MouseEnter(object sender, EventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");
            Sound.Play("Button\\Select.WAV");
        }
        private void base_MouseLeave(object sender, EventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");
        }
        private void base_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = CustomCursor.Load("Default_Pressed.CUR");
            Sound.Play("Button\\Click.WAV");

            if (e.Button == MouseButtons.Right)
                base.Dispose();
        }
        private void base_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");
        }
        #endregion
    }
}
