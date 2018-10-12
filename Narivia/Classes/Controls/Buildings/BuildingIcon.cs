using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using WMPLib;

using Narivia.Game;

namespace Narivia
{
    class BuildingIcon : Button
    {
        WindowsMediaPlayer WMP = new WindowsMediaPlayer();

        public World World { get; set; }
        public int BuildingID { get; set; }
        public int RegionID { get; set; }
        public int BiomeID { get { return World.Region[RegionID].Biome; } }
        public int CultureID { get { return World.Region[RegionID].BuildingCulture[BuildingID]; } }
        public string BuildingName { get { return World.Building[BuildingID].Name; } }

        public BuildingIcon(World world, int buildingID, int regionID)
        {
            World = world;
            BuildingID = buildingID;
            RegionID = regionID;

            base.Tag = BuildingName;
            base.Size = new Size(78, 62);
            base.BackColor = Color.Transparent;
            base.FlatAppearance.BorderSize = 0;
            base.FlatAppearance.BorderColor = Color.White;
            base.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            base.FlatAppearance.MouseDownBackColor = Color.Gold;
            base.FlatStyle = FlatStyle.Flat;
            base.Image = GenerateBuildingImage();

            InitializeEvents();
        }
        private void InitializeEvents()
        {
            base.MouseEnter += new System.EventHandler(this.base_MouseEnter);
            base.MouseLeave += new System.EventHandler(this.base_MouseLeave);
            base.MouseDown += new System.Windows.Forms.MouseEventHandler(this.base_MouseDown);
            base.MouseUp += new System.Windows.Forms.MouseEventHandler(this.base_MouseUp);
        }
        private Image GenerateBuildingImage()
        {
            Bitmap bmp = new Bitmap(base.Width, base.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(World.Biome[BiomeID].Terrain, 0, 0, base.Width, base.Height);

                string buildingName = BuildingName;

                if (BuildingID == 0)
                    if (World.Region[RegionID].Type == RegionType.Capital)
                        buildingName = "Capital Pallace";
                    else
                        buildingName = "City Pallace";
                
                if (BuildingID == 0)
                    g.DrawImage(DrawingPlus.LoadImage(NarivianClass.AssetsDirectory + World.AssetsPack + "\\Buildings\\" + World.Culture[CultureID].Name + "\\Small\\" + buildingName + ".PNG"), 0, 0, base.Width, base.Height);
                else
                    g.DrawImage(World.Building[BuildingID].Icon[CultureID], 0, 0, base.Width, base.Height);
            }

            return (Image)bmp;
        }
        /*Anti-Flicker
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }*/
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
        }
        private void base_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = CustomCursor.Load("Default.CUR");

            string body = World.Building[BuildingID].Description + Environment.NewLine + Environment.NewLine;

            if (BuildingID != 0)
            {
                body += "Maintenance: " + World.Building[BuildingID].Maintenance;

                if (World.Building[BuildingID].Income != 0)
                    body += Environment.NewLine + "Income: " + World.Building[BuildingID].Income;
                if (World.Building[BuildingID].AttackBonus != 0)
                    body += Environment.NewLine + "Attack Bonus: " + World.Building[BuildingID].AttackBonus;
                if (World.Building[BuildingID].DefenceBonus != 0)
                    body += Environment.NewLine + "Defence Bonus: " + World.Building[BuildingID].DefenceBonus;
                if (World.Building[BuildingID].RecruitmentBonus != 0)
                    body += Environment.NewLine + "Recruitment Bonus: " + World.Building[BuildingID].RecruitmentBonus;
                if (World.Building[BuildingID].ReligionInfluence != 0)
                    body += Environment.NewLine + "Religion Influence: " + World.Building[BuildingID].ReligionInfluence;
            }
            else
            {
                if (World.Region[RegionID].Type == RegionType.Capital)
                    body += "Income: " + World.BaseRegionIncome * 2;
                else
                    body += "Income: " + World.BaseRegionIncome;
            }

            if (e.Button == MouseButtons.Left)
                Notice.Show(body, BuildingName, "Buildings\\" + BuildingName);
            else if (e.Button == MouseButtons.Right)
            {
                if (BuildingID != 0)
                    if (Notice.Show(
                        "Do you want to demolish this building?",
                        BuildingName, "Buildings\\" + BuildingName) == DialogResult.Yes)
                        MessageBox.Show("Inca nu se pot sterge cladirile decat din meniu sau din consola cu 'region removebuilding <regId> <buildingId>'");
                    else
                        Notice.Show("You cannot demolish this building!", BuildingName, "Buildings\\" + BuildingName);
            }
        }
        #endregion
    }
}
