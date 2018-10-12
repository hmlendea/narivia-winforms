using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Narivia
{
    public partial class frmLoadGame : CustomForm
    {
        public frmGame frmGame { get; set; }
        public bool Loading { get; set; }

        public frmLoadGame()
        {
            InitializeComponent();

            LoadSavesList();
        }

        private void LoadSavesList()
        {
            if (Directory.Exists("Saves"))
            {
                DirectoryInfo dInfo = new DirectoryInfo("Saves\\");
                FileInfo[] save = dInfo.GetFiles();

                cmbSave.Items.Clear();
                for (int i = 0; i < save.Length; i++)
                    cmbSave.Items.Add(save[i].Name);

                if (cmbSave.Items.Count > 0)
                    cmbSave.SelectedIndex = 0;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbSave.Text != "")
            {
                Loading = true;
                frmGame = new frmGame();
            
                frmGame.LoadGame(cmbSave.Text);

                frmGame.FormClosed += delegate { this.Close(); };

                frmGame.Show();
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete '" + cmbSave.Text + "'?",
                "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                File.Delete("Saves\\" + cmbSave.Text);

                LoadSavesList();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
