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

namespace Narivia
{
    public partial class frmEditor : CustomForm
    {
        World world;
        #region Other Variables
        bool isRunning = false;
        public int selRegion;
        public int selFaction;
        public int selAbility;
        public int selCulture;
        public int selReligion;
        public int selBiome;
        #endregion

        #region Form Open & Close
        public frmEditor()
        {
            InitializeComponent();

            lblMapName.Text = "";

            Panel.BackgroundImage = Properties.Resources.Stone_Bricks;
            this.pnlMap.BackgroundImage = Properties.Resources.Stone_Bricks;
            
            NoticeBoard.Height = 0;
            NoticeBoard.MaximumSize = new Size(65, pnlMap.Height);

            this.Cursor = CustomCursor.Load("Default.CUR");
            Map.Cursor = CustomCursor.Load("Default.CUR");

            LoadMapList();
        }
        public void NewMap(string map)
        {
            world = new World();
            world.Load(map);
            LoadFactionList();
            LoadBiomeList();
            LoadResourceList();
            LoadAbilityList();
            LoadCultureList();
            LoadReligionList();

            world.DrawMap(Map);

            lblMapName.Text = map;

            UpdateSelection(0);

            isRunning = true;
        }
        private void frmGame_Resize(object sender, EventArgs e)
        {
            if (Map.Size.Width < pnlMap.Size.Width)
                Map.Location = new Point((pnlMap.Size.Width - SystemInformation.VerticalScrollBarWidth - Map.Size.Width) / 2, Map.Location.Y);
            if (Map.Size.Height < pnlMap.Size.Height)
                Map.Location = new Point(Map.Location.X, (pnlMap.Size.Height - Map.Size.Height) / 2);
        }
        private void LoadMapList()
        {
            int i;

            DirectoryInfo dInfo = new DirectoryInfo(NarivianClass.MapsDirectory);
            DirectoryInfo[] maps = dInfo.GetDirectories();

            cmbMap.Items.Clear();
            for (i = 0; i < maps.Length; i++)
                cmbMap.Items.Add(maps[i].Name);

            cmbMap.SelectedIndex = 0;
        }
        private void LoadFactionList()
        {
            cmbFaction.Items.Clear();

            for (int fct = 0; fct < world.Faction.Count; fct++)
                cmbFaction.Items.Add(world.Faction[fct].Name);
        }
        private void LoadBiomeList()
        {
            cmbBiome.Items.Clear();

            for (int bio = 0; bio < world.Biome.Count; bio++)
                cmbBiome.Items.Add(world.Biome[bio].Name);
        }
        private void LoadResourceList()
        {
            cmbResource.Items.Clear();

            for (int res = 0; res < world.Resource.Count; res++)
                cmbResource.Items.Add(world.Resource[res].Name);
        }
        private void LoadAbilityList()
        {
            cmbAbility.Items.Clear();

            for (int abl = 0; abl < world.Ability.Count; abl++)
                cmbAbility.Items.Add(world.Ability[abl].Name);
        }
        private void LoadCultureList()
        {
            cmbCulture.Items.Clear();

            for (int clt = 0; clt < world.Culture.Count; clt++)
                cmbCulture.Items.Add(world.Culture[clt].Name);
        }
        private void LoadReligionList()
        {
            cmbReligion.Items.Clear();

            for (int rel = 0; rel < world.Religion.Count; rel++)
                cmbReligion.Items.Add(world.Religion[rel].Name);
        }
        #endregion

        #region Mouse Events & Cursor
        private void Map_MouseDown(object sender, MouseEventArgs e)
        {
            if (isRunning)
            {
                Map.Cursor = CustomCursor.Load("Default_Pressed.CUR");

                UpdateSelection(world.world[e.X, e.Y]);

                UpdateRegionInfo(selRegion);
                UpdateFactionInfo(selFaction);
            }
        }
        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            if(world != null)
                if (e.X >= 0 && e.X < world.Width && e.Y >= 0 && e.Y < world.Height)
                    if(e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
                        if (world.world[e.X, e.Y] != selRegion)
                            Map_MouseDown(sender, e);
        }
        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            Map.Cursor = CustomCursor.Load("Default.CUR");
        }
        #endregion

        #region Buttons
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbMap.Text != "")
                if (MessageBox.Show( "Are you sure you want to load '" + cmbMap.Text + "' map?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NewMap(cmbMap.Text);
                    NoticeBoard.Clear();

                    grpRegion.Enabled = true;
                    grpAbility.Enabled = true;
                    grpFaction.Enabled = true;
                    grpReligion.Enabled = true;
                    btnSave.Enabled = true;
                }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isRunning)
                world.Save();
            else
                MessageBox.Show("Cannot save map because none is loaded",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Changes
        #region Gets
        private void UpdateSelection(int reg)
        {
            selRegion = reg;
            selFaction = world.Region[selRegion].Faction;
            selAbility = world.Faction[selFaction].Ability;
            selReligion = world.Faction[selFaction].Religion;

            UpdateRegionInfo(selRegion);
            UpdateFactionInfo(selFaction);
            UpdateAbilityInfo(selAbility);
            UpdateReligionInfo(selReligion);
        }
        private void UpdateRegionInfo(int reg)
        {
            txtRegionName.Text = world.Region[reg].Name;
            cmbFaction.SelectedIndex = world.Region[reg].Faction;
            cmbBiome.SelectedIndex = world.Region[reg].Biome;
            cmbResource.SelectedIndex = world.Region[reg].Resource;
        }
        private void UpdateFactionInfo(int fct)
        {
            txtFactionName.Text = world.Faction[fct].Name;
            cmbAbility.SelectedIndex = world.Faction[fct].Ability;
            cmbCulture.SelectedIndex = world.Faction[fct].Culture;
            cmbReligion.SelectedIndex = world.Faction[fct].Religion;
            txtFactionDescription.Text = world.Faction[fct].Description;
        }
        private void UpdateAbilityInfo(int abl)
        {
            txtAbilityName.Text = world.Ability[abl].Name;
            numIncomeBonus.Value = world.Ability[abl].IncomeBonus;
            numOutcomeBonus.Value = world.Ability[abl].OutcomeBonus;
            numAttackBonus.Value = world.Ability[abl].AttackBonus;
            numDefenceBonus.Value = world.Ability[abl].DefenceBonus;
            numRecruitmentBonus.Value = world.Ability[abl].RecruitmentBonus;
        }
        private void UpdateReligionInfo(int rel)
        {
            txtReligionName.Text = world.Religion[rel].Name;
            txtReligionDescription.Text = world.Religion[rel].Description;
        }
        #endregion
        #region Sets
        #region Regions
        private void txtRegionName_TextChanged(object sender, EventArgs e)
        {
            world.Region[selRegion].Name = txtRegionName.Text;
        }
        private void cmbFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (world.Region[selRegion].Faction != cmbFaction.SelectedIndex)
            {
                world.Region[selRegion].Faction = cmbFaction.SelectedIndex;
                world.DrawMap(Map);
            }
        }
        private void cmbBiome_SelectedIndexChanged(object sender, EventArgs e)
        {
            world.Region[selRegion].Biome = cmbBiome.SelectedIndex;
        }
        private void cmbResource_SelectedIndexChanged(object sender, EventArgs e)
        {
            world.Region[selRegion].Resource = cmbResource.SelectedIndex;
        }
        #endregion
        #region Factions
        private void txtFactionName_TextChanged(object sender, EventArgs e)
        {
            world.Faction[selFaction].Name = txtFactionName.Text;
            cmbFaction.Items[selFaction] = world.Faction[selFaction].Name;
        }
        private void cmbAbility_SelectedIndexChanged(object sender, EventArgs e)
        {
            world.Faction[selFaction].Ability = cmbAbility.SelectedIndex;
            UpdateAbilityInfo(cmbAbility.SelectedIndex);
        }
        private void cmbCulture_SelectedIndexChanged(object sender, EventArgs e)
        {
            world.Faction[selFaction].Culture = cmbCulture.SelectedIndex;
        }
        private void cmbReligion_SelectedIndexChanged(object sender, EventArgs e)
        {
            selReligion = cmbReligion.SelectedIndex;
            world.Faction[selFaction].Religion = selReligion;
            txtReligionName.Text = world.Religion[selReligion].Name;
            txtReligionDescription.Text = world.Religion[selReligion].Description;
        }
        private void txtFactionDescription_TextChanged(object sender, EventArgs e)
        {
            world.Faction[selFaction].Description = txtFactionDescription.Text;
        }
        #endregion
        #region Abilities
        private void txtAbilityName_TextChanged(object sender, EventArgs e)
        {
            world.Ability[selAbility].Name = txtAbilityName.Text;
            cmbAbility.Items[cmbAbility.SelectedIndex] = txtAbilityName.Text;
        }
        private void numIncomeBonus_ValueChanged(object sender, EventArgs e)
        {
            world.Ability[selAbility].IncomeBonus = (int)numIncomeBonus.Value;
        }
        private void numOutcomeBonus_ValueChanged(object sender, EventArgs e)
        {
            world.Ability[selAbility].OutcomeBonus = (int)numOutcomeBonus.Value;
        }
        private void numAttackBonus_ValueChanged(object sender, EventArgs e)
        {
            world.Ability[selAbility].AttackBonus = (int)numAttackBonus.Value;
        }
        private void numDefenceBonus_ValueChanged(object sender, EventArgs e)
        {
            world.Ability[selAbility].DefenceBonus = (int)numDefenceBonus.Value;
        }
        private void numRecruitmentBonus_ValueChanged(object sender, EventArgs e)
        {
            world.Ability[selAbility].RecruitmentBonus = (int)numRecruitmentBonus.Value;
        }
        #endregion
        #region Religion
        private void txtReligionName_TextChanged(object sender, EventArgs e)
        {
            world.Religion[selReligion].Name = txtReligionName.Text;
            cmbReligion.Items[selReligion] = world.Religion[selReligion].Name;
        }
        private void txtReligionDescription_TextChanged(object sender, EventArgs e)
        {
            world.Religion[selReligion].Description = txtReligionDescription.Text;
        }
        #endregion
        #endregion
        #endregion
    }
}