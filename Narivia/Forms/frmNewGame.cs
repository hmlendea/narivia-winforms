using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

using Narivia.Game;

namespace Narivia
{
    public partial class frmNewGame : CustomForm
    {
        World world;
        string[] internalNames;

        public frmNewGame()
        {
            InitializeComponent();

            pbNarivia.Image = Properties.Resources.NariviaLogo;

            InitliaizeWorld();
            LoadMapList();
        }
        private void frmNewGame_Load(object sender, EventArgs e)
        {
            if (cmbMap.Items.Count > 0)
                cmbMap.SelectedIndex = 0;
            else
                prgMapLoading.Visible = false;
        }

        private void cmbMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMap.Text != world.DisplayName)
            {
                grpMap.Enabled = false;
                ClearEverything();

                InitliaizeWorld();
                world.Load(internalNames[cmbMap.SelectedIndex]);

                for (int fct = 1; fct < world.Faction.Count; fct++)
                    cmbFaction.Items.Add(world.Faction[fct].Name);

                cmbFaction.SelectedIndex = 0;
                grpMap.Enabled = true;
            }
        }
        private void cmbFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int fct = cmbFaction.SelectedIndex + 1;

            pbFaction.Image = DrawingPlus.ResizeImage(world.Faction[fct].Symbol,
                pbFaction.Width, pbFaction.Height);

            lblFactionDescription.Text = world.Faction[fct].Description;
            lblAbilityDetails.Text = GetAbilityDetails(world.Faction[fct].Ability);

            pbMap.Image = GetFactionPreview(fct);
        }

        private void LoadMapList()
        {
            DirectoryInfo[] dirs = new DirectoryInfo(NarivianClass.MapsDirectory).GetDirectories();
            internalNames = new string[dirs.Length];

            cmbMap.Items.Clear();

            int k = 0;
            for (int i = 0; i < dirs.Length; i++)
                if (File.Exists(NarivianClass.MapsDirectory + dirs[i] + "\\World.XML"))
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load(NarivianClass.MapsDirectory + dirs[i] + "\\World.XML");
                    string displayName = xml.SelectSingleNode("World/DisplayName").InnerText;
                    string version = xml.SelectSingleNode("World/GameVersion").InnerText;

                    if (VersionChecker.CompareVersions(Application.ProductVersion.ToString(), version) >= 0)
                    {
                        cmbMap.Items.Add(displayName);
                        internalNames[k] = dirs[k].Name;
                        k += 1;
                    }
                    else
                        Log.WriteLine("Map '" + displayName + "' cannot be used because it has a GameVersion of " + version);
                }
        }
        private Image GetFactionPreview(int fct)
        {
            Bitmap bmp = (Bitmap)Image.FromFile(NarivianClass.MapsDirectory + internalNames[cmbMap.SelectedIndex] + "\\Map.PNG");
            FastBitmap bmpFast = new FastBitmap(bmp);
            Graphics g = Graphics.FromImage(bmp);

            Color clrFaction = world.Faction[fct].Color;
            Color clrWater = world.Faction[0].Color;

            bmpFast.LockBits();
            for (int i = 0; i < bmpFast.Height; i++)
                for (int j = 0; j < bmpFast.Width; j++)
                    if (world.Region[world.world[i, j]].Faction == cmbFaction.SelectedIndex + 1)
                        bmpFast.SetPixel(i, j, world.Faction[fct].Color);
                    else if (world.world[i, j] == 0)
                        bmpFast.SetPixel(i, j, world.Faction[0].Color);
                    else
                        bmpFast.SetPixel(i, j, Color.Black);
            bmpFast.UnlockBits();

            if (Options.MapOverlay && world.Overlay != null)
                g.DrawImage(world.Overlay, new Rectangle(0, 0, bmp.Width, bmp.Height));

            return bmp;
        }
        private string GetAbilityDetails(int abl)
        {
            return
                "Name: " + world.Ability[abl].Name + Environment.NewLine +
                "Income: " + world.Ability[abl].IncomeBonus + " Outcome: " + world.Ability[abl].OutcomeBonus + Environment.NewLine +
                "Attack: " + world.Ability[abl].AttackBonus + " Defence: " + world.Ability[abl].DefenceBonus + Environment.NewLine +
                "Recruitment: " + world.Ability[abl].RecruitmentBonus;
        }
        private void ClearEverything()
        {
            pbMap.Image = null;
            cmbFaction.Items.Clear();
            lblAbilityDetails.Text = null;
            lblFactionDescription.Text = null;

            Refresh();
        }

        #region Buttons
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (cmbMap.Text != "")
            {
                if (cmbFaction.Text != "")
                {
                    frmGame frmGame = new frmGame();

                    frmGame.HomelandPriority = chkHomelandPriority.Checked;

                    frmGame.NewGame(internalNames[cmbMap.SelectedIndex], cmbFaction.SelectedIndex + 1);

                    frmGame.FormClosed += delegate { this.Close(); };
                    //frmGame.Load += delegate { this.Hide(); };

                    frmGame.Show();
                    Hide();
                }
                else
                    MessageBox.Show(
                        "You have to choose a faction first",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(
                    "You have to choose a map first",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void InitliaizeWorld()
        {

            world = new World();
            world.LoadingProgressChanged += delegate
            {
                if (world.LoadingProgress == 100)
                    prgMapLoading.Visible = false;
                else
                    prgMapLoading.Visible = true;

                prgMapLoading.Value = world.LoadingProgress;
            };
        }

        private void pnlFactionDescription_Resize(object sender, EventArgs e)
        {
            lblFactionDescription.MaximumSize = new Size(pnlFactionDescription.Size.Width - 17, 0);
        }

        private void btnDownloadMaps_Click(object sender, EventArgs e)
        {
            frmDownloadMaps frmDownloadMaps = new frmDownloadMaps();
            frmDownloadMaps.ShowDialog();
        }
    }
}
