using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Xml;

using Narivia.Game;
using Narivia.Battles;

namespace Narivia
{
    public partial class frmGame : CustomForm
    {
        #region Variables
        public World World { get; set; }
        private RegionToolTip tipRegion = new RegionToolTip();
        private CustomToolTip InfoBarToolTip = new CustomToolTip();
        string relationsChanged = "";
        string undo = "";
        string buildingsReport = "";
        public bool HomelandPriority { get; set; }
        #region Reference variables
        public bool isRunning = false;
        public int Player
        {
            get { return World.Player; }
            set
            {
                World.Player = value;
                lblPlayerName.Text = World.Faction[value].Name;
                pbLogoPlayer.Image = DrawingPlus.ResizeImage(
                    World.Faction[value].Symbol,
                    pbLogoPlayer.Width, pbLogoPlayer.Height);
                UpdateInfoBar();
                NoticeBoard.Clear();
                UpdateRegionInfo(0);
            }
        }
        public int selectedRegion = 0;
        public int Turn
        {
            get { return turn; }
            set
            {
                turn = value;
                lblTurn.Text = "Turn " + value.ToString();
            }
        } int turn;
        string MapName { get; set; }
        #endregion
        #endregion

        #region Form Open & Close
        public frmGame()
        {
            InitializeComponent();
            InitializeBackgrounds();
            InitializeInfoBar();

            RegionBar.SetGame(this);

            Size = Options.Resolution;

            NoticeBoard.Height = 0;
            NoticeBoard.MaximumSize = new Size(65, pnlMap.Height);

            Cursor = CustomCursor.Load("Default.CUR");
        }
        private void StartGame()
        {
            World world = World;
            BuildingsPanel.SetWorld(ref world);

            World.DrawMap(Map);

            isRunning = true;
            selectedRegion = 0;
            UpdateRegionInfo(selectedRegion);

            this.Hide(); // Ca sa nu apara Welcome-ul inaintea Form-ului
            this.Show(); //

            UpdateInfoBar();

            Notice.Show(
                "Welcome to the world of " + World.DisplayName + "!" + Environment.NewLine + Environment.NewLine +
                "Use the left click to attack regions and the right click to get info" + Environment.NewLine + Environment.NewLine +
                "Note: Use the Y and N keys to quickly accept or decline Notices" + Environment.NewLine,
                "Welcome", "Welcome");
        }
        private void frmGame_Resize(object sender, EventArgs e)
        {
            if (Map.Size.Width < pnlMap.Size.Width)
                Map.Location = new Point((pnlMap.Size.Width - SystemInformation.VerticalScrollBarWidth - Map.Size.Width) / 2, Map.Location.Y);
            if (Map.Size.Height < pnlMap.Size.Height)
                Map.Location = new Point(Map.Location.X, (pnlMap.Size.Height - Map.Size.Height) / 2);
        }
        private void InitializeBackgrounds()
        {
            Panel.BackgroundImage = Properties.Resources.Stone_Bricks;
            InfoBar.BackgroundImage = Image.FromFile(NarivianClass.PanelsDirectory + "InfoBar.PNG");
            pnlMap.BackgroundImage = Properties.Resources.Stone_Bricks;
            BuildingsPanel.BackgroundImage = Image.FromFile(NarivianClass.PanelsDirectory + "Paper.PNG");
        }

        private void InitializeInfoBar()
        {
            pbRegions.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "Regions.PNG");
            pbTroops.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "Troops.PNG");
            pbMoney.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "Money.PNG");
            pbAttackBonus.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "AttackBonus.PNG");
            pbDefenceBonus.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "DefenceBonus.PNG");
            pbRecruitmentBonus.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "RecruitmentBonus.PNG");

            InfoBarToolTip.SetToolTip(pbRegions, "Regions");
            InfoBarToolTip.SetToolTip(pbTroops, "Troops");
            InfoBarToolTip.SetToolTip(pbMoney, "Money");
            InfoBarToolTip.SetToolTip(pbAttackBonus, "Attack Bonus");
            InfoBarToolTip.SetToolTip(pbDefenceBonus, "Defence Bonus");
            InfoBarToolTip.SetToolTip(pbRecruitmentBonus, "Recruitment Bonus");
        }

        public void NewGame(string map, int player)
        {
            World = new World();
            World.Load(map);

            MapName = map;
            Player = player;

            StartGame();
        }
        public void LoadGame(string save)
        {
            World = new World();

            XmlDocument xmlSave = new XmlDocument();

            xmlSave.Load("Saves\\" + save);

            MapName = xmlSave.SelectSingleNode("Save/Map").InnerText;
            World.Load(MapName);

            Player = Convert.ToInt32(xmlSave.SelectSingleNode("Save/Player").InnerText);
            Turn = Convert.ToInt32(xmlSave.SelectSingleNode("Save/Turn").InnerText);
            
            HomelandPriority = Convert.ToBoolean(xmlSave.SelectSingleNode("Save/HomelandPriority").InnerText);
            chkDeclineLiberations.Checked = Convert.ToBoolean(xmlSave.SelectSingleNode("Save/DeclineLiberations").InnerText);
            chkAutoBuild.Checked = Convert.ToBoolean(xmlSave.SelectSingleNode("Save/AutoBuild").InnerText);
            chkAutoRecruit.Checked = Convert.ToBoolean(xmlSave.SelectSingleNode("Save/AutoRecruit").InnerText);

            #region Factions
            int fct = 0;

            foreach (XmlNode xmlNode in xmlSave.SelectNodes("Save/Factions/Faction"))
            {
                World.Faction[fct].Region = new int[World.Region.Count];
                World.Faction[fct].RegionCount = 0;

                // Units
                for (int i = 0; i < World.Unit.Count; i++)
                    World.Faction[fct].Units[i] = Convert.ToInt32(xmlNode.SelectNodes("Units/Unit")[i].InnerText);
                
                // Relations
                foreach (XmlNode xmlNode2 in xmlNode.SelectNodes("Relations/Relation"))
                    World.relations[fct, Convert.ToInt32(xmlNode2.SelectSingleNode("Faction").InnerText)] = Convert.ToInt32(xmlNode2.SelectSingleNode("Value").InnerText);

                World.Faction[fct].Money = Convert.ToInt32(xmlNode["Money"].InnerText);
                World.Faction[fct].Income = Convert.ToInt32(xmlNode["Income"].InnerText);
                World.Faction[fct].Outcome = Convert.ToInt32(xmlNode["Outcome"].InnerText);

                fct += 1;
            }
            #endregion
            #region Regions
            int reg = 0;

            foreach (XmlNode xmlNode in xmlSave.SelectNodes("Save/Regions/Region"))
            {
                World.Region[reg].Faction = Convert.ToInt32(xmlNode["Faction"].InnerText);
                World.Faction[World.Region[reg].Faction].Region[World.Faction[World.Region[reg].Faction].RegionCount] = reg;
                World.Faction[World.Region[reg].Faction].RegionCount += 1;

                // Buildings
                foreach (XmlNode xmlNode2 in xmlNode.SelectNodes("Buildings/Building"))
                {
                    World.Region[reg].Building[World.Region[reg].BuildingsCount] = Convert.ToInt32(xmlNode2.SelectSingleNode("ID").InnerText);
                    World.Region[reg].BuildingCulture[World.Region[reg].BuildingsCount] = Convert.ToInt32(xmlNode2.SelectSingleNode("Culture").InnerText);

                    World.Region[reg].BuildingsCount += 1;
                }

                // Religions
                World.Region[reg].Religion = new int[World.Religion.Count];

                foreach (XmlNode xmlNode2 in xmlNode.SelectNodes("Religions/Religion"))
                {
                    int rel = Convert.ToInt32(xmlNode2.SelectSingleNode("ID").InnerText);
                    World.Region[reg].Religion[rel] = Convert.ToInt32(xmlNode2.SelectSingleNode("Influence").InnerText);
                }

                reg += 1;
            }
            #endregion

            StartGame();
        }
        public void SaveGame(string saveName)
        {
            Log.WriteLine("Saving game '" + saveName + "'...");

            XmlDocument xmlSave = new XmlDocument();
            XmlElement xmlSaveRoot = (XmlElement)xmlSave.AppendChild(xmlSave.CreateElement("Save"));
            
            xmlSaveRoot.AppendChild(xmlSave.CreateElement("Map")).InnerText = MapName;
            xmlSaveRoot.AppendChild(xmlSave.CreateElement("Player")).InnerText = Player.ToString();
            xmlSaveRoot.AppendChild(xmlSave.CreateElement("Turn")).InnerText = Turn.ToString();
            xmlSaveRoot.AppendChild(xmlSave.CreateElement("HomelandPriority")).InnerText = HomelandPriority.ToString();
            xmlSaveRoot.AppendChild(xmlSave.CreateElement("DeclineLiberations")).InnerText = chkDeclineLiberations.Checked.ToString();
            xmlSaveRoot.AppendChild(xmlSave.CreateElement("AutoBuild")).InnerText = chkAutoBuild.Checked.ToString();
            xmlSaveRoot.AppendChild(xmlSave.CreateElement("AutoRecruit")).InnerText = chkAutoRecruit.Checked.ToString();

            #region Factions
            XmlElement xmlSavefactions = (XmlElement)xmlSaveRoot.AppendChild(xmlSave.CreateElement("Factions"));
            for (int fct = 0; fct < World.Faction.Count; fct++)
            {
                XmlElement xmlSavefaction = (XmlElement)xmlSavefactions.AppendChild(xmlSave.CreateElement("Faction"));
                
                // Units
                XmlElement xmlSavefactionUnits = (XmlElement)xmlSavefaction.AppendChild(xmlSave.CreateElement("Units"));
                for (int untPos = 0; untPos < World.Unit.Count; untPos++)
                    xmlSavefactionUnits.AppendChild(xmlSave.CreateElement("Unit")).InnerText = World.Faction[fct].Units[untPos].ToString();

                // Relations
                XmlElement xmlSavefactionRelations = (XmlElement)xmlSavefaction.AppendChild(xmlSave.CreateElement("Relations"));
                for (int fct2 = 0; fct2 < World.Faction.Count; fct2++)
                {
                    if (World.relations[fct, fct2] != 0)
                    {
                        XmlElement xmlSavefactionRelation = (XmlElement)xmlSavefactionRelations.AppendChild(xmlSave.CreateElement("Relation"));

                        xmlSavefactionRelation.AppendChild(xmlSave.CreateElement("Faction")).InnerText = fct2.ToString();
                        xmlSavefactionRelation.AppendChild(xmlSave.CreateElement("Value")).InnerText = World.relations[fct, fct2].ToString();
                    }
                }
                // Money
                xmlSavefaction.AppendChild(xmlSave.CreateElement("Money")).InnerText = World.Faction[fct].Money.ToString();
                xmlSavefaction.AppendChild(xmlSave.CreateElement("Income")).InnerText = World.Faction[fct].Income.ToString();
                xmlSavefaction.AppendChild(xmlSave.CreateElement("Outcome")).InnerText = World.Faction[fct].Outcome.ToString();
            }
            #endregion
            #region Regions
            XmlElement xmlSaveRegions = (XmlElement)xmlSaveRoot.AppendChild(xmlSave.CreateElement("Regions"));
            for (int reg = 0; reg < World.Region.Count; reg++)
            {
                XmlElement xmlSaveRegion = (XmlElement)xmlSaveRegions.AppendChild(xmlSave.CreateElement("Region"));

                xmlSaveRegion.AppendChild(xmlSave.CreateElement("Faction")).InnerText = World.Region[reg].Faction.ToString();

                // Buildings
                XmlElement xmlSaveRegionBuildngs = (XmlElement)xmlSaveRegion.AppendChild(xmlSave.CreateElement("Buildings"));
                for (int bldPos = 1; bldPos < World.Region[reg].BuildingsCount; bldPos++)
                {
                    if (World.Region[reg].Building[bldPos] != 0)
                    {
                        XmlElement xmlSaveRegionBuilding = (XmlElement)xmlSaveRegionBuildngs.AppendChild(xmlSave.CreateElement("Building"));

                        xmlSaveRegionBuilding.AppendChild(xmlSave.CreateElement("ID")).InnerText = World.Region[reg].Building[bldPos].ToString();
                        xmlSaveRegionBuilding.AppendChild(xmlSave.CreateElement("Culture")).InnerText = World.Region[reg].BuildingCulture[bldPos].ToString();
                    }
                }

                // Religions
                XmlElement xmlSaveRegionReligions = (XmlElement)xmlSaveRegion.AppendChild(xmlSave.CreateElement("Religions"));
                for (int rel = 0; rel < World.Religion.Count; rel++)
                {
                    if (World.Region[reg].Religion[rel] != 0)
                    {
                        XmlElement xmlSaveRegionReligion = (XmlElement)xmlSaveRegionReligions.AppendChild(xmlSave.CreateElement("Religion"));

                        xmlSaveRegionReligion.AppendChild(xmlSave.CreateElement("ID")).InnerText = rel.ToString();
                        xmlSaveRegionReligion.AppendChild(xmlSave.CreateElement("Influence")).InnerText = World.Region[reg].Religion[rel].ToString();
                    }
                }
            }
            #endregion

            if (Directory.Exists("Saves\\") == false)
                Directory.CreateDirectory("Saves\\");
            xmlSave.Save("Saves\\" + saveName + ".NSG");

            NoticeBoard.Add("Game saved sucessfully as '" + saveName + ".NSG'!", "Game Saved", "Saved");
        }
        #endregion

        #region Turn Control
        private void EndTurn()
        {
            if (Options.AutoSave)
                SaveGame("AutoSave");

            isRunning = false;
            Random rnd = new Random();

            NoticeBoard.Clear();

            for (int fct = 1; fct < World.Faction.Count; fct++)
                if (World.Faction[fct].Alive)
                {
                    // Economy
                    World.Faction[fct].Income = World.GetIncome(fct);
                    World.Faction[fct].Outcome = World.GetOutcome(fct);
                    World.Faction[fct].Money += World.Faction[fct].Income;
                    World.Faction[fct].Money -= World.Faction[fct].Outcome;

                    // Build
                    if (fct != Player)
                        if (World.Faction[fct].Alive)
                            AiBuild(fct, HomelandPriority);

                    // Recruitment
                    int recruits = World.Faction[fct].RegionCount * World.BaseRegionRecruitment;

                    recruits += World.RecruitmentRate.Random;
                    recruits += World.GetRecruitmentBonus(fct);

                    World.Faction[fct].Units[0] += recruits;

                    if (fct != Player)
                        AiRecruit(fct);
                    
                    // Religion
                    AiSpreadReligion(fct);

                    // Attack
                    if (fct != Player)
                        if (World.Faction[fct].Units[0] >= World.MinTroopsAttack)
                            AiAttack(fct, HomelandPriority);

                    // Player Build
                    if (fct.Equals(Player) == chkAutoBuild.Checked)
                        AiBuild(fct, HomelandPriority);

                    // Player Recruit
                    if (fct.Equals(Player) == chkAutoRecruit.Checked)
                        AiRecruit(fct);

                    // Victory
                    if(World.Faction[fct].RegionCount == World.Region.Count - World.Faction[0].RegionCount)
                    {
                        Notice.Show(World.Faction[fct].Name + " conquered the whole world of " + World.DisplayName + " and achieved ultimate victory in " + turn + " turns!",
                            World.Faction[fct].Name + " won!", "Victory");
                        Close();
                    }
                }

            for (int reg = 1; reg < World.Region.Count; reg++)
                World.Region[reg].IsProtected = false;
            
            CheckForWinner();

            Turn += 1;
            //lblTurn.Text = "Turn: " + turn;
            UpdateInfoBar();

            World.DrawMap(Map);

            isRunning = true;

            if (relationsChanged != "")
            {
                NoticeBoard.Add(relationsChanged, "Relations Changed", "Relations");
                relationsChanged = "";
            }

            if (buildingsReport != "")
            {
                NoticeBoard.Add(buildingsReport, "Buildings Report", "BuildingsReport");
                buildingsReport = "";
            }

            //UpdateRegionInfo(0);
            btnTurnReport_Click(this, EventArgs.Empty);
        }
        private void CheckForWinner()
        {
            int fctWinner = 0;
            bool ok = true;

            for (int fct = 1; fct < World.Faction.Count; fct++)
                if (World.Faction[fct].Alive)
                {
                    if (fct != fctWinner)
                    {
                        ok = false;
                        break;
                    }

                    fctWinner = fct;
                }

            if (ok)
            {
                Notice.Show(
                    "The Great War of the World of " + World.DisplayName + " is now over and have been won by the " + World.Faction[fctWinner].Name + " faction who now rules over all it's lands and people!" + Environment.NewLine + Environment.NewLine +
                    "Turns played: " + Turn,
                    World.Faction[fctWinner].Name + " won the game!", "GameFinished");
            }

            if (World.Faction[Player].Alive == false)
                Notice.Show(
                    "You have been defeated!" + Environment.NewLine + Environment.NewLine +
                    "Turns played: " + Turn,
                    "Defeat", "FactionDestroyed");
        }
        public void UpdateInfoBar()
        {
            lblRegions.Text = (World.Faction[Player].RegionCount).ToString();
            lblTroops.Text = (World.Faction[Player].UnitsCount).ToString();
            lblMoney.Text = (World.Faction[Player].Money).ToString();
            int income = World.Faction[Player].Income - World.Faction[Player].Outcome;
            if (income >= 0)
                lblMoney.Text += " (+" + income + ")";
            else
                lblMoney.Text += " (" + income + ")";
            lblAttackBonus.Text = (World.GetAttackBonus(Player)).ToString();
            lblDefenceBonus.Text = (World.GetDefenceBonus(Player)).ToString();
            lblRecruitmentBonus.Text = (World.GetRecruitmentBonus(Player)).ToString();

            pbTroops.Location = new Point(lblRegions.Location.X + lblRegions.Size.Width + 6, pbTroops.Location.Y);
            lblTroops.Location = new Point(pbTroops.Location.X + pbTroops.Size.Width + 6, lblTroops.Location.Y);
            pbMoney.Location = new Point(lblTroops.Location.X + lblTroops.Size.Width + 6, pbMoney.Location.Y);
            lblMoney.Location = new Point(pbMoney.Location.X + pbMoney.Size.Width + 6, lblMoney.Location.Y);
            pbAttackBonus.Location = new Point(lblMoney.Location.X + lblMoney.Size.Width + 16, pbAttackBonus.Location.Y);
            lblAttackBonus.Location = new Point(pbAttackBonus.Location.X + pbAttackBonus.Size.Width + 6, lblAttackBonus.Location.Y);
            pbDefenceBonus.Location = new Point(lblAttackBonus.Location.X + lblAttackBonus.Size.Width + 6, pbDefenceBonus.Location.Y);
            lblDefenceBonus.Location = new Point(pbDefenceBonus.Location.X + pbDefenceBonus.Size.Width + 6, lblDefenceBonus.Location.Y);
            pbRecruitmentBonus.Location = new Point(lblDefenceBonus.Location.X + lblDefenceBonus.Size.Width + 6, pbRecruitmentBonus.Location.Y);
            lblRecruitmentBonus.Location = new Point(pbRecruitmentBonus.Location.X + pbRecruitmentBonus.Size.Width + 6, lblRecruitmentBonus.Location.Y);

            string units = "";
            for(int unt = 0; unt < World.Unit.Count; unt++)
                units += World.Unit[unt].Name + ": " + World.Faction[Player].Units[unt] + Environment.NewLine;
            
            InfoBarToolTip.SetToolTip(pbTroops,
                "Troops" + Environment.NewLine + Environment.NewLine + units);
        }
        #endregion

        #region Mouse Events & Cursor
        private void Map_MouseDown(object sender, MouseEventArgs e)
        {
            if (isRunning)
            {
                Map.Cursor = CustomCursor.Load("Default_Pressed.cur");

                if (e.Button == MouseButtons.Left)
                {
                    if (chkSelect.Checked)
                    {
                        if (World.world[e.X, e.Y] != selectedRegion)
                        {
                            UpdateRegionInfo(World.world[e.X, e.Y]);
                            selectedRegion = World.world[e.X, e.Y];
                        }

                        if (World.Region[World.world[e.X, e.Y]].Faction != 0 && World.Region[World.world[e.X, e.Y]].Faction != Player)
                        {
                            //frmBattle.ShowBox(
                            //    ref world,
                            //    player,
                            //    World.Region[World.world[e.X, e.Y]].Faction,
                            //    World.world[e.X, e.Y]);

                            PlayerAttack(World.world[e.X, e.Y]);
                            Map_MouseUp(sender, e);
                            Map.Cursor = CustomCursor.Load("Default.CUR");
                        }
                    }
                    else if (chkSpy.Checked)
                        if (World.Region[World.world[e.X, e.Y]].Faction != 0 && World.Region[World.world[e.X, e.Y]].Faction != Player)
                        {
                            PlayerSpy(World.world[e.X, e.Y]);
                            Map_MouseUp(sender, e);
                        }
                }

                else if (e.Button == MouseButtons.Right)
                {

                    if (World.world[e.X, e.Y] != selectedRegion)
                    {
                        UpdateRegionInfo(World.world[e.X, e.Y]);
                        selectedRegion = World.world[e.X, e.Y];
                    }

                    if (World.Region[World.world[e.X, e.Y]].Faction != 0)
                        tipRegion.ShowTip(World, selectedRegion, Map, e.X + 25, e.Y + 25);
                    else
                        tipRegion.Hide(Map);
                }
            }
        }
        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRunning && e.X >= 0 && e.X < Map.Height && e.Y >= 0 && e.Y < Map.Width)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (chkSelect.Checked)
                        Map_MouseDown(sender, e);
                }
                else if (e.Button == MouseButtons.Right)
                    if (e.X >= 0 && e.X < Map.Height && e.Y >= 0 && e.Y < Map.Width)
                        if (selectedRegion != World.world[e.X, e.Y])
                            Map_MouseDown(sender, e);
            }
        }
        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            if (chkSelect.Checked)
                Map.Cursor = CustomCursor.Load("Default.CUR");
            else if (chkSpy.Checked)
                Map.Cursor = CustomCursor.Load("Spy.CUR");

            if (e.Button == MouseButtons.Right)
                tipRegion.Hide(Map);
        }
        private void chkAttack_CheckedChanged(object sender, EventArgs e)
        {
            Map.Cursor = CustomCursor.Load("Default.CUR");
        }
        private void chkSpy_CheckedChanged(object sender, EventArgs e)
        {
            Map.Cursor = CustomCursor.Load("Spy.cur");
        }
        #endregion

        #region Actions
        #region Others
        private void PlayerSpy(int reg)
        {
            int fct = World.Region[reg].Faction;

            Notice.Show(
                "Faction: " + World.Faction[fct].Name + Environment.NewLine +
                "Relations: " + NarivianClass.RelationsToString(World.relations[Player, fct]) + " (" + World.relations[Player, fct] + ")" + Environment.NewLine +
                "Ability: " + World.Ability[World.Faction[fct].Ability].Name + Environment.NewLine +
                "Culture: " + World.Culture[World.Faction[fct].Culture].Name + Environment.NewLine +
                "Troops: " + World.Faction[fct].Units[0] + Environment.NewLine +
                "Money: " + World.Faction[fct].Money + " (+" + (World.Faction[fct].Income - World.Faction[fct].Outcome) + " per turn)" + Environment.NewLine +
                "Regions: " + World.Faction[fct].RegionCount + Environment.NewLine +
                "Combat Bonus: Atk:" + World.GetAttackBonus(fct) + " Def:" + World.GetDefenceBonus(fct) + Environment.NewLine +
                "Recruitment Bonus: " + World.GetRecruitmentBonus(fct) + Environment.NewLine +
                "Region: " + World.Region[reg].Name + Environment.NewLine +
                "Resource: " + World.Resource[World.Region[reg].Resource].Name,
                "Espionage Report", "EspionageReport");
        }
        private void UpdateRegionList(int fct)
        {
            World.Faction[fct].Region = new int[World.Region.Count];

            int i = 0;
            for (int reg = 1; reg < World.Region.Count; reg++)
                if (World.Region[reg].Faction == fct)
                {
                    World.Faction[fct].Region[i] = reg;
                    i++;
                }
            World.Faction[fct].RegionCount = i;
        }
        #endregion
        #region Attacking
        private void PlayerAttack(int reg)
        {
            if (World.Faction[Player].UnitsCount >= World.MinTroopsAttack)
            {
                if (!World.Region[reg].IsProtected &&
                World.Region[reg].Faction != Player &&
                World.Region[reg].Faction != 0 &&
                World.HasBorder(Player, reg))
                {
                    int defender = World.Region[reg].Faction;

                    if (Notice.Show(
                    "Are you sure you wish to attack the " + World.Faction[defender].Name + " factionin the " + World.Region[reg].Name + " region?" + Environment.NewLine + Environment.NewLine +
                    "Your troops: " + World.Faction[Player].UnitsCount + Environment.NewLine +
                    "Defender troops: " + World.Faction[defender].UnitsCount,
                    "Attack " + World.Region[reg].Name + "?", "ConfirmAttack") == DialogResult.Yes)
                    {
                        World world = World;

                        if(Battle.Start(ref world, Player, World.Region[reg].Faction, reg) == BattleResult.Won)
                        {
                            TransferRegion(reg, Player);

                            if (World.Region[reg].OriginalFaction == Player)
                            {
                                if (World.Region[reg].Type == RegionType.Capital)
                                    Notice.Show(
                                        "Great news!" + Environment.NewLine + Environment.NewLine +
                                        "Our brave troops sucessfully liberated our Capital City, " + World.Region[reg].Name + ", from the " + World.Faction[defender].Name + " occupation!",
                                        "Victory!", "Victory_Capital");
                                else
                                    Notice.Show(
                                        "Our brave troops sucessfully liberated one of our homeland regions, " + World.Region[reg].Name + ", from " + World.Faction[defender].Name + " occupation!",
                                        "Victory!", "Victory");
                            }
                            else
                            {
                                if (World.Region[reg].OriginalFaction == defender)
                                {
                                    if (World.Region[reg].Type == RegionType.Capital)
                                        Notice.Show(
                                            "Great news!" + Environment.NewLine + Environment.NewLine +
                                            "Our brave troops sucessfully conquered " + World.Faction[defender].Name + "\'s Capital City, " + World.Region[reg].Name + "!" + Environment.NewLine + Environment.NewLine +
                                            "We should push harder while they are still weakened!",
                                            "Victory!", "Victory_Capital");
                                    else
                                        Notice.Show(
                                            "Our brave troops sucessfully conquered " + World.Region[reg].Name + " Region from the " + World.Faction[defender].Name + " faction!",
                                            "Victory!", "Victory");
                                }
                                else
                                {
                                    if (chkDeclineLiberations.Checked)
                                        Notice.Show(
                                            "Our brave troops sucessfully conquered the " + World.Region[reg].Name + " region from our enemies, the " + World.Faction[defender].Name + " faction!",
                                            "Victory!", "Victory");
                                    else
                                        if (Notice.Show(
                                            "Our brave troops sucessfully conquered the " + World.Region[reg].Name + " region from our enemies, the " + World.Faction[defender].Name + " faction!" + Environment.NewLine + Environment.NewLine +
                                            "Should we liberate it for " + World.Faction[World.Region[reg].OriginalFaction].Name + " and thus greatly improving ourWorld.relations?",
                                            "Victory!", "Victory") == DialogResult.Yes)
                                            LiberateRegion(Player, reg);
                                }
                            }
                        }
                        else
                            Notice.Show(
                                "Our troops were defeated in the battle of " + World.Region[reg].Name + " against the " + World.Faction[defender].Name + " faction!",
                                "Defeat!", "Defeat");

                        EndTurn();
                    }
                }
                else
                    Notice.Show(
                        "You cannot attack this region!",
                        "Invalid target!", "InvalidTarget");
            }
            else
                if (Notice.Show(
                "You cannot attack anyone this turn becouse you don't have enough troops (" + World.MinTroopsAttack + ")" + Environment.NewLine + Environment.NewLine +
                "Do you wish to end this turn now?",
                "Not enough Troops", "NotEnoughTroops") == DialogResult.Yes)
                    EndTurn();
        }
        private void AiAttack(int fct, bool _HomelandPriority)
        {
            Random rnd = new Random();
            int[] choice = new int[World.Region.Count];
            int choicesCount = 0;
            bool ok = false;

            for (int regPos = 0; regPos < World.Faction[fct].RegionCount; regPos++)
                for (int regNeighbour = 0; regNeighbour < World.Region.Count; regNeighbour++)
                {
                    bool valid = false;

                    if (World.Region[regNeighbour].Faction != 0)
                        if (World.Region[regNeighbour].Faction != fct)
                            if (World.border[World.Faction[fct].Region[regPos], regNeighbour])
                                if (World.relations[fct, World.Region[regNeighbour].Faction] <= 50)
                                    if (!World.Region[regNeighbour].IsProtected)
                                        if (_HomelandPriority)
                                        {
                                            if (World.Region[regNeighbour].OriginalFaction == fct)
                                                valid = true;
                                        }
                                        else
                                            valid = true;

                    if (valid)
                    {
                        choice[choicesCount] = regNeighbour;
                        choicesCount += 1;
                    }
                }

            int reg = choice[rnd.Next(0, choicesCount)];

            if (reg != 0)
            {
                int fctOld = World.Region[reg].Faction;
                bool won = AttackRegion(fct, reg);

                ok = true;
            }

            if (!ok && _HomelandPriority)
                AiAttack(fct, false);
        }
        private bool AttackRegion(int attacker, int reg)
        {
            Random rnd = new Random();
            int defender = World.Region[reg].Faction;
            int regionType = 0; //0 colony ;;; 1 core ;;; 2 capital

            if (World.Region[reg].OriginalFaction == defender)
            {
                regionType = 1;
                if (World.Region[reg].Type == RegionType.Capital)
                    regionType = 2;
            }

            //If it won
            World world = World;

            if(Battle.Start(ref world, attacker, defender, reg) == BattleResult.Won)
               {

                if (World.relations[attacker, defender] > 0)
                    World.relations[attacker, defender] = 0;

                switch (regionType)
                {
                    case 0:
                        ChangeRelationsBy(attacker, defender, -10);
                        break;
                    case 1:
                        ChangeRelationsBy(attacker, defender, -15);
                        break;
                    case 2:
                        ChangeRelationsBy(attacker, defender, -20);
                        break;
                }

                TransferRegion(reg, attacker);
                if (World.Faction[defender].Alive == false)
                    NoticeBoard.Add(World.Faction[defender].Name + " Faction was destroyed by " + World.Faction[attacker].Name,
                        World.Faction[defender].Name + " destroyed!", "FactionDestroyed");
                
                if (attacker != Player)
                {
                    int fctOriginal = World.Region[reg].OriginalFaction;

                    if (fctOriginal != attacker && fctOriginal != defender)
                        if (NarivianClass.ChancePercentage(Convert.ToInt32(Math.Ceiling((float)(World.relations[attacker, fctOriginal] / 25))) * 25))
                            LiberateRegion(attacker, reg);
                }

                if (defender == Player)
                    NoticeAiAttackedPlayer(attacker, reg, true);

                return true;
            }
            // If it lost
            else
            {
                if (World.relations[attacker, defender] > 0)
                    World.relations[attacker, defender] -= 10;

                switch (regionType)
                {
                    case 0:
                        ChangeRelationsBy(attacker, defender, -5);
                        break;
                    case 1:
                        ChangeRelationsBy(attacker, defender, -10);
                        break;
                    case 2:
                        ChangeRelationsBy(attacker, defender, -15);
                        break;
                }

                if (defender == Player)
                    NoticeAiAttackedPlayer(attacker, reg, false);

                return false;
            }
        }
        private void LiberateRegion(int fct, int reg)
        {
            int fctOriginal = World.Region[reg].OriginalFaction;
            int defender = World.Region[reg].Faction;

            TransferRegion(reg, fctOriginal);

            if (World.Faction[fctOriginal].Alive)
            {
                if (World.Region[reg].Type == RegionType.Capital)
                    ChangeRelationsBy(fct, fctOriginal, 60);
                else
                    ChangeRelationsBy(fct, fctOriginal, 30);
            }
            else
            {
                ChangeRelationsBy(fct, fctOriginal, 999);

                NoticeBoard.Add(
                    "The " + World.Faction[fctOriginal].Name + " faction was revived by " + World.Faction[fct].Name + " !" + Environment.NewLine + Environment.NewLine +
                    "They are now in " + NarivianClass.RelationsToString(World.relations[fct, fctOriginal]) + "World.relations with us!",
                    World.Faction[fctOriginal].Name + " revived!", "FactionRevived");
            }

            if (defender != Player && fctOriginal == Player)
                NoticeBoard.Add(
                    World.Region[reg].Name + " was returned to us by our friends, " + World.Faction[defender].Name + "!",
                    World.Region[reg].Name + " liberated!", "RegionLiberated");
        }
        private void TransferRegion(int reg, int fct)
        {
            int fctOld = World.Region[reg].Faction;

            World.Region[reg].Faction = fct;
            World.Region[reg].IsProtected = true;

            UpdateRegionList(fct);
            UpdateRegionList(fctOld);
        }
        private void NoticeAiAttackedPlayer(int fct, int reg, bool won)
        {
            if (won)
            {
                if (World.Region[reg].OriginalFaction == Player)
                    if (World.Region[reg].Type == RegionType.Capital)
                        Notice.Show(
                            "Terrible news!" + Environment.NewLine + Environment.NewLine +
                            "Our capital, " + World.Region[reg].Name + ", was conquered by the cunning " + World.Faction[fct].Name + " faction!" + Environment.NewLine + Environment.NewLine +
                            "It is a huge hit for our faction, we must liberate it as soon as possible!" + Environment.NewLine + Environment.NewLine +
                            "It's resource was: " + World.Resource[World.Region[reg].Resource].Name,
                            "Capital lost!", "CapitalLost");
                    else
                        NoticeBoard.Add(
                            "Bad news!" + Environment.NewLine + Environment.NewLine +
                            "One of our homeland regions, " + World.Region[reg].Name + ", was conquered by the " + World.Faction[fct].Name + " faction!" + Environment.NewLine + Environment.NewLine +
                            "It's resource was: " + World.Resource[World.Region[reg].Resource].Name,
                           World.Region[reg].Name + " region lost!", "RegionLost");
                else
                    if (World.Region[reg].State == RegionState.Free)
                        NoticeBoard.Add(
                            "Our colony region of " + World.Region[reg].Name + " was liberated by it's original rulers, the " + World.Faction[fct].Name + " faction!" + Environment.NewLine + Environment.NewLine +
                            "It's resource was: " + World.Resource[World.Region[reg].Resource].Name,
                           World.Region[reg].Name + " region lost!", "RegionLost");
                    else
                        NoticeBoard.Add(
                            "Our colony region of " + World.Region[reg].Name + " was conquered by one of our enemies, the " + World.Faction[fct].Name + " faction!" + Environment.NewLine + Environment.NewLine +
                            "It's resource was: " + World.Resource[World.Region[reg].Resource].Name,
                           World.Region[reg].Name + " region lost!", "RegionLost");
            }
            else
                NoticeBoard.Add(
                   World.Region[reg].Name + " Region was attacked by " + World.Faction[fct].Name + " but our brave troops sucessfully defended it!",
                   World.Region[reg].Name + " Region defended!", "Victory");
        }
        #endregion
        #region Relations
        private void ChangeRelationsBy(int fct1, int fct2, int val)
        {
            int oldRelations = World.relations[fct1, fct2];
            World.relations[fct1, fct2] = Math.Max(-100, Math.Min(World.relations[fct1, fct2] + val, 100));
            World.relations[fct2, fct1] = World.relations[fct1, fct2];

            if (fct1 == Player || fct2 == Player)
            {
                int fctOther;

                if (fct1 == Player) fctOther = fct2;
                else fctOther = fct1;

                if (NarivianClass.RelationsToString(oldRelations) != NarivianClass.RelationsToString(World.relations[fct1, fct2]))
                    relationsChanged += World.Faction[fctOther].Name + ": " + NarivianClass.RelationsToString(oldRelations) + " -> " + NarivianClass.RelationsToString(World.relations[fct1, fct2]) + Environment.NewLine;
            }
        }
        #endregion
        #region Buildings
        private void AiBuild(int fct, bool homelandBuildPriority = true)
        {
            bool freeSlots = false;

            for (int bldSlot = 1; bldSlot < World.Region[World.Faction[fct].Region[0]].Building.Length; bldSlot++)
                for (int regSlot = 0; regSlot < World.Faction[fct].RegionCount; regSlot++)
                {
                    int reg = World.Faction[fct].Region[regSlot];

                    if ((World.Region[reg].State == RegionState.Free) == homelandBuildPriority)
                        if (World.Region[reg].Building[bldSlot] == 0)
                            for (int bld = 1; bld < World.Building.Count; bld++)
                                if (World.Building[bld].RequiredResource == 0 || World.Building[bld].RequiredResource == World.Region[reg].Resource)
                                //if (World.Building[bld].RequiredReligion == 0 || World.Building[bld].RequiredReligion == World.Faction[fct].Religion)
                                {
                                    bool built = false;
                                    bool builtNow = false;

                                    if (World.Building[bld].Price - World.Building[bld].Maintenance < World.Faction[fct].Money)
                                        if (World.Faction[fct].Income + World.Building[bld].Income >= World.Faction[fct].Outcome + World.Building[bld].Maintenance)
                                        {
                                            bool owned = false;

                                            for (int bldSlot2 = 1; bldSlot2 < World.Region[reg].Building.Length; bldSlot2++)
                                                if (World.Region[reg].Building[bldSlot2] == bld)
                                                {
                                                    owned = true;
                                                    built = true;
                                                    builtNow = false;
                                                    break;
                                                }

                                            if (!owned)
                                            {
                                                BuildBuilding(reg, bld);
                                                built = true;
                                                builtNow = true;
                                            }
                                        }
                                    if (!built)
                                        freeSlots = true;
                                    if (builtNow)
                                        break;
                                }
                }

            if (homelandBuildPriority && !freeSlots)
                AiBuild(fct, false);
        }
        private void AiDemolish(int fct)
        {
            for (int regPos = 0; regPos < World.Faction[fct].RegionCount; regPos++)
            {
                int reg = World.Faction[fct].Region[regPos];

                for (int bldPos = 0; bldPos < World.Region[reg].BuildingsCount; bldPos++)
                {
                    int bld = World.Region[reg].Building[bldPos];

                    //if (World.Building[bld].RequiredReligion != 0)
                    //    if (World.Building[bld].RequiredReligion != World.Faction[fct].Religion)
                    //        DemolishBuilding(reg, bld);
                }
            }
        }
        private void AddBuilding(int reg, int bld)
        {
            World.Region[reg].Building[World.Region[reg].BuildingsCount] = bld;
            World.Region[reg].BuildingCulture[World.Region[reg].BuildingsCount] = World.Faction[World.Region[reg].Faction].Culture;
            World.Region[reg].BuildingsCount += 1;

            World.Faction[World.Region[reg].Faction].Income += World.Building[bld].Income;
            World.Faction[World.Region[reg].Faction].Outcome += World.Building[bld].Maintenance;

            if (World.Region[reg].Faction == Player)
            {
                buildingsReport += World.Region[reg].Name + ": " + World.Building[bld].Name + Environment.NewLine;
                UpdateInfoBar();
            }
        }
        public void RemoveBuilding(int reg, int bld)
        {
            for (int i = 1; i < World.Region[reg].BuildingsCount; i++)
                if (World.Region[reg].Building[i] == bld)
                {
                    for (int j = i; j < World.Region[reg].Building.Length - 1; j++)
                    {
                        World.Region[reg].Building[j] = World.Region[reg].Building[j + 1];
                        World.Region[reg].BuildingCulture[j] = World.Region[reg].BuildingCulture[j + 1];
                    }

                    World.Region[reg].Building[World.Region[reg].BuildingsCount] = 0;
                    World.Region[reg].BuildingCulture[World.Region[reg].BuildingsCount] = 0;
                }

            World.Faction[World.Region[reg].Faction].Income -= World.Building[bld].Income;
            World.Faction[World.Region[reg].Faction].Outcome -= World.Building[bld].Maintenance;

            World.Region[reg].BuildingsCount -= 1;

            if (World.Region[reg].Faction == Player)
                UpdateInfoBar();
        }
        public void BuildBuilding(int reg, int bld)
        {
            AddBuilding(reg, bld);
            World.Faction[World.Region[reg].Faction].Money -= World.Building[bld].Price;
        }
        public void DemolishBuilding(int reg, int bld)
        {
            RemoveBuilding(reg, bld);
            World.Faction[World.Region[reg].Faction].Money += World.Building[bld].Price * 0.6;
        }
        #endregion
        #region Recruitings
        private void AiRecruit(int fct)
        {
            int minPrice = World.Unit[1].Price;

            for (int unt = 2; unt < World.Unit.Count; unt++)
                if (World.Unit[unt].Price < minPrice)
                    minPrice = World.Unit[unt].Price;

            while(World.Faction[fct].Money >= minPrice)
            {
                Random rnd = new Random();
                int unt = rnd.Next(1, World.Unit.Count);

                if (World.Unit[unt].Price <= World.Faction[fct].Money)
                    RecruitUnit(fct, unt, 1);
            }
        }
        public void RecruitUnit(int fct, int unt, int ammount)
        {
            World.Faction[fct].Units[unt] += ammount;
            World.Faction[fct].Money -= World.Unit[unt].Price * ammount;
        }
        #endregion
        #region Religion
        private void AiSpreadReligion(int fct)
        {
            for (int regPos = 0; regPos < World.Faction[fct].RegionCount; regPos++)
            {
                int relInfluence = 0;

                int reg = World.Faction[fct].Region[regPos];

                for (int bldPos = 0; bldPos < World.Region[reg].BuildingsCount; bldPos++)
                {
                    int bld = World.Region[reg].Building[bldPos];

                    relInfluence += World.Building[bld].ReligionInfluence;

                    World.Region[reg].Religion[World.Faction[fct].Religion] += (25 * relInfluence) / 100;
                    relInfluence -= (25 * relInfluence) / 100;

                    while (relInfluence > 0)
                        for (int reg2 = 0; reg2 < World.Region.Count; reg2++)
                            if (World.border[reg, reg2])
                            {
                                World.Region[reg2].AddReligion(World.Faction[fct].Religion, 1);
                                relInfluence -= 1;
                            }
                }
            }
        }
        #endregion
        #endregion

        #region Buttons
        private void btnTurnReport_Click(object sender, EventArgs e)
        {
            if (Turn > 0)
                Notice.Show(
                    "Troops: " + World.Faction[Player].Units[0] + Environment.NewLine +
                    "Regions: " + World.Faction[Player].RegionCount + Environment.NewLine +
                    "Money: " + World.Faction[Player].Money + " (+" + (World.Faction[Player].Income - World.Faction[Player].Outcome) + " per turn)" + Environment.NewLine +
                    "Combat Bonus: Atk: " + World.GetAttackBonus(Player) + " Def: " + World.GetDefenceBonus(Player) + Environment.NewLine +
                    "Recruitment Bonus: " + World.GetRecruitmentBonus(Player),
                    "Turn Report", "TurnReport");
            else
                Notice.Show(
                    "Nothing to report, this is the first turn in this game!",
                    "Turn Report", "TurnReport");
        }
        private void btnRelations_Click(object sender, EventArgs e)
        {
            string body = "";

            for (int i = 1; i < World.Faction.Count; i++)
                if (i != Player)
                    if (NarivianClass.RelationsToString(World.relations[i, Player]) != "Neutral")
                        body += World.Faction[i].Name + ": " + NarivianClass.RelationsToString(World.relations[i, Player]) + Environment.NewLine;

            Notice.Show(body, "Relations", "Relations");
        }
        private void btnEconomy_Click(object sender, EventArgs e)
        {
            Notice.Show(
                "Base regions income: +" + World.GetBaseRegionsIncome(Player) + Environment.NewLine +
                "Buildings income: +" + World.GetBuildingsIncome(Player) + Environment.NewLine +
                "Buildings maintenance: -" + World.GetBuildingsMaintenance(Player) + Environment.NewLine +
                "Units maintenance: -" + World.GetUnitsMaintenance(Player) + Environment.NewLine + Environment.NewLine +
                "Total income: " + (World.Faction[Player].Income - World.Faction[Player].Outcome),
                "Economy", "Economy");
        }
        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            string ssName =(Options.PlayerName + "_" + DateTime.Now.ToString("yy.MM.dd_HH.mm") + "_" + MapName + "_" + World.Faction[Player].Name + "_Turn" + Turn).Replace(" ", "");
            
            if (Directory.Exists("Screenshots\\") == false)
                Directory.CreateDirectory("Screenshots\\");

            Map.BackgroundImage.Save("Screenshots\\" + ssName + ".PNG");
            NoticeBoard.Add("Screenshot saved as '" + ssName + ".PNG'!","Screenshot saved", "Screenshot");
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            ShowMenu();
        }
        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            EndTurn();
        }
        private void btnRecruit_Click(object sender, EventArgs e)
        {
            (new frmRecruit(this)).ShowDialog();
            UpdateInfoBar();
        }
        private void btnBuild_Click(object sender, EventArgs e)
        {
            (new frmBuild(this)).ShowDialog();
            UpdateInfoBar();
        }
        #endregion

        #region Others
        private string SuccessRate(int fctAttacker, int fctDefender)
        {
            int armyAttacker = World.GetAttackPower(fctAttacker);
            int armyDefender = World.GetDefencePower(fctDefender);

            return Math.Min(Math.Round(NarivianClass.NumToPercent(armyAttacker * World.AttackerBonus.Total, armyDefender * World.DefenderBonus.Total)), 100) + "%";
        }
        private void ShowMenu()
        {
            frmMenu frmMenu = new frmMenu(this);
            frmMenu.ShowDialog();
        }
        #region Buildings
        public void UpdateRegionInfo(int reg)
        {
            if (World.Region[reg].Faction != 0 && (World.Region[reg].Faction == Player ||
            (World.Region[reg].Faction != Player && World.HasBorder(Player, reg))))
            {
                RegionBar.GetRegion(reg);
                BuildingsPanel.GetRegion(reg);
                selectedRegion = reg;
            }
            else
            {
                RegionBar.GetRegion(0);
                BuildingsPanel.Clear();
                selectedRegion = 0;
            }

            if(World.Region[reg].Faction == Player)
            {
                btnBuild.Enabled = true;
                btnRecruit.Enabled = true;
            }
            else
            {
                btnBuild.Enabled = false;
                btnRecruit.Enabled = false;
            }
        }
        public string GetBuildingDetails(int bld)
        {
            string body = World.Building[bld].Description + Environment.NewLine + Environment.NewLine;

            if (bld != 0)
            {
                body += "Maintenance: " + World.Building[bld].Maintenance;

                if (World.Building[bld].Income != 0)
                    body += Environment.NewLine + "Income: " + World.Building[bld].Income;
                if (World.Building[bld].AttackBonus != 0)
                    body += Environment.NewLine + "Attack Bonus: " + World.Building[bld].AttackBonus;
                if (World.Building[bld].DefenceBonus != 0)
                    body += Environment.NewLine + "Defence Bonus: " + World.Building[bld].DefenceBonus;
                if (World.Building[bld].RecruitmentBonus != 0)
                    body += Environment.NewLine + "Recruitment Bonus: " + World.Building[bld].RecruitmentBonus;
                if (World.Building[bld].ReligionInfluence != 0)
                    body += Environment.NewLine + "Religion Influence: " + World.Building[bld].ReligionInfluence;
            }
            else
            {
                if (World.Region[selectedRegion].Type == RegionType.Capital)
                    body += "Income: " + World.BaseRegionIncome * 2;
                else
                    body += "Income: " + World.BaseRegionIncome;
            }

            return body;
        }
        public int GetBuildingByName(string bldName)
        {
            for (int bld = 1; bld < World.Building.Count; bld++)
                if (World.Building[bld].Name == bldName)
                    return bld;

            return 0;
        }
        #endregion
        #endregion

        #region Debugging thingies
        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Oemtilde)
            {
                if (Console.Enabled)
                {
                    Console.Enabled = false;
                    Console.Visible = false;
                    Console.Text = "";
                }
                else
                {
                    Console.Enabled = true;
                    Console.Visible = true;
                    Console.Text = "";
                    Console.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
                ShowMenu();
        }
        private void Console_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                string aux = Console.Text;
                Console.Text = undo;
                undo = aux;
                Console.Select(Console.Text.Length, 0);
            }
        }
        private void Console_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                string[] cmd = Console.Text.ToLower().Split(' ');

                try
                {
                    switch (cmd[0])
                    {
                        case "noticeboard":
                            switch (cmd[1])
                            {
                                case "clear":
                                    NoticeBoard.Clear();
                                    break;
                                case "add":
                                    string msg = "";
                                    for (int i = 2; i < cmd.Length - 2; i++)
                                        msg += cmd[i] + " ";
                                    NoticeBoard.Add(msg, cmd[cmd.Length - 2], cmd[cmd.Length - 1]);
                                    break;
                                default:
                                    ConsoleError();
                                    break;
                            }
                            break;
                        case "relations":
                            switch (cmd[1])
                            {
                                case "get":
                                    MessageBox.Show("Relations between " + World.Faction[Convert.ToInt32(cmd[2])].Name + " and " + World.Faction[Convert.ToInt32(cmd[3])].Name + " are " + World.relations[Convert.ToInt32(cmd[2]), Convert.ToInt32(cmd[3])] + " (" + NarivianClass.RelationsToString(World.relations[Convert.ToInt32(cmd[2]), Convert.ToInt32(cmd[3])]) + ")");
                                    break;
                                case "set":
                                    ChangeRelationsBy(Convert.ToInt32(cmd[2]), Convert.ToInt32(cmd[3]), 0 - World.relations[Convert.ToInt32(cmd[2]), Convert.ToInt32(cmd[3])] + Convert.ToInt32(cmd[4]));
                                    MessageBox.Show("Relations between " + World.Faction[Convert.ToInt32(cmd[2])].Name + " and " + World.Faction[Convert.ToInt32(cmd[3])].Name + " have been set to " + World.relations[Convert.ToInt32(cmd[2]), Convert.ToInt32(cmd[3])] + " (" + NarivianClass.RelationsToString(World.relations[Convert.ToInt32(cmd[2]), Convert.ToInt32(cmd[3])]) + ")");
                                    break;
                                default:
                                    ConsoleError();
                                    break;
                            }
                            break;
                        case "region":
                            switch (cmd[1])
                            {
                                case "transfer":
                                    TransferRegion(Convert.ToInt32(cmd[2]), Convert.ToInt32(cmd[3]));
                                    MessageBox.Show(World.Region[Convert.ToInt32(cmd[2])].Name + " region has been transfered to " + World.Faction[Convert.ToInt32(cmd[3])].Name);
            
                                    World.DrawMap(Map);

                                    if (Convert.ToInt32(cmd[3]) == Player)
                                        UpdateInfoBar();
                                    break;
                                case "addbuilding":
                                    AddBuilding(Convert.ToInt32(cmd[2]), Convert.ToInt32(cmd[3]));
                                    MessageBox.Show(World.Building[Convert.ToInt32(cmd[3])].Name + " World.building has been added to " + World.Region[Convert.ToInt32(cmd[2])].Name);
                                    BuildingsPanel.GetRegion(Convert.ToInt32(cmd[2]));
                                    break;
                                case "removebuilding":
                                    RemoveBuilding(Convert.ToInt32(cmd[2]), Convert.ToInt32(cmd[3]));
                                    MessageBox.Show(World.Building[Convert.ToInt32(cmd[3])].Name + " World.building has been removed from " + World.Region[Convert.ToInt32(cmd[2])].Name);
                                    BuildingsPanel.GetRegion(Convert.ToInt32(cmd[2]));
                                    break;
                                default:
                                    ConsoleError();
                                    break;
                            }
                            break;
                        case "faction":
                            switch (cmd[1])
                            {
                                case "troops":
                                    switch (cmd[2])
                                    {
                                        case "get":
                                            MessageBox.Show(World.Faction[Convert.ToInt32(cmd[3])].Name + " factionhas " + World.Faction[Convert.ToInt32(cmd[3])].Units[0] + " troops");
                                            break;
                                        case "set":
                                            World.Faction[Convert.ToInt32(cmd[3])].Units[0] = Convert.ToInt32(cmd[4]);
                                            MessageBox.Show(World.Faction[Convert.ToInt32(cmd[3])].Name + " factionnow have " + World.Faction[Convert.ToInt32(cmd[3])].Units[0] + " troops");
                                            if (Convert.ToInt32(cmd[3]) == Player)
                                                UpdateInfoBar();
                                            break;
                                        default:
                                            ConsoleError();
                                            break;
                                    }
                                    break;
                                case "money":
                                    switch (cmd[2])
                                    {
                                        case "get":
                                            MessageBox.Show(World.Faction[Convert.ToInt32(cmd[3])].Name + " factionhas " + World.Faction[Convert.ToInt32(cmd[3])].Money + " gold");
                                            break;
                                        case "set":
                                            World.Faction[Convert.ToInt32(cmd[3])].Money = Convert.ToInt32(cmd[4]);
                                            MessageBox.Show(World.Faction[Convert.ToInt32(cmd[3])].Name + " factionnow have " + World.Faction[Convert.ToInt32(cmd[3])].Money + " gold");
                                            if (Convert.ToInt32(cmd[3]) == Player)
                                                UpdateInfoBar();
                                            break;
                                        default:
                                            ConsoleError();
                                            break;
                                    }
                                    break;
                                case "control":
                                    //PlayerTakeControl(Convert.ToInt32(cmd[2]));
                                    Player = Convert.ToInt32(cmd[2]);
                                    MessageBox.Show("The Player is now " + World.Faction[Player].Name);
                                    break;
                            }
                            break;
                        case "sasa":
                            MessageBox.Show("sasa to you too!");
                            break;
                        default:
                            ConsoleError();
                            break;
                    }
                }
                catch
                {
                    ConsoleError();
                }

                undo = Console.Text;
                Console.Text = "";
            }
        }
        private void ConsoleError()
        {
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}