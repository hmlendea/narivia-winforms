namespace Narivia
{
    partial class frmNewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewGame));
            this.grpMap = new Narivia.CustomGroupBox();
            this.prgMapLoading = new Narivia.CustomProgressBar();
            this.lblMap = new Narivia.CustomLabel();
            this.grpFaction = new Narivia.CustomGroupBox();
            this.grpAbility = new Narivia.CustomGroupBox();
            this.lblAbilityDetails = new Narivia.CustomLabel();
            this.grpDescription = new Narivia.CustomGroupBox();
            this.pnlFactionDescription = new System.Windows.Forms.Panel();
            this.lblFactionDescription = new Narivia.CustomLabel();
            this.cmbFaction = new Narivia.CustomComboBox();
            this.pbFaction = new System.Windows.Forms.PictureBox();
            this.grpGameRules = new Narivia.CustomGroupBox();
            this.chkHomelandPriority = new Narivia.CustomCheckBox();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.cmbMap = new Narivia.CustomComboBox();
            this.pbNarivia = new System.Windows.Forms.PictureBox();
            this.btnBack = new Narivia.CustomButton();
            this.btnPlay = new Narivia.CustomButton();
            this.toolTip = new Narivia.CustomToolTip();
            this.btnDownloadMaps = new Narivia.CustomButton();
            this.grpMap.SuspendLayout();
            this.grpFaction.SuspendLayout();
            this.grpAbility.SuspendLayout();
            this.grpDescription.SuspendLayout();
            this.pnlFactionDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFaction)).BeginInit();
            this.grpGameRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNarivia)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMap
            // 
            this.grpMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMap.BackColor = System.Drawing.Color.Transparent;
            this.grpMap.BorderColor = System.Drawing.Color.DarkRed;
            this.grpMap.Controls.Add(this.prgMapLoading);
            this.grpMap.Controls.Add(this.lblMap);
            this.grpMap.Controls.Add(this.grpFaction);
            this.grpMap.Controls.Add(this.grpGameRules);
            this.grpMap.Controls.Add(this.pbMap);
            this.grpMap.Controls.Add(this.cmbMap);
            this.grpMap.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpMap.ForeColor = System.Drawing.Color.Gold;
            this.grpMap.Location = new System.Drawing.Point(12, 104);
            this.grpMap.Name = "grpMap";
            this.grpMap.ShadowColor = System.Drawing.Color.Black;
            this.grpMap.Size = new System.Drawing.Size(656, 510);
            this.grpMap.TabIndex = 5;
            this.grpMap.TabStop = false;
            this.grpMap.Text = "Map Selection";
            this.grpMap.TextPosition = Narivia.CustomGroupBoxTextPosition.Center;
            // 
            // prgMapLoading
            // 
            this.prgMapLoading.AutoSizeBorder = true;
            this.prgMapLoading.BackColor = System.Drawing.Color.DarkRed;
            this.prgMapLoading.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.prgMapLoading.BorderSize = 6;
            this.prgMapLoading.FillColor = System.Drawing.Color.Gold;
            this.prgMapLoading.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.prgMapLoading.ForeColor = System.Drawing.Color.Gold;
            this.prgMapLoading.Location = new System.Drawing.Point(13, 188);
            this.prgMapLoading.Name = "prgMapLoading";
            this.prgMapLoading.Size = new System.Drawing.Size(274, 23);
            this.prgMapLoading.TabIndex = 12;
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.BackColor = System.Drawing.Color.Transparent;
            this.lblMap.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMap.ForeColor = System.Drawing.Color.Gold;
            this.lblMap.Location = new System.Drawing.Point(6, 30);
            this.lblMap.Name = "lblMap";
            this.lblMap.ShadowColor = System.Drawing.Color.Black;
            this.lblMap.Size = new System.Drawing.Size(40, 18);
            this.lblMap.TabIndex = 4;
            this.lblMap.Text = "Map:";
            // 
            // grpFaction
            // 
            this.grpFaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFaction.BackColor = System.Drawing.Color.Transparent;
            this.grpFaction.BorderColor = System.Drawing.Color.DarkRed;
            this.grpFaction.Controls.Add(this.grpAbility);
            this.grpFaction.Controls.Add(this.grpDescription);
            this.grpFaction.Controls.Add(this.cmbFaction);
            this.grpFaction.Controls.Add(this.pbFaction);
            this.grpFaction.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpFaction.ForeColor = System.Drawing.Color.Gold;
            this.grpFaction.Location = new System.Drawing.Point(297, 27);
            this.grpFaction.Name = "grpFaction";
            this.grpFaction.ShadowColor = System.Drawing.Color.Black;
            this.grpFaction.Size = new System.Drawing.Size(353, 477);
            this.grpFaction.TabIndex = 11;
            this.grpFaction.TabStop = false;
            this.grpFaction.Text = "Faction";
            this.grpFaction.TextPosition = Narivia.CustomGroupBoxTextPosition.Left;
            // 
            // grpAbility
            // 
            this.grpAbility.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAbility.BackColor = System.Drawing.Color.Transparent;
            this.grpAbility.BorderColor = System.Drawing.Color.DarkRed;
            this.grpAbility.Controls.Add(this.lblAbilityDetails);
            this.grpAbility.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpAbility.ForeColor = System.Drawing.Color.Gold;
            this.grpAbility.Location = new System.Drawing.Point(6, 64);
            this.grpAbility.Name = "grpAbility";
            this.grpAbility.ShadowColor = System.Drawing.Color.Black;
            this.grpAbility.Size = new System.Drawing.Size(207, 96);
            this.grpAbility.TabIndex = 11;
            this.grpAbility.TabStop = false;
            this.grpAbility.Text = "Ability";
            this.grpAbility.TextPosition = Narivia.CustomGroupBoxTextPosition.Left;
            // 
            // lblAbilityDetails
            // 
            this.lblAbilityDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAbilityDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblAbilityDetails.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAbilityDetails.ForeColor = System.Drawing.Color.Gold;
            this.lblAbilityDetails.Location = new System.Drawing.Point(6, 19);
            this.lblAbilityDetails.Name = "lblAbilityDetails";
            this.lblAbilityDetails.ShadowColor = System.Drawing.Color.Black;
            this.lblAbilityDetails.Size = new System.Drawing.Size(195, 71);
            this.lblAbilityDetails.TabIndex = 9;
            this.lblAbilityDetails.Text = "...";
            // 
            // grpDescription
            // 
            this.grpDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDescription.BackColor = System.Drawing.Color.Transparent;
            this.grpDescription.BorderColor = System.Drawing.Color.DarkRed;
            this.grpDescription.Controls.Add(this.pnlFactionDescription);
            this.grpDescription.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpDescription.ForeColor = System.Drawing.Color.Gold;
            this.grpDescription.Location = new System.Drawing.Point(6, 166);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.ShadowColor = System.Drawing.Color.Black;
            this.grpDescription.Size = new System.Drawing.Size(341, 305);
            this.grpDescription.TabIndex = 10;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Description";
            this.grpDescription.TextPosition = Narivia.CustomGroupBoxTextPosition.Left;
            // 
            // pnlFactionDescription
            // 
            this.pnlFactionDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFactionDescription.AutoScroll = true;
            this.pnlFactionDescription.Controls.Add(this.lblFactionDescription);
            this.pnlFactionDescription.Location = new System.Drawing.Point(6, 24);
            this.pnlFactionDescription.Name = "pnlFactionDescription";
            this.pnlFactionDescription.Size = new System.Drawing.Size(329, 275);
            this.pnlFactionDescription.TabIndex = 0;
            this.pnlFactionDescription.Resize += new System.EventHandler(this.pnlFactionDescription_Resize);
            // 
            // lblFactionDescription
            // 
            this.lblFactionDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFactionDescription.AutoSize = true;
            this.lblFactionDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblFactionDescription.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFactionDescription.ForeColor = System.Drawing.Color.Gold;
            this.lblFactionDescription.Location = new System.Drawing.Point(0, 0);
            this.lblFactionDescription.MaximumSize = new System.Drawing.Size(256, 0);
            this.lblFactionDescription.Name = "lblFactionDescription";
            this.lblFactionDescription.ShadowColor = System.Drawing.Color.Black;
            this.lblFactionDescription.Size = new System.Drawing.Size(20, 18);
            this.lblFactionDescription.TabIndex = 9;
            this.lblFactionDescription.Text = "...";
            // 
            // cmbFaction
            // 
            this.cmbFaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFaction.BackColor = System.Drawing.Color.DarkRed;
            this.cmbFaction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.cmbFaction.BorderSize = 4;
            this.cmbFaction.Clicked = false;
            this.cmbFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFaction.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbFaction.ForeColor = System.Drawing.Color.Gold;
            this.cmbFaction.FormattingEnabled = true;
            this.cmbFaction.Location = new System.Drawing.Point(6, 32);
            this.cmbFaction.Name = "cmbFaction";
            this.cmbFaction.Selected = false;
            this.cmbFaction.ShadowColor = System.Drawing.Color.Black;
            this.cmbFaction.Size = new System.Drawing.Size(207, 26);
            this.cmbFaction.TabIndex = 6;
            this.cmbFaction.SelectedIndexChanged += new System.EventHandler(this.cmbFaction_SelectedIndexChanged);
            // 
            // pbFaction
            // 
            this.pbFaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFaction.BackColor = System.Drawing.Color.DarkRed;
            this.pbFaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbFaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFaction.Location = new System.Drawing.Point(219, 32);
            this.pbFaction.Name = "pbFaction";
            this.pbFaction.Size = new System.Drawing.Size(128, 128);
            this.pbFaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFaction.TabIndex = 8;
            this.pbFaction.TabStop = false;
            // 
            // grpGameRules
            // 
            this.grpGameRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpGameRules.BackColor = System.Drawing.Color.Transparent;
            this.grpGameRules.BorderColor = System.Drawing.Color.DarkRed;
            this.grpGameRules.Controls.Add(this.chkHomelandPriority);
            this.grpGameRules.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpGameRules.ForeColor = System.Drawing.Color.Gold;
            this.grpGameRules.Location = new System.Drawing.Point(9, 347);
            this.grpGameRules.Name = "grpGameRules";
            this.grpGameRules.ShadowColor = System.Drawing.Color.Black;
            this.grpGameRules.Size = new System.Drawing.Size(282, 157);
            this.grpGameRules.TabIndex = 7;
            this.grpGameRules.TabStop = false;
            this.grpGameRules.Text = "Game Rules";
            this.grpGameRules.TextPosition = Narivia.CustomGroupBoxTextPosition.Left;
            // 
            // chkHomelandPriority
            // 
            this.chkHomelandPriority.AutoSize = true;
            this.chkHomelandPriority.BackColor = System.Drawing.Color.Transparent;
            this.chkHomelandPriority.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.chkHomelandPriority.BoxColor = System.Drawing.Color.DarkRed;
            this.chkHomelandPriority.Checked = true;
            this.chkHomelandPriority.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHomelandPriority.Clicked = false;
            this.chkHomelandPriority.ClickSound = true;
            this.chkHomelandPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHomelandPriority.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkHomelandPriority.ForeColor = System.Drawing.Color.Gold;
            this.chkHomelandPriority.Location = new System.Drawing.Point(6, 24);
            this.chkHomelandPriority.Name = "chkHomelandPriority";
            this.chkHomelandPriority.Selected = false;
            this.chkHomelandPriority.Size = new System.Drawing.Size(137, 22);
            this.chkHomelandPriority.TabIndex = 9;
            this.chkHomelandPriority.Text = "Homeland Priority";
            this.toolTip.SetToolTip(this.chkHomelandPriority, "Factions will try to liberate and build up their original regions");
            this.chkHomelandPriority.UseVisualStyleBackColor = false;
            // 
            // pbMap
            // 
            this.pbMap.BackColor = System.Drawing.Color.DarkRed;
            this.pbMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMap.Location = new System.Drawing.Point(9, 59);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(282, 282);
            this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMap.TabIndex = 7;
            this.pbMap.TabStop = false;
            // 
            // cmbMap
            // 
            this.cmbMap.BackColor = System.Drawing.Color.DarkRed;
            this.cmbMap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.cmbMap.BorderSize = 4;
            this.cmbMap.Clicked = false;
            this.cmbMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMap.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbMap.ForeColor = System.Drawing.Color.Gold;
            this.cmbMap.FormattingEnabled = true;
            this.cmbMap.Location = new System.Drawing.Point(72, 27);
            this.cmbMap.Name = "cmbMap";
            this.cmbMap.Selected = false;
            this.cmbMap.ShadowColor = System.Drawing.Color.Black;
            this.cmbMap.Size = new System.Drawing.Size(219, 26);
            this.cmbMap.TabIndex = 3;
            this.cmbMap.SelectedIndexChanged += new System.EventHandler(this.cmbMap_SelectedIndexChanged);
            // 
            // pbNarivia
            // 
            this.pbNarivia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbNarivia.BackColor = System.Drawing.Color.Transparent;
            this.pbNarivia.Location = new System.Drawing.Point(180, 42);
            this.pbNarivia.Name = "pbNarivia";
            this.pbNarivia.Size = new System.Drawing.Size(320, 56);
            this.pbNarivia.TabIndex = 9;
            this.pbNarivia.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.AutoSizeBorder = true;
            this.btnBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnBack.BorderSize = 8;
            this.btnBack.Clicked = false;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Gold;
            this.btnBack.Location = new System.Drawing.Point(12, 644);
            this.btnBack.Name = "btnBack";
            this.btnBack.Selected = false;
            this.btnBack.ShadowColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(123, 24);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.AutoSizeBorder = true;
            this.btnPlay.BackColor = System.Drawing.Color.DarkRed;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnPlay.BorderSize = 8;
            this.btnPlay.Clicked = false;
            this.btnPlay.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.Gold;
            this.btnPlay.Location = new System.Drawing.Point(309, 620);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Selected = false;
            this.btnPlay.ShadowColor = System.Drawing.Color.Black;
            this.btnPlay.Size = new System.Drawing.Size(359, 48);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.BackColor = System.Drawing.Color.DarkRed;
            this.toolTip.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.toolTip.ForeColor = System.Drawing.Color.Gold;
            this.toolTip.InitialDelay = 0;
            this.toolTip.Offset = 6;
            this.toolTip.OwnerDraw = true;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ShowAlways = true;
            this.toolTip.UseFading = false;
            // 
            // btnDownloadMaps
            // 
            this.btnDownloadMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownloadMaps.AutoSizeBorder = true;
            this.btnDownloadMaps.BackColor = System.Drawing.Color.DarkRed;
            this.btnDownloadMaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDownloadMaps.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnDownloadMaps.BorderSize = 8;
            this.btnDownloadMaps.Clicked = false;
            this.btnDownloadMaps.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnDownloadMaps.ForeColor = System.Drawing.Color.Gold;
            this.btnDownloadMaps.Location = new System.Drawing.Point(180, 644);
            this.btnDownloadMaps.Name = "btnDownloadMaps";
            this.btnDownloadMaps.Selected = false;
            this.btnDownloadMaps.ShadowColor = System.Drawing.Color.Black;
            this.btnDownloadMaps.Size = new System.Drawing.Size(123, 24);
            this.btnDownloadMaps.TabIndex = 11;
            this.btnDownloadMaps.Text = "Download maps";
            this.btnDownloadMaps.Click += new System.EventHandler(this.btnDownloadMaps_Click);
            // 
            // frmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = true;
            this.ClientSize = new System.Drawing.Size(680, 680);
            this.Controls.Add(this.btnDownloadMaps);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pbNarivia);
            this.Controls.Add(this.grpMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(680, 680);
            this.Name = "frmNewGame";
            this.Text = "Narivia - New Game";
            this.Load += new System.EventHandler(this.frmNewGame_Load);
            this.Controls.SetChildIndex(this.grpMap, 0);
            this.Controls.SetChildIndex(this.pbNarivia, 0);
            this.Controls.SetChildIndex(this.btnPlay, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnDownloadMaps, 0);
            this.grpMap.ResumeLayout(false);
            this.grpMap.PerformLayout();
            this.grpFaction.ResumeLayout(false);
            this.grpAbility.ResumeLayout(false);
            this.grpDescription.ResumeLayout(false);
            this.pnlFactionDescription.ResumeLayout(false);
            this.pnlFactionDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFaction)).EndInit();
            this.grpGameRules.ResumeLayout(false);
            this.grpGameRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNarivia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComboBox cmbMap;
        private CustomGroupBox grpMap;
        private System.Windows.Forms.PictureBox pbNarivia;
        private CustomLabel lblMap;
        private CustomComboBox cmbFaction;
        private CustomGroupBox grpGameRules;
        private System.Windows.Forms.PictureBox pbMap;
        private CustomButton btnPlay;
        private System.Windows.Forms.PictureBox pbFaction;
        private CustomToolTip toolTip;
        private CustomGroupBox grpFaction;
        private CustomLabel lblFactionDescription;
        private CustomGroupBox grpAbility;
        private CustomLabel lblAbilityDetails;
        private CustomGroupBox grpDescription;
        private System.Windows.Forms.Panel pnlFactionDescription;
        private CustomButton btnBack;
        private CustomCheckBox chkHomelandPriority;
        private CustomProgressBar prgMapLoading;
        private CustomButton btnDownloadMaps;
    }
}