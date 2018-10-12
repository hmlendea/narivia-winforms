namespace Narivia
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.NoticeBoard = new Narivia.NoticeBoard();
            this.RegionBar = new Narivia.RegionBar();
            this.BuildingsPanel = new Narivia.BuildingsPanel();
            this.Console = new System.Windows.Forms.TextBox();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.Map = new System.Windows.Forms.PictureBox();
            this.separatorH1 = new Narivia.CustomPanel();
            this.separatorV1 = new Narivia.CustomPanel();
            this.InfoBar = new System.Windows.Forms.Panel();
            this.lblRecruitmentBonus = new Narivia.CustomLabel();
            this.pbRecruitmentBonus = new System.Windows.Forms.PictureBox();
            this.lblDefenceBonus = new Narivia.CustomLabel();
            this.pbDefenceBonus = new System.Windows.Forms.PictureBox();
            this.lblAttackBonus = new Narivia.CustomLabel();
            this.pbAttackBonus = new System.Windows.Forms.PictureBox();
            this.lblMoney = new Narivia.CustomLabel();
            this.pbMoney = new System.Windows.Forms.PictureBox();
            this.lblTroops = new Narivia.CustomLabel();
            this.pbTroops = new System.Windows.Forms.PictureBox();
            this.lblRegions = new Narivia.CustomLabel();
            this.pbRegions = new System.Windows.Forms.PictureBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.btnBuild = new Narivia.CustomButton();
            this.btnRecruit = new Narivia.CustomButton();
            this.btnMenu = new Narivia.CustomButton();
            this.lblPlayerName = new Narivia.CustomLabel();
            this.btnEndTurn = new Narivia.CustomButton();
            this.btnScreenshot = new Narivia.CustomButton();
            this.grpAutomation = new Narivia.CustomGroupBox();
            this.chkAutoRecruit = new Narivia.CustomCheckBox();
            this.chkAutoBuild = new Narivia.CustomCheckBox();
            this.chkDeclineLiberations = new Narivia.CustomCheckBox();
            this.btnEconomy = new Narivia.CustomButton();
            this.btnTurnReport = new Narivia.CustomButton();
            this.btnRelations = new Narivia.CustomButton();
            this.grpActions = new Narivia.CustomGroupBox();
            this.chkSpy = new Narivia.CustomRadioButton();
            this.chkSelect = new Narivia.CustomRadioButton();
            this.pbLogoPlayer = new System.Windows.Forms.PictureBox();
            this.lblTurn = new Narivia.CustomLabel();
            this.pnlMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            this.InfoBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecruitmentBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefenceBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttackBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTroops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegions)).BeginInit();
            this.Panel.SuspendLayout();
            this.grpAutomation.SuspendLayout();
            this.grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // NoticeBoard
            // 
            this.NoticeBoard.AutoScroll = true;
            this.NoticeBoard.BackColor = System.Drawing.Color.Transparent;
            this.NoticeBoard.Location = new System.Drawing.Point(4, 60);
            this.NoticeBoard.Name = "NoticeBoard";
            this.NoticeBoard.Size = new System.Drawing.Size(48, 144);
            this.NoticeBoard.TabIndex = 16;
            // 
            // RegionBar
            // 
            this.RegionBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RegionBar.BackColor = System.Drawing.Color.Transparent;
            this.RegionBar.frmGame = null;
            this.RegionBar.Location = new System.Drawing.Point(211, 571);
            this.RegionBar.MaximumSize = new System.Drawing.Size(240, 36);
            this.RegionBar.MinimumSize = new System.Drawing.Size(240, 36);
            this.RegionBar.Name = "RegionBar";
            this.RegionBar.RegionID = 0;
            this.RegionBar.Size = new System.Drawing.Size(240, 36);
            this.RegionBar.TabIndex = 25;
            // 
            // BuildingsPanel
            // 
            this.BuildingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildingsPanel.AutoScroll = true;
            this.BuildingsPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BuildingsPanel.Colorized = false;
            this.BuildingsPanel.Location = new System.Drawing.Point(4, 594);
            this.BuildingsPanel.Name = "BuildingsPanel";
            this.BuildingsPanel.Size = new System.Drawing.Size(1008, 78);
            this.BuildingsPanel.TabIndex = 24;
            // 
            // Console
            // 
            this.Console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Console.BackColor = System.Drawing.Color.Black;
            this.Console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Console.Enabled = false;
            this.Console.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Console.ForeColor = System.Drawing.Color.White;
            this.Console.Location = new System.Drawing.Point(120, 60);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(422, 18);
            this.Console.TabIndex = 17;
            this.Console.Visible = false;
            this.Console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Console_KeyDown);
            this.Console.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Console_PreviewKeyDown);
            // 
            // pnlMap
            // 
            this.pnlMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMap.AutoScroll = true;
            this.pnlMap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMap.Controls.Add(this.Map);
            this.pnlMap.Location = new System.Drawing.Point(4, 60);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(657, 526);
            this.pnlMap.TabIndex = 23;
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
            // separatorH1
            // 
            this.separatorH1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorH1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(120)))), ((int)(((byte)(66)))));
            this.separatorH1.Font = new System.Drawing.Font("Palatino Linotype", 4F, System.Drawing.FontStyle.Bold);
            this.separatorH1.ForeColor = System.Drawing.Color.Gold;
            this.separatorH1.Location = new System.Drawing.Point(4, 586);
            this.separatorH1.Name = "separatorH1";
            this.separatorH1.ShadowColor = System.Drawing.Color.Black;
            this.separatorH1.Size = new System.Drawing.Size(1008, 8);
            this.separatorH1.TabIndex = 22;
            this.separatorH1.TitleText = null;
            this.separatorH1.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separatorV1
            // 
            this.separatorV1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatorV1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(120)))), ((int)(((byte)(66)))));
            this.separatorV1.Font = new System.Drawing.Font("Palatino Linotype", 263F, System.Drawing.FontStyle.Bold);
            this.separatorV1.ForeColor = System.Drawing.Color.Gold;
            this.separatorV1.Location = new System.Drawing.Point(661, 60);
            this.separatorV1.Name = "separatorV1";
            this.separatorV1.ShadowColor = System.Drawing.Color.Black;
            this.separatorV1.Size = new System.Drawing.Size(8, 526);
            this.separatorV1.TabIndex = 20;
            this.separatorV1.TitleText = null;
            this.separatorV1.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoBar
            // 
            this.InfoBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoBar.BackColor = System.Drawing.Color.Black;
            this.InfoBar.Controls.Add(this.lblRecruitmentBonus);
            this.InfoBar.Controls.Add(this.pbRecruitmentBonus);
            this.InfoBar.Controls.Add(this.lblDefenceBonus);
            this.InfoBar.Controls.Add(this.pbDefenceBonus);
            this.InfoBar.Controls.Add(this.lblAttackBonus);
            this.InfoBar.Controls.Add(this.pbAttackBonus);
            this.InfoBar.Controls.Add(this.lblMoney);
            this.InfoBar.Controls.Add(this.pbMoney);
            this.InfoBar.Controls.Add(this.lblTroops);
            this.InfoBar.Controls.Add(this.pbTroops);
            this.InfoBar.Controls.Add(this.lblRegions);
            this.InfoBar.Controls.Add(this.pbRegions);
            this.InfoBar.Location = new System.Drawing.Point(4, 36);
            this.InfoBar.Name = "InfoBar";
            this.InfoBar.Size = new System.Drawing.Size(1008, 24);
            this.InfoBar.TabIndex = 19;
            // 
            // lblRecruitmentBonus
            // 
            this.lblRecruitmentBonus.AutoSize = true;
            this.lblRecruitmentBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblRecruitmentBonus.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.lblRecruitmentBonus.ForeColor = System.Drawing.Color.Gold;
            this.lblRecruitmentBonus.Location = new System.Drawing.Point(267, 4);
            this.lblRecruitmentBonus.Name = "lblRecruitmentBonus";
            this.lblRecruitmentBonus.ShadowColor = System.Drawing.Color.Black;
            this.lblRecruitmentBonus.Size = new System.Drawing.Size(14, 16);
            this.lblRecruitmentBonus.TabIndex = 11;
            this.lblRecruitmentBonus.Text = "0";
            // 
            // pbRecruitmentBonus
            // 
            this.pbRecruitmentBonus.BackColor = System.Drawing.Color.Transparent;
            this.pbRecruitmentBonus.Location = new System.Drawing.Point(245, 4);
            this.pbRecruitmentBonus.Name = "pbRecruitmentBonus";
            this.pbRecruitmentBonus.Size = new System.Drawing.Size(16, 16);
            this.pbRecruitmentBonus.TabIndex = 10;
            this.pbRecruitmentBonus.TabStop = false;
            // 
            // lblDefenceBonus
            // 
            this.lblDefenceBonus.AutoSize = true;
            this.lblDefenceBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblDefenceBonus.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.lblDefenceBonus.ForeColor = System.Drawing.Color.Gold;
            this.lblDefenceBonus.Location = new System.Drawing.Point(225, 4);
            this.lblDefenceBonus.Name = "lblDefenceBonus";
            this.lblDefenceBonus.ShadowColor = System.Drawing.Color.Black;
            this.lblDefenceBonus.Size = new System.Drawing.Size(14, 16);
            this.lblDefenceBonus.TabIndex = 9;
            this.lblDefenceBonus.Text = "0";
            // 
            // pbDefenceBonus
            // 
            this.pbDefenceBonus.BackColor = System.Drawing.Color.Transparent;
            this.pbDefenceBonus.Location = new System.Drawing.Point(203, 4);
            this.pbDefenceBonus.Name = "pbDefenceBonus";
            this.pbDefenceBonus.Size = new System.Drawing.Size(16, 16);
            this.pbDefenceBonus.TabIndex = 8;
            this.pbDefenceBonus.TabStop = false;
            // 
            // lblAttackBonus
            // 
            this.lblAttackBonus.AutoSize = true;
            this.lblAttackBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblAttackBonus.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.lblAttackBonus.ForeColor = System.Drawing.Color.Gold;
            this.lblAttackBonus.Location = new System.Drawing.Point(183, 4);
            this.lblAttackBonus.Name = "lblAttackBonus";
            this.lblAttackBonus.ShadowColor = System.Drawing.Color.Black;
            this.lblAttackBonus.Size = new System.Drawing.Size(14, 16);
            this.lblAttackBonus.TabIndex = 7;
            this.lblAttackBonus.Text = "0";
            // 
            // pbAttackBonus
            // 
            this.pbAttackBonus.BackColor = System.Drawing.Color.Transparent;
            this.pbAttackBonus.Location = new System.Drawing.Point(161, 4);
            this.pbAttackBonus.Name = "pbAttackBonus";
            this.pbAttackBonus.Size = new System.Drawing.Size(16, 16);
            this.pbAttackBonus.TabIndex = 6;
            this.pbAttackBonus.TabStop = false;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.lblMoney.ForeColor = System.Drawing.Color.Gold;
            this.lblMoney.Location = new System.Drawing.Point(108, 4);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.ShadowColor = System.Drawing.Color.Black;
            this.lblMoney.Size = new System.Drawing.Size(37, 16);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "0 (+0)";
            // 
            // pbMoney
            // 
            this.pbMoney.BackColor = System.Drawing.Color.Transparent;
            this.pbMoney.Location = new System.Drawing.Point(86, 4);
            this.pbMoney.Name = "pbMoney";
            this.pbMoney.Size = new System.Drawing.Size(16, 16);
            this.pbMoney.TabIndex = 4;
            this.pbMoney.TabStop = false;
            // 
            // lblTroops
            // 
            this.lblTroops.AutoSize = true;
            this.lblTroops.BackColor = System.Drawing.Color.Transparent;
            this.lblTroops.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.lblTroops.ForeColor = System.Drawing.Color.Gold;
            this.lblTroops.Location = new System.Drawing.Point(66, 4);
            this.lblTroops.Name = "lblTroops";
            this.lblTroops.ShadowColor = System.Drawing.Color.Black;
            this.lblTroops.Size = new System.Drawing.Size(14, 16);
            this.lblTroops.TabIndex = 3;
            this.lblTroops.Text = "0";
            // 
            // pbTroops
            // 
            this.pbTroops.BackColor = System.Drawing.Color.Transparent;
            this.pbTroops.Location = new System.Drawing.Point(44, 4);
            this.pbTroops.Name = "pbTroops";
            this.pbTroops.Size = new System.Drawing.Size(16, 16);
            this.pbTroops.TabIndex = 2;
            this.pbTroops.TabStop = false;
            // 
            // lblRegions
            // 
            this.lblRegions.AutoSize = true;
            this.lblRegions.BackColor = System.Drawing.Color.Transparent;
            this.lblRegions.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.lblRegions.ForeColor = System.Drawing.Color.Gold;
            this.lblRegions.Location = new System.Drawing.Point(24, 4);
            this.lblRegions.Name = "lblRegions";
            this.lblRegions.ShadowColor = System.Drawing.Color.Black;
            this.lblRegions.Size = new System.Drawing.Size(14, 16);
            this.lblRegions.TabIndex = 1;
            this.lblRegions.Text = "0";
            // 
            // pbRegions
            // 
            this.pbRegions.BackColor = System.Drawing.Color.Transparent;
            this.pbRegions.Location = new System.Drawing.Point(2, 4);
            this.pbRegions.Name = "pbRegions";
            this.pbRegions.Size = new System.Drawing.Size(16, 16);
            this.pbRegions.TabIndex = 0;
            this.pbRegions.TabStop = false;
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Controls.Add(this.btnBuild);
            this.Panel.Controls.Add(this.btnRecruit);
            this.Panel.Controls.Add(this.btnMenu);
            this.Panel.Controls.Add(this.lblPlayerName);
            this.Panel.Controls.Add(this.btnEndTurn);
            this.Panel.Controls.Add(this.btnScreenshot);
            this.Panel.Controls.Add(this.grpAutomation);
            this.Panel.Controls.Add(this.btnEconomy);
            this.Panel.Controls.Add(this.btnTurnReport);
            this.Panel.Controls.Add(this.btnRelations);
            this.Panel.Controls.Add(this.grpActions);
            this.Panel.Controls.Add(this.pbLogoPlayer);
            this.Panel.Controls.Add(this.lblTurn);
            this.Panel.Location = new System.Drawing.Point(669, 60);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(343, 528);
            this.Panel.TabIndex = 12;
            // 
            // btnBuild
            // 
            this.btnBuild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuild.AutoSizeBorder = true;
            this.btnBuild.BackColor = System.Drawing.Color.DarkRed;
            this.btnBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuild.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnBuild.BorderSize = 8;
            this.btnBuild.Clicked = false;
            this.btnBuild.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuild.ForeColor = System.Drawing.Color.Gold;
            this.btnBuild.Location = new System.Drawing.Point(174, 281);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Selected = false;
            this.btnBuild.ShadowColor = System.Drawing.Color.Black;
            this.btnBuild.Size = new System.Drawing.Size(96, 32);
            this.btnBuild.TabIndex = 24;
            this.btnBuild.Text = "Build";
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnRecruit
            // 
            this.btnRecruit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecruit.AutoSizeBorder = true;
            this.btnRecruit.BackColor = System.Drawing.Color.DarkRed;
            this.btnRecruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecruit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnRecruit.BorderSize = 8;
            this.btnRecruit.Clicked = false;
            this.btnRecruit.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnRecruit.ForeColor = System.Drawing.Color.Gold;
            this.btnRecruit.Location = new System.Drawing.Point(72, 281);
            this.btnRecruit.Name = "btnRecruit";
            this.btnRecruit.Selected = false;
            this.btnRecruit.ShadowColor = System.Drawing.Color.Black;
            this.btnRecruit.Size = new System.Drawing.Size(96, 32);
            this.btnRecruit.TabIndex = 22;
            this.btnRecruit.Text = "Recruit";
            this.btnRecruit.Click += new System.EventHandler(this.btnRecruit_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenu.AutoSizeBorder = true;
            this.btnMenu.BackColor = System.Drawing.Color.DarkRed;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnMenu.BorderSize = 8;
            this.btnMenu.Clicked = false;
            this.btnMenu.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.Gold;
            this.btnMenu.Location = new System.Drawing.Point(131, 404);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Selected = false;
            this.btnMenu.ShadowColor = System.Drawing.Color.Black;
            this.btnMenu.Size = new System.Drawing.Size(80, 24);
            this.btnMenu.TabIndex = 23;
            this.btnMenu.Text = "Menu";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayerName.Location = new System.Drawing.Point(6, 1);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.ShadowColor = System.Drawing.Color.Black;
            this.lblPlayerName.Size = new System.Drawing.Size(166, 28);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "<FactionName>";
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEndTurn.AutoSizeBorder = true;
            this.btnEndTurn.BackColor = System.Drawing.Color.DarkRed;
            this.btnEndTurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEndTurn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnEndTurn.BorderSize = 8;
            this.btnEndTurn.Clicked = false;
            this.btnEndTurn.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.btnEndTurn.ForeColor = System.Drawing.Color.Gold;
            this.btnEndTurn.Location = new System.Drawing.Point(18, 466);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Selected = false;
            this.btnEndTurn.ShadowColor = System.Drawing.Color.Black;
            this.btnEndTurn.Size = new System.Drawing.Size(307, 48);
            this.btnEndTurn.TabIndex = 7;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScreenshot.AutoSizeBorder = true;
            this.btnScreenshot.BackColor = System.Drawing.Color.DarkRed;
            this.btnScreenshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScreenshot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnScreenshot.BorderSize = 8;
            this.btnScreenshot.Clicked = false;
            this.btnScreenshot.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnScreenshot.ForeColor = System.Drawing.Color.Gold;
            this.btnScreenshot.Location = new System.Drawing.Point(174, 344);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Selected = false;
            this.btnScreenshot.ShadowColor = System.Drawing.Color.Black;
            this.btnScreenshot.Size = new System.Drawing.Size(80, 24);
            this.btnScreenshot.TabIndex = 19;
            this.btnScreenshot.Text = "Screenshot";
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // grpAutomation
            // 
            this.grpAutomation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpAutomation.BackColor = System.Drawing.Color.Transparent;
            this.grpAutomation.BorderColor = System.Drawing.Color.DarkRed;
            this.grpAutomation.Controls.Add(this.chkAutoRecruit);
            this.grpAutomation.Controls.Add(this.chkAutoBuild);
            this.grpAutomation.Controls.Add(this.chkDeclineLiberations);
            this.grpAutomation.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpAutomation.ForeColor = System.Drawing.Color.Gold;
            this.grpAutomation.Location = new System.Drawing.Point(138, 157);
            this.grpAutomation.Name = "grpAutomation";
            this.grpAutomation.ShadowColor = System.Drawing.Color.Black;
            this.grpAutomation.Size = new System.Drawing.Size(158, 96);
            this.grpAutomation.TabIndex = 4;
            this.grpAutomation.TabStop = false;
            this.grpAutomation.Text = "Automation";
            this.grpAutomation.TextPosition = Narivia.CustomGroupBoxTextPosition.Left;
            // 
            // chkAutoRecruit
            // 
            this.chkAutoRecruit.AutoSize = true;
            this.chkAutoRecruit.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoRecruit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.chkAutoRecruit.BoxColor = System.Drawing.Color.DarkRed;
            this.chkAutoRecruit.Clicked = false;
            this.chkAutoRecruit.ClickSound = true;
            this.chkAutoRecruit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoRecruit.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkAutoRecruit.ForeColor = System.Drawing.Color.Gold;
            this.chkAutoRecruit.Location = new System.Drawing.Point(6, 68);
            this.chkAutoRecruit.Name = "chkAutoRecruit";
            this.chkAutoRecruit.Selected = false;
            this.chkAutoRecruit.Size = new System.Drawing.Size(99, 22);
            this.chkAutoRecruit.TabIndex = 2;
            this.chkAutoRecruit.Text = "Auto Recruit";
            this.chkAutoRecruit.UseVisualStyleBackColor = true;
            // 
            // chkAutoBuild
            // 
            this.chkAutoBuild.AutoSize = true;
            this.chkAutoBuild.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoBuild.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.chkAutoBuild.BoxColor = System.Drawing.Color.DarkRed;
            this.chkAutoBuild.Clicked = false;
            this.chkAutoBuild.ClickSound = true;
            this.chkAutoBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoBuild.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkAutoBuild.ForeColor = System.Drawing.Color.Gold;
            this.chkAutoBuild.Location = new System.Drawing.Point(6, 45);
            this.chkAutoBuild.Name = "chkAutoBuild";
            this.chkAutoBuild.Selected = false;
            this.chkAutoBuild.Size = new System.Drawing.Size(89, 22);
            this.chkAutoBuild.TabIndex = 1;
            this.chkAutoBuild.Text = "Auto Build";
            this.chkAutoBuild.UseVisualStyleBackColor = true;
            // 
            // chkDeclineLiberations
            // 
            this.chkDeclineLiberations.AutoSize = true;
            this.chkDeclineLiberations.BackColor = System.Drawing.Color.Transparent;
            this.chkDeclineLiberations.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.chkDeclineLiberations.BoxColor = System.Drawing.Color.DarkRed;
            this.chkDeclineLiberations.Checked = true;
            this.chkDeclineLiberations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeclineLiberations.Clicked = false;
            this.chkDeclineLiberations.ClickSound = true;
            this.chkDeclineLiberations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDeclineLiberations.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkDeclineLiberations.ForeColor = System.Drawing.Color.Gold;
            this.chkDeclineLiberations.Location = new System.Drawing.Point(6, 21);
            this.chkDeclineLiberations.Name = "chkDeclineLiberations";
            this.chkDeclineLiberations.Selected = false;
            this.chkDeclineLiberations.Size = new System.Drawing.Size(143, 22);
            this.chkDeclineLiberations.TabIndex = 0;
            this.chkDeclineLiberations.Text = "Decline Liberations";
            this.chkDeclineLiberations.UseVisualStyleBackColor = true;
            // 
            // btnEconomy
            // 
            this.btnEconomy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEconomy.AutoSizeBorder = true;
            this.btnEconomy.BackColor = System.Drawing.Color.DarkRed;
            this.btnEconomy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEconomy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnEconomy.BorderSize = 8;
            this.btnEconomy.Clicked = false;
            this.btnEconomy.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnEconomy.ForeColor = System.Drawing.Color.Gold;
            this.btnEconomy.Location = new System.Drawing.Point(174, 374);
            this.btnEconomy.Name = "btnEconomy";
            this.btnEconomy.Selected = false;
            this.btnEconomy.ShadowColor = System.Drawing.Color.Black;
            this.btnEconomy.Size = new System.Drawing.Size(80, 24);
            this.btnEconomy.TabIndex = 18;
            this.btnEconomy.Text = "Economy";
            this.btnEconomy.Click += new System.EventHandler(this.btnEconomy_Click);
            // 
            // btnTurnReport
            // 
            this.btnTurnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTurnReport.AutoSizeBorder = true;
            this.btnTurnReport.BackColor = System.Drawing.Color.DarkRed;
            this.btnTurnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurnReport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnTurnReport.BorderSize = 8;
            this.btnTurnReport.Clicked = false;
            this.btnTurnReport.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnTurnReport.ForeColor = System.Drawing.Color.Gold;
            this.btnTurnReport.Location = new System.Drawing.Point(88, 344);
            this.btnTurnReport.Name = "btnTurnReport";
            this.btnTurnReport.Selected = false;
            this.btnTurnReport.ShadowColor = System.Drawing.Color.Black;
            this.btnTurnReport.Size = new System.Drawing.Size(80, 24);
            this.btnTurnReport.TabIndex = 15;
            this.btnTurnReport.Text = "Turn Report";
            this.btnTurnReport.Click += new System.EventHandler(this.btnTurnReport_Click);
            // 
            // btnRelations
            // 
            this.btnRelations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRelations.AutoSizeBorder = true;
            this.btnRelations.BackColor = System.Drawing.Color.DarkRed;
            this.btnRelations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelations.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnRelations.BorderSize = 8;
            this.btnRelations.Clicked = false;
            this.btnRelations.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnRelations.ForeColor = System.Drawing.Color.Gold;
            this.btnRelations.Location = new System.Drawing.Point(88, 374);
            this.btnRelations.Name = "btnRelations";
            this.btnRelations.Selected = false;
            this.btnRelations.ShadowColor = System.Drawing.Color.Black;
            this.btnRelations.Size = new System.Drawing.Size(80, 24);
            this.btnRelations.TabIndex = 17;
            this.btnRelations.Text = "Relations";
            this.btnRelations.Click += new System.EventHandler(this.btnRelations_Click);
            // 
            // grpActions
            // 
            this.grpActions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpActions.BackColor = System.Drawing.Color.Transparent;
            this.grpActions.BorderColor = System.Drawing.Color.DarkRed;
            this.grpActions.Controls.Add(this.chkSpy);
            this.grpActions.Controls.Add(this.chkSelect);
            this.grpActions.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold);
            this.grpActions.ForeColor = System.Drawing.Color.Gold;
            this.grpActions.Location = new System.Drawing.Point(46, 157);
            this.grpActions.Name = "grpActions";
            this.grpActions.ShadowColor = System.Drawing.Color.Black;
            this.grpActions.Size = new System.Drawing.Size(86, 96);
            this.grpActions.TabIndex = 3;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            this.grpActions.TextPosition = Narivia.CustomGroupBoxTextPosition.Left;
            // 
            // chkSpy
            // 
            this.chkSpy.AutoSize = true;
            this.chkSpy.BackColor = System.Drawing.Color.Transparent;
            this.chkSpy.BoxColor = System.Drawing.Color.DarkRed;
            this.chkSpy.ClickSound = true;
            this.chkSpy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSpy.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkSpy.ForeColor = System.Drawing.Color.Gold;
            this.chkSpy.Location = new System.Drawing.Point(6, 45);
            this.chkSpy.Name = "chkSpy";
            this.chkSpy.Size = new System.Drawing.Size(48, 22);
            this.chkSpy.TabIndex = 1;
            this.chkSpy.Text = "Spy";
            this.chkSpy.UseVisualStyleBackColor = true;
            this.chkSpy.CheckedChanged += new System.EventHandler(this.chkSpy_CheckedChanged);
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.BackColor = System.Drawing.Color.Transparent;
            this.chkSelect.BoxColor = System.Drawing.Color.DarkRed;
            this.chkSelect.Checked = true;
            this.chkSelect.ClickSound = true;
            this.chkSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSelect.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkSelect.ForeColor = System.Drawing.Color.Gold;
            this.chkSelect.Location = new System.Drawing.Point(6, 19);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(61, 22);
            this.chkSelect.TabIndex = 0;
            this.chkSelect.TabStop = true;
            this.chkSelect.Text = "Select";
            this.chkSelect.UseVisualStyleBackColor = true;
            this.chkSelect.CheckedChanged += new System.EventHandler(this.chkAttack_CheckedChanged);
            // 
            // pbLogoPlayer
            // 
            this.pbLogoPlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogoPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbLogoPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogoPlayer.Location = new System.Drawing.Point(121, 32);
            this.pbLogoPlayer.MaximumSize = new System.Drawing.Size(128, 128);
            this.pbLogoPlayer.Name = "pbLogoPlayer";
            this.pbLogoPlayer.Size = new System.Drawing.Size(100, 100);
            this.pbLogoPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoPlayer.TabIndex = 13;
            this.pbLogoPlayer.TabStop = false;
            // 
            // lblTurn
            // 
            this.lblTurn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTurn.ForeColor = System.Drawing.Color.Gold;
            this.lblTurn.Location = new System.Drawing.Point(6, 3);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.ShadowColor = System.Drawing.Color.Black;
            this.lblTurn.Size = new System.Drawing.Size(325, 26);
            this.lblTurn.TabIndex = 10;
            this.lblTurn.Text = "Turn: 0";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = true;
            this.ClientSize = new System.Drawing.Size(1016, 676);
            this.Controls.Add(this.NoticeBoard);
            this.Controls.Add(this.RegionBar);
            this.Controls.Add(this.BuildingsPanel);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.separatorH1);
            this.Controls.Add(this.separatorV1);
            this.Controls.Add(this.InfoBar);
            this.Controls.Add(this.Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(774, 630);
            this.Name = "frmGame";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Text = "Narivia";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGame_KeyDown);
            this.Resize += new System.EventHandler(this.frmGame_Resize);
            this.Controls.SetChildIndex(this.Panel, 0);
            this.Controls.SetChildIndex(this.InfoBar, 0);
            this.Controls.SetChildIndex(this.separatorV1, 0);
            this.Controls.SetChildIndex(this.separatorH1, 0);
            this.Controls.SetChildIndex(this.pnlMap, 0);
            this.Controls.SetChildIndex(this.Console, 0);
            this.Controls.SetChildIndex(this.BuildingsPanel, 0);
            this.Controls.SetChildIndex(this.RegionBar, 0);
            this.Controls.SetChildIndex(this.NoticeBoard, 0);
            this.pnlMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            this.InfoBar.ResumeLayout(false);
            this.InfoBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecruitmentBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefenceBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttackBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTroops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegions)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.grpAutomation.ResumeLayout(false);
            this.grpAutomation.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Map;
        internal System.Windows.Forms.Panel Panel;
        internal CustomLabel lblPlayerName;
        internal CustomLabel lblTurn;
        internal CustomGroupBox grpActions;
        internal CustomRadioButton chkSpy;
        internal CustomRadioButton chkSelect;
        private System.Windows.Forms.PictureBox pbLogoPlayer;
        private NoticeBoard NoticeBoard;
        private CustomButton btnTurnReport;
        private CustomButton btnRelations;
        private CustomButton btnEconomy;
        private CustomButton btnScreenshot;
        internal CustomGroupBox grpAutomation;
        private CustomCheckBox chkDeclineLiberations;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.Panel InfoBar;
        private CustomLabel lblDefenceBonus;
        private System.Windows.Forms.PictureBox pbDefenceBonus;
        private CustomLabel lblAttackBonus;
        private System.Windows.Forms.PictureBox pbAttackBonus;
        private CustomLabel lblMoney;
        private System.Windows.Forms.PictureBox pbMoney;
        private CustomLabel lblTroops;
        private System.Windows.Forms.PictureBox pbTroops;
        private CustomLabel lblRegions;
        private System.Windows.Forms.PictureBox pbRegions;
        private CustomLabel lblRecruitmentBonus;
        private System.Windows.Forms.PictureBox pbRecruitmentBonus;
        private CustomPanel separatorV1;
        private CustomPanel separatorH1;
        private System.Windows.Forms.Panel pnlMap;
        private CustomCheckBox chkAutoBuild;
        private CustomButton btnEndTurn;
        private BuildingsPanel BuildingsPanel;
        private RegionBar RegionBar;
        private CustomButton btnMenu;
        private CustomCheckBox chkAutoRecruit;
        private CustomButton btnRecruit;
        private CustomButton btnBuild;
    }
}