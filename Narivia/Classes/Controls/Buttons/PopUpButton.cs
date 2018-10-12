using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Reflection;
using WMPLib;

namespace Narivia
{
    class PopUpButton : PictureBox
    {
        Image imgIdle;
        Image imgSelected;
        Image imgClicked;

        string AppPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";

        public PopUpButton(string btn = "Missing")
        {
            Height = 45;
            Width = 45;
            LoadImages(btn);
            
            BackColor = Color.Transparent;
            Image = imgIdle;

            Cursor = CustomCursor.Load("Default_Pressed.CUR"); 
            InitializeEvents();
        }
        private void InitializeEvents()
        {
            MouseEnter += new System.EventHandler(this.base_MouseEnter);
            MouseLeave += new System.EventHandler(this.base_MouseLeave);
            MouseDown += new System.Windows.Forms.MouseEventHandler(this.base_MouseDown);
            MouseUp += new System.Windows.Forms.MouseEventHandler(this.base_MouseUp);
        }
        private void LoadImages(string btn)
        {
            string pathButtons = NarivianClass.PanelsDirectory + "Buttons\\";

            // imgIdle
            if (File.Exists(pathButtons + btn + "_Idle.PNG"))
                imgIdle = Image.FromFile(pathButtons + btn + "_Idle.PNG");
            else
                imgIdle = Properties.Resources.MissingTexture;

            // imgSelected
            if (File.Exists(pathButtons + btn + "_Selected.PNG"))
                imgSelected = Image.FromFile(pathButtons + btn + "_Selected.PNG");
            else
                imgSelected = Properties.Resources.MissingTexture;

            // imgClicked
            if (File.Exists(pathButtons + btn + "_Clicked.PNG"))
                imgClicked = Image.FromFile(pathButtons + btn + "_Clicked.PNG");
            else
                imgClicked = Properties.Resources.MissingTexture;
        }

        #region Events
        private void base_MouseEnter(object sender, EventArgs e)
        {
            Image = imgSelected;
            Cursor = CustomCursor.Load("Default.CUR");
            Sound.Play("Button\\Select.WAV");
        }
        private void base_MouseLeave(object sender, EventArgs e)
        {
            Image = imgIdle;
            Cursor = CustomCursor.Load("Default.CUR");
        }
        private void base_MouseDown(object sender, EventArgs e)
        {
            Image = imgClicked;
            Cursor = CustomCursor.Load("Default_Pressed.CUR");
            Sound.Play("Button\\Click.WAV");
        }
        private void base_MouseUp(object sender, EventArgs e)
        {
            Image = imgSelected;
            Cursor = CustomCursor.Load("Default.CUR");
        }
        #endregion
    }
}
