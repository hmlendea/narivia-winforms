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
    public partial class frmSaveGame : CustomForm
    {
        frmGame frmGame { get; set; }

        public frmSaveGame(frmGame frmGame)
        {
            this.frmGame = frmGame;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSave.Text != "")
            {
                bool ok = true;

                if (File.Exists("Saves\\" + txtSave.Text + ".NSG"))
                    if (MessageBox.Show("Are you sure you want to overwrite '" + txtSave.Text + ".NSG" + "' ?", "Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        ok = false;

                if (ok)
                {
                    frmGame.SaveGame(txtSave.Text);
                    this.Close();
                }
            }
            else
                MessageBox.Show("Save name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
