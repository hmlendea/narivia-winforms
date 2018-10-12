namespace Narivia
{
    partial class frmEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            this.Map = new System.Windows.Forms.PictureBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.grpReligion = new Narivia.CustomGroupBox();
            this.txtReligionDescription = new System.Windows.Forms.TextBox();
            this.lblReligionDescription = new Narivia.CustomLabel();
            this.lblReligionName = new Narivia.CustomLabel();
            this.txtReligionName = new System.Windows.Forms.TextBox();
            this.grpAbility = new Narivia.CustomGroupBox();
            this.lblRecruitmentBonus = new Narivia.CustomLabel();
            this.lblDefenceBonus = new Narivia.CustomLabel();
            this.lblAttackBonus = new Narivia.CustomLabel();
            this.lblOutcomeBonus = new Narivia.CustomLabel();
            this.lblIncomeBonus = new Narivia.CustomLabel();
            this.numRecruitmentBonus = new System.Windows.Forms.NumericUpDown();
            this.numDefenceBonus = new System.Windows.Forms.NumericUpDown();
            this.numAttackBonus = new System.Windows.Forms.NumericUpDown();
            this.numOutcomeBonus = new System.Windows.Forms.NumericUpDown();
            this.numIncomeBonus = new System.Windows.Forms.NumericUpDown();
            this.txtAbilityName = new System.Windows.Forms.TextBox();
            this.lblAbilityName = new Narivia.CustomLabel();
            this.grpFaction = new Narivia.CustomGroupBox();
            this.lblReligion = new Narivia.CustomLabel();
            this.cmbReligion = new Narivia.CustomComboBox();
            this.lblFactionDescription = new Narivia.CustomLabel();
            this.txtFactionDescription = new System.Windows.Forms.TextBox();
            this.lblCulture = new Narivia.CustomLabel();
            this.lblAbility = new Narivia.CustomLabel();
            this.cmbCulture = new Narivia.CustomComboBox();
            this.cmbAbility = new Narivia.CustomComboBox();
            this.txtFactionName = new System.Windows.Forms.TextBox();
            this.lblFactionName = new Narivia.CustomLabel();
            this.grpRegion = new Narivia.CustomGroupBox();
            this.lblFaction = new Narivia.CustomLabel();
            this.cmbFaction = new Narivia.CustomComboBox();
            this.lblBiome = new Narivia.CustomLabel();
            this.cmbBiome = new Narivia.CustomComboBox();
            this.lblResource = new Narivia.CustomLabel();
            this.cmbResource = new Narivia.CustomComboBox();
            this.txtRegionName = new System.Windows.Forms.TextBox();
            this.lblRegionName = new Narivia.CustomLabel();
            this.btnSave = new Narivia.CustomButton();
            this.grpLoadMap = new Narivia.CustomGroupBox();
            this.btnLoad = new Narivia.CustomButton();
            this.cmbMap = new Narivia.CustomComboBox();
            this.lblMapName = new Narivia.CustomLabel();
            this.separatorV1 = new Narivia.CustomPanel();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.NoticeBoard = new Narivia.NoticeBoard();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            this.Panel.SuspendLayout();
            this.grpReligion.SuspendLayout();
            this.grpAbility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecruitmentBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefenceBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutcomeBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncomeBonus)).BeginInit();
            this.grpFaction.SuspendLayout();
            this.grpRegion.SuspendLayout();
            this.grpLoadMap.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(640, 640);
            this.Map.TabIndex = 0;
            this.Map.TabStop = false;
            this.Map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Map_MouseDown);
            this.Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Map_MouseMove);
            this.Map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Map_MouseUp);
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.grpReligion);
            this.Panel.Controls.Add(this.grpAbility);
            this.Panel.Controls.Add(this.grpFaction);
            this.Panel.Controls.Add(this.grpRegion);
            this.Panel.Controls.Add(this.btnSave);
            this.Panel.Controls.Add(this.grpLoadMap);
            this.Panel.Controls.Add(this.lblMapName);
            this.Panel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.Panel.ForeColor = System.Drawing.Color.Gold;
            this.Panel.Location = new System.Drawing.Point(669, 36);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(599, 601);
            this.Panel.TabIndex = 12;
            // 
            // grpReligion
            // 
            this.grpReligion.BackColor = System.Drawing.Color.Transparent;
            this.grpReligion.BorderColor = System.Drawing.Color.DarkRed;
            this.grpReligion.Controls.Add(this.txtReligionDescription);
            this.grpReligion.Controls.Add(this.lblReligionDescription);
            this.grpReligion.Controls.Add(this.lblReligionName);
            this.grpReligion.Controls.Add(this.txtReligionName);
            this.grpReligion.Enabled = false;
            this.grpReligion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpReligion.ForeColor = System.Drawing.Color.Gold;
            this.grpReligion.Location = new System.Drawing.Point(303, 387);
            this.grpReligion.Name = "grpReligion";
            this.grpReligion.ShadowColor = System.Drawing.Color.Black;
            this.grpReligion.Size = new System.Drawing.Size(287, 149);
            this.grpReligion.TabIndex = 9;
            this.grpReligion.TabStop = false;
            this.grpReligion.Text = "Religion";
            this.grpReligion.TextPosition = Narivia.CustomGroupBoxTextPosition.Left;
            // 
            // txtReligionDescription
            // 
            this.txtReligionDescription.BackColor = System.Drawing.Color.DarkRed;
            this.txtReligionDescription.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtReligionDescription.ForeColor = System.Drawing.Color.Gold;
            this.txtReligionDescription.Location = new System.Drawing.Point(5, 73);
            this.txtReligionDescription.Multiline = true;
            this.txtReligionDescription.Name = "txtReligionDescription";
            this.txtReligionDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReligionDescription.Size = new System.Drawing.Size(276, 70);
            this.txtReligionDescription.TabIndex = 25;
            this.txtReligionDescription.TextChanged += new System.EventHandler(this.txtReligionDescription_TextChanged);
            // 
            // lblReligionDescription
            // 
            this.lblReligionDescription.AutoSize = true;
            this.lblReligionDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblReligionDescription.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReligionDescription.ForeColor = System.Drawing.Color.Gold;
            this.lblReligionDescription.Location = new System.Drawing.Point(102, 52);
            this.lblReligionDescription.Name = "lblReligionDescription";
            this.lblReligionDescription.ShadowColor = System.Drawing.Color.Black;
            this.lblReligionDescription.Size = new System.Drawing.Size(83, 18);
            this.lblReligionDescription.TabIndex = 30;
            this.lblReligionDescription.Text = "Description:";
            // 
            // lblReligionName
            // 
            this.lblReligionName.AutoSize = true;
            this.lblReligionName.BackColor = System.Drawing.Color.Transparent;
            this.lblReligionName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReligionName.ForeColor = System.Drawing.Color.Gold;
            this.lblReligionName.Location = new System.Drawing.Point(5, 27);
            this.lblReligionName.Name = "lblReligionName";
            this.lblReligionName.ShadowColor = System.Drawing.Color.Black;
            this.lblReligionName.Size = new System.Drawing.Size(49, 18);
            this.lblReligionName.TabIndex = 29;
            this.lblReligionName.Text = "Name:";
            // 
            // txtReligionName
            // 
            this.txtReligionName.BackColor = System.Drawing.Color.DarkRed;
            this.txtReligionName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtReligionName.ForeColor = System.Drawing.Color.Gold;
            this.txtReligionName.Location = new System.Drawing.Point(97, 24);
            this.txtReligionName.Name = "txtReligionName";
            this.txtReligionName.Size = new System.Drawing.Size(184, 25);
            this.txtReligionName.TabIndex = 29;
            this.txtReligionName.TextChanged += new System.EventHandler(this.txtReligionName_TextChanged);
            // 
            // grpAbility
            // 
            this.grpAbility.BackColor = System.Drawing.Color.Transparent;
            this.grpAbility.BorderColor = System.Drawing.Color.DarkRed;
            this.grpAbility.Controls.Add(this.lblRecruitmentBonus);
            this.grpAbility.Controls.Add(this.lblDefenceBonus);
            this.grpAbility.Controls.Add(this.lblAttackBonus);
            this.grpAbility.Controls.Add(this.lblOutcomeBonus);
            this.grpAbility.Controls.Add(this.lblIncomeBonus);
            this.grpAbility.Controls.Add(this.numRecruitmentBonus);
            this.grpAbility.Controls.Add(this.numDefenceBonus);
            this.grpAbility.Controls.Add(this.numAttackBonus);
            this.grpAbility.Controls.Add(this.numOutcomeBonus);
            this.grpAbility.Controls.Add(this.numIncomeBonus);
            this.grpAbility.Controls.Add(this.txtAbilityName);
            this.grpAbility.Controls.Add(this.lblAbilityName);
            this.grpAbility.Enabled = false;
            this.grpAbility.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpAbility.ForeColor = System.Drawing.Color.Gold;
            this.grpAbility.Location = new System.Drawing.Point(8, 259);
            this.grpAbility.Name = "grpAbility";
            this.grpAbility.ShadowColor = System.Drawing.Color.Black;
            this.grpAbility.Size = new System.Drawing.Size(288, 277);
            this.grpAbility.TabIndex = 8;
            this.grpAbility.TabStop = false;
            this.grpAbility.Text = "Ability";
            this.grpAbility.TextPosition = Narivia.CustomGroupBoxTextPosition.Left;
            // 
            // lblRecruitmentBonus
            // 
            this.lblRecruitmentBonus.AutoSize = true;
            this.lblRecruitmentBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblRecruitmentBonus.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRecruitmentBonus.ForeColor = System.Drawing.Color.Gold;
            this.lblRecruitmentBonus.Location = new System.Drawing.Point(6, 181);
            this.lblRecruitmentBonus.Name = "lblRecruitmentBonus";
            this.lblRecruitmentBonus.ShadowColor = System.Drawing.Color.Black;
            this.lblRecruitmentBonus.Size = new System.Drawing.Size(86, 18);
            this.lblRecruitmentBonus.TabIndex = 28;
            this.lblRecruitmentBonus.Text = "Recruitment:";
            // 
            // lblDefenceBonus
            // 
            this.lblDefenceBonus.AutoSize = true;
            this.lblDefenceBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblDefenceBonus.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDefenceBonus.ForeColor = System.Drawing.Color.Gold;
            this.lblDefenceBonus.Location = new System.Drawing.Point(6, 150);
            this.lblDefenceBonus.Name = "lblDefenceBonus";
            this.lblDefenceBonus.ShadowColor = System.Drawing.Color.Black;
            this.lblDefenceBonus.Size = new System.Drawing.Size(63, 18);
            this.lblDefenceBonus.TabIndex = 27;
            this.lblDefenceBonus.Text = "Defence:";
            // 
            // lblAttackBonus
            // 
            this.lblAttackBonus.AutoSize = true;
            this.lblAttackBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblAttackBonus.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAttackBonus.ForeColor = System.Drawing.Color.Gold;
            this.lblAttackBonus.Location = new System.Drawing.Point(6, 119);
            this.lblAttackBonus.Name = "lblAttackBonus";
            this.lblAttackBonus.ShadowColor = System.Drawing.Color.Black;
            this.lblAttackBonus.Size = new System.Drawing.Size(51, 18);
            this.lblAttackBonus.TabIndex = 26;
            this.lblAttackBonus.Text = "Attack:";
            // 
            // lblOutcomeBonus
            // 
            this.lblOutcomeBonus.AutoSize = true;
            this.lblOutcomeBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblOutcomeBonus.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOutcomeBonus.ForeColor = System.Drawing.Color.Gold;
            this.lblOutcomeBonus.Location = new System.Drawing.Point(6, 88);
            this.lblOutcomeBonus.Name = "lblOutcomeBonus";
            this.lblOutcomeBonus.ShadowColor = System.Drawing.Color.Black;
            this.lblOutcomeBonus.Size = new System.Drawing.Size(68, 18);
            this.lblOutcomeBonus.TabIndex = 25;
            this.lblOutcomeBonus.Text = "Outcome:";
            // 
            // lblIncomeBonus
            // 
            this.lblIncomeBonus.AutoSize = true;
            this.lblIncomeBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeBonus.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIncomeBonus.ForeColor = System.Drawing.Color.Gold;
            this.lblIncomeBonus.Location = new System.Drawing.Point(6, 57);
            this.lblIncomeBonus.Name = "lblIncomeBonus";
            this.lblIncomeBonus.ShadowColor = System.Drawing.Color.Black;
            this.lblIncomeBonus.Size = new System.Drawing.Size(58, 18);
            this.lblIncomeBonus.TabIndex = 24;
            this.lblIncomeBonus.Text = "Income:";
            // 
            // numRecruitmentBonus
            // 
            this.numRecruitmentBonus.BackColor = System.Drawing.Color.DarkRed;
            this.numRecruitmentBonus.ForeColor = System.Drawing.Color.Gold;
            this.numRecruitmentBonus.Location = new System.Drawing.Point(98, 179);
            this.numRecruitmentBonus.Name = "numRecruitmentBonus";
            this.numRecruitmentBonus.Size = new System.Drawing.Size(184, 25);
            this.numRecruitmentBonus.TabIndex = 23;
            this.numRecruitmentBonus.ValueChanged += new System.EventHandler(this.numRecruitmentBonus_ValueChanged);
            // 
            // numDefenceBonus
            // 
            this.numDefenceBonus.BackColor = System.Drawing.Color.DarkRed;
            this.numDefenceBonus.ForeColor = System.Drawing.Color.Gold;
            this.numDefenceBonus.Location = new System.Drawing.Point(98, 148);
            this.numDefenceBonus.Name = "numDefenceBonus";
            this.numDefenceBonus.Size = new System.Drawing.Size(184, 25);
            this.numDefenceBonus.TabIndex = 22;
            this.numDefenceBonus.ValueChanged += new System.EventHandler(this.numDefenceBonus_ValueChanged);
            // 
            // numAttackBonus
            // 
            this.numAttackBonus.BackColor = System.Drawing.Color.DarkRed;
            this.numAttackBonus.ForeColor = System.Drawing.Color.Gold;
            this.numAttackBonus.Location = new System.Drawing.Point(98, 117);
            this.numAttackBonus.Name = "numAttackBonus";
            this.numAttackBonus.Size = new System.Drawing.Size(184, 25);
            this.numAttackBonus.TabIndex = 21;
            this.numAttackBonus.ValueChanged += new System.EventHandler(this.numAttackBonus_ValueChanged);
            // 
            // numOutcomeBonus
            // 
            this.numOutcomeBonus.BackColor = System.Drawing.Color.DarkRed;
            this.numOutcomeBonus.ForeColor = System.Drawing.Color.Gold;
            this.numOutcomeBonus.Location = new System.Drawing.Point(98, 86);
            this.numOutcomeBonus.Name = "numOutcomeBonus";
            this.numOutcomeBonus.Size = new System.Drawing.Size(184, 25);
            this.numOutcomeBonus.TabIndex = 20;
            this.numOutcomeBonus.ValueChanged += new System.EventHandler(this.numOutcomeBonus_ValueChanged);
            // 
            // numIncomeBonus
            // 
            this.numIncomeBonus.BackColor = System.Drawing.Color.DarkRed;
            this.numIncomeBonus.ForeColor = System.Drawing.Color.Gold;
            this.numIncomeBonus.Location = new System.Drawing.Point(98, 55);
            this.numIncomeBonus.Name = "numIncomeBonus";
            this.numIncomeBonus.Size = new System.Drawing.Size(184, 25);
            this.numIncomeBonus.TabIndex = 19;
            this.numIncomeBonus.ValueChanged += new System.EventHandler(this.numIncomeBonus_ValueChanged);
            // 
            // txtAbilityName
            // 
            this.txtAbilityName.BackColor = System.Drawing.Color.DarkRed;
            this.txtAbilityName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAbilityName.ForeColor = System.Drawing.Color.Gold;
            this.txtAbilityName.Location = new System.Drawing.Point(98, 24);
            this.txtAbilityName.Name = "txtAbilityName";
            this.txtAbilityName.Size = new System.Drawing.Size(184, 25);
            this.txtAbilityName.TabIndex = 18;
            this.txtAbilityName.TextChanged += new System.EventHandler(this.txtAbilityName_TextChanged);
            // 
            // lblAbilityName
            // 
            this.lblAbilityName.AutoSize = true;
            this.lblAbilityName.BackColor = System.Drawing.Color.Transparent;
            this.lblAbilityName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAbilityName.ForeColor = System.Drawing.Color.Gold;
            this.lblAbilityName.Location = new System.Drawing.Point(6, 27);
            this.lblAbilityName.Name = "lblAbilityName";
            this.lblAbilityName.ShadowColor = System.Drawing.Color.Black;
            this.lblAbilityName.Size = new System.Drawing.Size(49, 18);
            this.lblAbilityName.TabIndex = 0;
            this.lblAbilityName.Text = "Name:";
            // 
            // grpFaction
            // 
            this.grpFaction.BackColor = System.Drawing.Color.Transparent;
            this.grpFaction.BorderColor = System.Drawing.Color.DarkRed;
            this.grpFaction.Controls.Add(this.lblReligion);
            this.grpFaction.Controls.Add(this.cmbReligion);
            this.grpFaction.Controls.Add(this.lblFactionDescription);
            this.grpFaction.Controls.Add(this.txtFactionDescription);
            this.grpFaction.Controls.Add(this.lblCulture);
            this.grpFaction.Controls.Add(this.lblAbility);
            this.grpFaction.Controls.Add(this.cmbCulture);
            this.grpFaction.Controls.Add(this.cmbAbility);
            this.grpFaction.Controls.Add(this.txtFactionName);
            this.grpFaction.Controls.Add(this.lblFactionName);
            this.grpFaction.Enabled = false;
            this.grpFaction.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpFaction.ForeColor = System.Drawing.Color.Gold;
            this.grpFaction.Location = new System.Drawing.Point(302, 99);
            this.grpFaction.Name = "grpFaction";
            this.grpFaction.ShadowColor = System.Drawing.Color.Black;
            this.grpFaction.Size = new System.Drawing.Size(288, 282);
            this.grpFaction.TabIndex = 7;
            this.grpFaction.TabStop = false;
            this.grpFaction.Text = "Faction";
            this.grpFaction.TextPosition = Narivia.CustomGroupBoxTextPosition.Left;
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.BackColor = System.Drawing.Color.Transparent;
            this.lblReligion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReligion.ForeColor = System.Drawing.Color.Gold;
            this.lblReligion.Location = new System.Drawing.Point(6, 122);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.ShadowColor = System.Drawing.Color.Black;
            this.lblReligion.Size = new System.Drawing.Size(64, 18);
            this.lblReligion.TabIndex = 24;
            this.lblReligion.Text = "Religion:";
            // 
            // cmbReligion
            // 
            this.cmbReligion.BackColor = System.Drawing.Color.DarkRed;
            this.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReligion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReligion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbReligion.ForeColor = System.Drawing.Color.Gold;
            this.cmbReligion.FormattingEnabled = true;
            this.cmbReligion.Location = new System.Drawing.Point(82, 119);
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.ShadowColor = System.Drawing.Color.Black;
            this.cmbReligion.Size = new System.Drawing.Size(200, 26);
            this.cmbReligion.TabIndex = 23;
            this.cmbReligion.SelectedIndexChanged += new System.EventHandler(this.cmbReligion_SelectedIndexChanged);
            // 
            // lblFactionDescription
            // 
            this.lblFactionDescription.AutoSize = true;
            this.lblFactionDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblFactionDescription.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFactionDescription.ForeColor = System.Drawing.Color.Gold;
            this.lblFactionDescription.Location = new System.Drawing.Point(103, 148);
            this.lblFactionDescription.Name = "lblFactionDescription";
            this.lblFactionDescription.ShadowColor = System.Drawing.Color.Black;
            this.lblFactionDescription.Size = new System.Drawing.Size(83, 18);
            this.lblFactionDescription.TabIndex = 22;
            this.lblFactionDescription.Text = "Description:";
            // 
            // txtFactionDescription
            // 
            this.txtFactionDescription.BackColor = System.Drawing.Color.DarkRed;
            this.txtFactionDescription.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFactionDescription.ForeColor = System.Drawing.Color.Gold;
            this.txtFactionDescription.Location = new System.Drawing.Point(6, 169);
            this.txtFactionDescription.Multiline = true;
            this.txtFactionDescription.Name = "txtFactionDescription";
            this.txtFactionDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFactionDescription.Size = new System.Drawing.Size(276, 107);
            this.txtFactionDescription.TabIndex = 21;
            this.txtFactionDescription.TextChanged += new System.EventHandler(this.txtFactionDescription_TextChanged);
            // 
            // lblCulture
            // 
            this.lblCulture.AutoSize = true;
            this.lblCulture.BackColor = System.Drawing.Color.Transparent;
            this.lblCulture.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCulture.ForeColor = System.Drawing.Color.Gold;
            this.lblCulture.Location = new System.Drawing.Point(6, 90);
            this.lblCulture.Name = "lblCulture";
            this.lblCulture.ShadowColor = System.Drawing.Color.Black;
            this.lblCulture.Size = new System.Drawing.Size(57, 18);
            this.lblCulture.TabIndex = 20;
            this.lblCulture.Text = "Culture:";
            // 
            // lblAbility
            // 
            this.lblAbility.AutoSize = true;
            this.lblAbility.BackColor = System.Drawing.Color.Transparent;
            this.lblAbility.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAbility.ForeColor = System.Drawing.Color.Gold;
            this.lblAbility.Location = new System.Drawing.Point(6, 58);
            this.lblAbility.Name = "lblAbility";
            this.lblAbility.ShadowColor = System.Drawing.Color.Black;
            this.lblAbility.Size = new System.Drawing.Size(53, 18);
            this.lblAbility.TabIndex = 19;
            this.lblAbility.Text = "Ability:";
            // 
            // cmbCulture
            // 
            this.cmbCulture.BackColor = System.Drawing.Color.DarkRed;
            this.cmbCulture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCulture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCulture.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbCulture.ForeColor = System.Drawing.Color.Gold;
            this.cmbCulture.FormattingEnabled = true;
            this.cmbCulture.Location = new System.Drawing.Point(82, 87);
            this.cmbCulture.Name = "cmbCulture";
            this.cmbCulture.ShadowColor = System.Drawing.Color.Black;
            this.cmbCulture.Size = new System.Drawing.Size(200, 26);
            this.cmbCulture.TabIndex = 18;
            this.cmbCulture.SelectedIndexChanged += new System.EventHandler(this.cmbCulture_SelectedIndexChanged);
            // 
            // cmbAbility
            // 
            this.cmbAbility.BackColor = System.Drawing.Color.DarkRed;
            this.cmbAbility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAbility.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbAbility.ForeColor = System.Drawing.Color.Gold;
            this.cmbAbility.FormattingEnabled = true;
            this.cmbAbility.Location = new System.Drawing.Point(82, 55);
            this.cmbAbility.Name = "cmbAbility";
            this.cmbAbility.ShadowColor = System.Drawing.Color.Black;
            this.cmbAbility.Size = new System.Drawing.Size(200, 26);
            this.cmbAbility.TabIndex = 18;
            this.cmbAbility.SelectedIndexChanged += new System.EventHandler(this.cmbAbility_SelectedIndexChanged);
            // 
            // txtFactionName
            // 
            this.txtFactionName.BackColor = System.Drawing.Color.DarkRed;
            this.txtFactionName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtFactionName.ForeColor = System.Drawing.Color.Gold;
            this.txtFactionName.Location = new System.Drawing.Point(82, 24);
            this.txtFactionName.Name = "txtFactionName";
            this.txtFactionName.Size = new System.Drawing.Size(200, 25);
            this.txtFactionName.TabIndex = 18;
            this.txtFactionName.TextChanged += new System.EventHandler(this.txtFactionName_TextChanged);
            // 
            // lblFactionName
            // 
            this.lblFactionName.AutoSize = true;
            this.lblFactionName.BackColor = System.Drawing.Color.Transparent;
            this.lblFactionName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFactionName.ForeColor = System.Drawing.Color.Gold;
            this.lblFactionName.Location = new System.Drawing.Point(6, 27);
            this.lblFactionName.Name = "lblFactionName";
            this.lblFactionName.ShadowColor = System.Drawing.Color.Black;
            this.lblFactionName.Size = new System.Drawing.Size(49, 18);
            this.lblFactionName.TabIndex = 18;
            this.lblFactionName.Text = "Name:";
            // 
            // grpRegion
            // 
            this.grpRegion.BackColor = System.Drawing.Color.Transparent;
            this.grpRegion.BorderColor = System.Drawing.Color.DarkRed;
            this.grpRegion.Controls.Add(this.lblFaction);
            this.grpRegion.Controls.Add(this.cmbFaction);
            this.grpRegion.Controls.Add(this.lblBiome);
            this.grpRegion.Controls.Add(this.cmbBiome);
            this.grpRegion.Controls.Add(this.lblResource);
            this.grpRegion.Controls.Add(this.cmbResource);
            this.grpRegion.Controls.Add(this.txtRegionName);
            this.grpRegion.Controls.Add(this.lblRegionName);
            this.grpRegion.Enabled = false;
            this.grpRegion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpRegion.ForeColor = System.Drawing.Color.Gold;
            this.grpRegion.Location = new System.Drawing.Point(8, 99);
            this.grpRegion.Name = "grpRegion";
            this.grpRegion.ShadowColor = System.Drawing.Color.Black;
            this.grpRegion.Size = new System.Drawing.Size(288, 154);
            this.grpRegion.TabIndex = 6;
            this.grpRegion.TabStop = false;
            this.grpRegion.Text = "Region";
            this.grpRegion.TextPosition = Narivia.CustomGroupBoxTextPosition.Left;
            // 
            // lblFaction
            // 
            this.lblFaction.AutoSize = true;
            this.lblFaction.BackColor = System.Drawing.Color.Transparent;
            this.lblFaction.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFaction.ForeColor = System.Drawing.Color.Gold;
            this.lblFaction.Location = new System.Drawing.Point(6, 58);
            this.lblFaction.Name = "lblFaction";
            this.lblFaction.ShadowColor = System.Drawing.Color.Black;
            this.lblFaction.Size = new System.Drawing.Size(57, 18);
            this.lblFaction.TabIndex = 17;
            this.lblFaction.Text = "Faction:";
            // 
            // cmbFaction
            // 
            this.cmbFaction.BackColor = System.Drawing.Color.DarkRed;
            this.cmbFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFaction.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbFaction.ForeColor = System.Drawing.Color.Gold;
            this.cmbFaction.FormattingEnabled = true;
            this.cmbFaction.Location = new System.Drawing.Point(98, 55);
            this.cmbFaction.Name = "cmbFaction";
            this.cmbFaction.ShadowColor = System.Drawing.Color.Black;
            this.cmbFaction.Size = new System.Drawing.Size(184, 26);
            this.cmbFaction.TabIndex = 16;
            this.cmbFaction.SelectedIndexChanged += new System.EventHandler(this.cmbFaction_SelectedIndexChanged);
            // 
            // lblBiome
            // 
            this.lblBiome.AutoSize = true;
            this.lblBiome.BackColor = System.Drawing.Color.Transparent;
            this.lblBiome.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBiome.ForeColor = System.Drawing.Color.Gold;
            this.lblBiome.Location = new System.Drawing.Point(6, 90);
            this.lblBiome.Name = "lblBiome";
            this.lblBiome.ShadowColor = System.Drawing.Color.Black;
            this.lblBiome.Size = new System.Drawing.Size(52, 18);
            this.lblBiome.TabIndex = 15;
            this.lblBiome.Text = "Biome:";
            // 
            // cmbBiome
            // 
            this.cmbBiome.BackColor = System.Drawing.Color.DarkRed;
            this.cmbBiome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBiome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBiome.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbBiome.ForeColor = System.Drawing.Color.Gold;
            this.cmbBiome.FormattingEnabled = true;
            this.cmbBiome.Location = new System.Drawing.Point(98, 84);
            this.cmbBiome.Name = "cmbBiome";
            this.cmbBiome.ShadowColor = System.Drawing.Color.Black;
            this.cmbBiome.Size = new System.Drawing.Size(184, 26);
            this.cmbBiome.TabIndex = 14;
            this.cmbBiome.SelectedIndexChanged += new System.EventHandler(this.cmbBiome_SelectedIndexChanged);
            // 
            // lblResource
            // 
            this.lblResource.AutoSize = true;
            this.lblResource.BackColor = System.Drawing.Color.Transparent;
            this.lblResource.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResource.ForeColor = System.Drawing.Color.Gold;
            this.lblResource.Location = new System.Drawing.Point(6, 116);
            this.lblResource.Name = "lblResource";
            this.lblResource.ShadowColor = System.Drawing.Color.Black;
            this.lblResource.Size = new System.Drawing.Size(68, 18);
            this.lblResource.TabIndex = 13;
            this.lblResource.Text = "Resource:";
            // 
            // cmbResource
            // 
            this.cmbResource.BackColor = System.Drawing.Color.DarkRed;
            this.cmbResource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbResource.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbResource.ForeColor = System.Drawing.Color.Gold;
            this.cmbResource.FormattingEnabled = true;
            this.cmbResource.Location = new System.Drawing.Point(98, 116);
            this.cmbResource.Name = "cmbResource";
            this.cmbResource.ShadowColor = System.Drawing.Color.Black;
            this.cmbResource.Size = new System.Drawing.Size(184, 26);
            this.cmbResource.TabIndex = 6;
            this.cmbResource.SelectedIndexChanged += new System.EventHandler(this.cmbResource_SelectedIndexChanged);
            // 
            // txtRegionName
            // 
            this.txtRegionName.BackColor = System.Drawing.Color.DarkRed;
            this.txtRegionName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtRegionName.ForeColor = System.Drawing.Color.Gold;
            this.txtRegionName.Location = new System.Drawing.Point(98, 24);
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.Size = new System.Drawing.Size(184, 25);
            this.txtRegionName.TabIndex = 12;
            this.txtRegionName.TextChanged += new System.EventHandler(this.txtRegionName_TextChanged);
            // 
            // lblRegionName
            // 
            this.lblRegionName.AutoSize = true;
            this.lblRegionName.BackColor = System.Drawing.Color.Transparent;
            this.lblRegionName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRegionName.ForeColor = System.Drawing.Color.Gold;
            this.lblRegionName.Location = new System.Drawing.Point(6, 27);
            this.lblRegionName.Name = "lblRegionName";
            this.lblRegionName.ShadowColor = System.Drawing.Color.Black;
            this.lblRegionName.Size = new System.Drawing.Size(49, 18);
            this.lblRegionName.TabIndex = 0;
            this.lblRegionName.Text = "Name:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Gold;
            this.btnSave.Location = new System.Drawing.Point(171, 541);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(256, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Map";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpLoadMap
            // 
            this.grpLoadMap.BackColor = System.Drawing.Color.Transparent;
            this.grpLoadMap.BorderColor = System.Drawing.Color.DarkRed;
            this.grpLoadMap.Controls.Add(this.btnLoad);
            this.grpLoadMap.Controls.Add(this.cmbMap);
            this.grpLoadMap.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpLoadMap.ForeColor = System.Drawing.Color.Gold;
            this.grpLoadMap.Location = new System.Drawing.Point(137, 31);
            this.grpLoadMap.Name = "grpLoadMap";
            this.grpLoadMap.ShadowColor = System.Drawing.Color.Black;
            this.grpLoadMap.Size = new System.Drawing.Size(325, 62);
            this.grpLoadMap.TabIndex = 2;
            this.grpLoadMap.TabStop = false;
            this.grpLoadMap.Text = "Load Map";
            this.grpLoadMap.TextPosition = Narivia.CustomGroupBoxTextPosition.Left;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkRed;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnLoad.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.Gold;
            this.btnLoad.Location = new System.Drawing.Point(239, 31);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ShadowColor = System.Drawing.Color.Black;
            this.btnLoad.Size = new System.Drawing.Size(80, 24);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cmbMap
            // 
            this.cmbMap.BackColor = System.Drawing.Color.DarkRed;
            this.cmbMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMap.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbMap.ForeColor = System.Drawing.Color.Gold;
            this.cmbMap.FormattingEnabled = true;
            this.cmbMap.Location = new System.Drawing.Point(6, 30);
            this.cmbMap.Name = "cmbMap";
            this.cmbMap.ShadowColor = System.Drawing.Color.Black;
            this.cmbMap.Size = new System.Drawing.Size(227, 26);
            this.cmbMap.TabIndex = 4;
            // 
            // lblMapName
            // 
            this.lblMapName.BackColor = System.Drawing.Color.Transparent;
            this.lblMapName.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMapName.ForeColor = System.Drawing.Color.Gold;
            this.lblMapName.Location = new System.Drawing.Point(0, 0);
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.ShadowColor = System.Drawing.Color.Black;
            this.lblMapName.Size = new System.Drawing.Size(596, 28);
            this.lblMapName.TabIndex = 1;
            this.lblMapName.Text = "<MapName>";
            this.lblMapName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separatorV1
            // 
            this.separatorV1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorV1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(120)))), ((int)(((byte)(66)))));
            this.separatorV1.Font = new System.Drawing.Font("Palatino Linotype", 300F, System.Drawing.FontStyle.Bold);
            this.separatorV1.ForeColor = System.Drawing.Color.Gold;
            this.separatorV1.Location = new System.Drawing.Point(661, 36);
            this.separatorV1.Name = "separatorV1";
            this.separatorV1.ShadowColor = System.Drawing.Color.Black;
            this.separatorV1.Size = new System.Drawing.Size(8, 601);
            this.separatorV1.TabIndex = 20;
            this.separatorV1.TitleText = null;
            this.separatorV1.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMap
            // 
            this.pnlMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMap.AutoScroll = true;
            this.pnlMap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMap.Controls.Add(this.Map);
            this.pnlMap.Location = new System.Drawing.Point(4, 36);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(657, 601);
            this.pnlMap.TabIndex = 23;
            // 
            // NoticeBoard
            // 
            this.NoticeBoard.AutoScroll = true;
            this.NoticeBoard.BackColor = System.Drawing.Color.Transparent;
            this.NoticeBoard.Location = new System.Drawing.Point(4, 36);
            this.NoticeBoard.Name = "NoticeBoard";
            this.NoticeBoard.Size = new System.Drawing.Size(48, 144);
            this.NoticeBoard.TabIndex = 16;
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = true;
            this.ClientSize = new System.Drawing.Size(1272, 641);
            this.Controls.Add(this.NoticeBoard);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.separatorV1);
            this.Controls.Add(this.Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(774, 630);
            this.Name = "frmEditor";
            this.Text = "Narivia - Map Editor";
            this.Resize += new System.EventHandler(this.frmGame_Resize);
            this.Controls.SetChildIndex(this.Panel, 0);
            this.Controls.SetChildIndex(this.separatorV1, 0);
            this.Controls.SetChildIndex(this.pnlMap, 0);
            this.Controls.SetChildIndex(this.NoticeBoard, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            this.Panel.ResumeLayout(false);
            this.grpReligion.ResumeLayout(false);
            this.grpReligion.PerformLayout();
            this.grpAbility.ResumeLayout(false);
            this.grpAbility.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRecruitmentBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefenceBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttackBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutcomeBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncomeBonus)).EndInit();
            this.grpFaction.ResumeLayout(false);
            this.grpFaction.PerformLayout();
            this.grpRegion.ResumeLayout(false);
            this.grpRegion.PerformLayout();
            this.grpLoadMap.ResumeLayout(false);
            this.pnlMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Map;
        internal System.Windows.Forms.Panel Panel;
        private NoticeBoard NoticeBoard;
        private CustomPanel separatorV1;
        private System.Windows.Forms.Panel pnlMap;
        private CustomLabel lblMapName;
        private CustomGroupBox grpLoadMap;
        private CustomButton btnSave;
        private CustomButton btnLoad;
        private CustomComboBox cmbMap;
        private CustomGroupBox grpFaction;
        private CustomGroupBox grpRegion;
        private CustomLabel lblRegionName;
        private CustomLabel lblBiome;
        private CustomComboBox cmbBiome;
        private CustomComboBox cmbResource;
        private CustomLabel lblResource;
        private System.Windows.Forms.TextBox txtRegionName;
        private CustomLabel lblFaction;
        private CustomComboBox cmbFaction;
        private CustomLabel lblCulture;
        private CustomLabel lblAbility;
        private CustomComboBox cmbCulture;
        private CustomComboBox cmbAbility;
        private System.Windows.Forms.TextBox txtFactionName;
        private CustomLabel lblFactionName;
        private CustomLabel lblFactionDescription;
        private System.Windows.Forms.TextBox txtFactionDescription;
        private CustomGroupBox grpAbility;
        private CustomLabel lblRecruitmentBonus;
        private CustomLabel lblDefenceBonus;
        private CustomLabel lblAttackBonus;
        private CustomLabel lblOutcomeBonus;
        private CustomLabel lblIncomeBonus;
        private System.Windows.Forms.NumericUpDown numRecruitmentBonus;
        private System.Windows.Forms.NumericUpDown numDefenceBonus;
        private System.Windows.Forms.NumericUpDown numAttackBonus;
        private System.Windows.Forms.NumericUpDown numOutcomeBonus;
        private System.Windows.Forms.NumericUpDown numIncomeBonus;
        private System.Windows.Forms.TextBox txtAbilityName;
        private CustomLabel lblAbilityName;
        private CustomGroupBox grpReligion;
        private CustomLabel lblReligionName;
        private System.Windows.Forms.TextBox txtReligionName;
        private CustomLabel lblReligion;
        private CustomComboBox cmbReligion;
        private System.Windows.Forms.TextBox txtReligionDescription;
        private CustomLabel lblReligionDescription;
    }
}