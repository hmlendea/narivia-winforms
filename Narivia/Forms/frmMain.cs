using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Narivia
{
    public partial class frmMain : CustomForm
    {
        public frmMain()
        {
            InitializeComponent();
            
            pbNarivia.Image = Properties.Resources.NariviaLogo;

            lblVersion.Text += Application.ProductVersion;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            frmNewGame frmNewGame = new frmNewGame();

            frmNewGame.FormClosed += delegate { this.Show(); UpdateFormWindowState(); };
            frmNewGame.Load += delegate { Application.DoEvents();  this.Hide(); };

            frmNewGame.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("n-avem, ii criza!");
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            frmEditor frmEditor = new frmEditor();

            frmEditor.FormClosed += delegate { this.Show(); };
            frmEditor.Show();
            frmEditor.Load += delegate { this.Hide(); };
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions frmOptions = new frmOptions();
            frmOptions.Show();
            frmOptions.FormClosed += delegate { UpdateFormWindowState(); };
        }

        private void btnMoreGames_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.google.com/spreadsheet/pub?key=0Am6tel9lYl4ydERWZ3Vwak1LUGxfUmxFX1ljQllZblE&output=html");
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            frmLoadGame frmLoadGame = new frmLoadGame();
            frmLoadGame.ShowDialog();
            frmLoadGame.FormClosing += delegate
            {
                if (frmLoadGame.Loading)
                {
                    Hide();

                    frmLoadGame.frmGame.FormClosing += delegate { this.Show(); };
                }
            };
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            VersionChecker.CheckVersion();
        }
    }
}
