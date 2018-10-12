using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Narivia.Game;

namespace Narivia
{
    public partial class frmBuild : CustomForm
    {
        frmGame frmGame { get; set; }
        int BuildingID { get; set; }
        int RegionID { get; set; }

        public frmBuild(frmGame frmGame)
        {
            InitializeComponent();
            this.frmGame = frmGame;

            BuildingID = -1;
            RegionID = frmGame.selectedRegion;

            World world = frmGame.World;

            pbMoney.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "Money.PNG");
            pbMoney2.Image = pbMoney.Image;

            lblMoney.Text = frmGame.World.Faction[frmGame.Player].Money.ToString();

            UpdateBuildingList();
        }

        private void UpdateBuildingList()
        {
            World world = frmGame.World;

            pnlBuilding.Visible = false;
            pnlBuildings.Controls.Clear();

            int k = 0;
            for (int i = 1; i < world.Building.Count; i++)
                if (world.Building[i].RequiredResource == 0 ||
                    world.Building[i].RequiredResource == world.Region[RegionID].Resource)
                {
                    bool ok = true;
                    for (int j = 0; j < world.Region[RegionID].BuildingsCount; j++)
                        if (world.Region[RegionID].Building[j] == i)
                            ok = false;

                    if (ok)
                    {
                        BuildingListItem bli = new BuildingListItem(
                            world.Building[i],
                            world.Faction[world.Region[RegionID].Faction].Culture);

                        bli.Location = new Point(0, 0 + k * bli.Height);

                        bli.Click += new EventHandler(BuildingListItem_Click);
                        //bli.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

                        pnlBuildings.Controls.Add(bli);
                        k += 1;
                    }
                }
        }

        private void BuildingListItem_Click(object sender, EventArgs e)
        {
            Building building = ((BuildingListItem)sender).Building;
            Game.Region region = frmGame.World.Region[frmGame.selectedRegion];
            int cultureID = frmGame.World.Faction[frmGame.Player].Culture;

            if (pnlBuilding.Visible == false)
                pnlBuilding.Visible = true;

            BuildingID = building.ID;

            lblBuildingName.Text = building.Name;
            lblPrice.Text = building.Price.ToString();

            pbIcon.Image = building.Icon[cultureID];
            lblDetails.Text = building.Description + "\n\n";

            lblDetails.Text += "Maintenance: " + building.Maintenance;

            if (building.Income != 0)
                lblDetails.Text += "\nIncome: " + building.Income;
            if (building.AttackBonus != 0)
                lblDetails.Text += "\nAttack Bonus: " + building.AttackBonus;
            if (building.DefenceBonus != 0)
                lblDetails.Text += "\nDefence Bonus: " + building.DefenceBonus;
            if (building.RecruitmentBonus != 0)
                lblDetails.Text += "\nRecruitment Bonus: " + building.RecruitmentBonus;
            if (building.ReligionInfluence != 0)
                lblDetails.Text += "\nReligion Influence: " + building.ReligionInfluence;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            if (BuildingID != -1)
            {
                World World = frmGame.World;
                int Player = frmGame.Player;

                if (World.Faction[Player].Money - World.Building[BuildingID].Price >= 0)
                {
                    if (Notice.Show(
                        "Are you sure you want to build the " + lblBuildingName.Text + " for " + lblPrice.Text + " gold?",
                        World.Building[BuildingID].Name, "Buildings\\" + World.Building[BuildingID].Name)
                        == DialogResult.Yes)
                    {
                        frmGame.BuildBuilding(RegionID, BuildingID);
                        lblMoney.Text = frmGame.World.Faction[frmGame.Player].Money.ToString();

                        frmGame.UpdateRegionInfo(RegionID);
                        frmGame.UpdateInfoBar();

                        UpdateBuildingList();
                    }
                }
                else
                    Notice.Show("Not enough gold to build this!",
                        lblBuildingName.Text, "Buildings\\" + World.Building[BuildingID].Name);
            }
        }
    }
}
