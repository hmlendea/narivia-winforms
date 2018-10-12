using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;

namespace Narivia
{
    public partial class frmOptions : CustomForm
    {
        XmlDocument xmlOptions = new XmlDocument();

        public frmOptions()
        {
            InitializeComponent();

            pbNarivia.BackgroundImage = Properties.Resources.NariviaLogo;

            xmlOptions.Load("Options.XML");
            LoadOptions();
        }

        public void LoadOptions()
        {
            //Log.WriteLine("Reading Options.XML...");

            txtPlayerName.Text = Options.PlayerName;
            chkSound.Checked = Options.Sound;
            trkSoundVolume.Value = Options.SoundVolume;
            chkFullScreen.Checked = Options.FullScreen;
            chkAutoSave.Checked = Options.AutoSave;
            chkMapOverlay.Checked = Options.MapOverlay;

            ApplyOptions();
        }
        private void ApplyOptions()
        {
            Options.PlayerName = txtPlayerName.Text;
            Options.Sound = chkSound.Checked;
            Options.SoundVolume = trkSoundVolume.Value;
            Options.FullScreen = chkFullScreen.Checked;
            Options.AutoSave = chkAutoSave.Checked;
            Options.MapOverlay = chkMapOverlay.Checked;
        }
        private void SaveOptions()
        {
            Log.WriteLine("Applying Options...");

            Options.PlayerName = txtPlayerName.Text;
            Options.Sound = chkSound.Checked;
            Options.SoundVolume = trkSoundVolume.Value;
            Options.FullScreen = chkFullScreen.Checked;
            Options.AutoSave = chkAutoSave.Checked;
            Options.MapOverlay = chkMapOverlay.Checked;

            Options.Save();
        }
        private void trkSoundVolume_Scroll(object sender, EventArgs e)
        {
            if (trkSoundVolume.Value == 0)
                chkSound.Checked = false;
            else
                chkSound.Checked = true;
        }

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOptions();
            this.Close();
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            LoadOptions();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
