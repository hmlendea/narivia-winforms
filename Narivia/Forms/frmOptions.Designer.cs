namespace Narivia
{
    partial class frmOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.pbNarivia = new System.Windows.Forms.PictureBox();
            this.lblPlayerName = new Narivia.CustomLabel();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnRestore = new Narivia.CustomButton();
            this.btnSave = new Narivia.CustomButton();
            this.chkSound = new Narivia.CustomCheckBox();
            this.trkSoundVolume = new System.Windows.Forms.TrackBar();
            this.chkFullScreen = new Narivia.CustomCheckBox();
            this.btnBack = new Narivia.CustomButton();
            this.chkAutoSave = new Narivia.CustomCheckBox();
            this.chkMapOverlay = new Narivia.CustomCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNarivia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSoundVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNarivia
            // 
            this.pbNarivia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbNarivia.BackColor = System.Drawing.Color.Transparent;
            this.pbNarivia.Location = new System.Drawing.Point(20, 51);
            this.pbNarivia.Name = "pbNarivia";
            this.pbNarivia.Size = new System.Drawing.Size(320, 56);
            this.pbNarivia.TabIndex = 9;
            this.pbNarivia.TabStop = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPlayerName.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayerName.Location = new System.Drawing.Point(12, 126);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.ShadowColor = System.Drawing.Color.Black;
            this.lblPlayerName.Size = new System.Drawing.Size(90, 18);
            this.lblPlayerName.TabIndex = 10;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlayerName.BackColor = System.Drawing.Color.DarkRed;
            this.txtPlayerName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPlayerName.ForeColor = System.Drawing.Color.Gold;
            this.txtPlayerName.Location = new System.Drawing.Point(108, 123);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(240, 25);
            this.txtPlayerName.TabIndex = 11;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.AutoSizeBorder = true;
            this.btnRestore.BackColor = System.Drawing.Color.DarkRed;
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnRestore.BorderSize = 8;
            this.btnRestore.Clicked = false;
            this.btnRestore.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.Gold;
            this.btnRestore.Location = new System.Drawing.Point(268, 264);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Selected = false;
            this.btnRestore.ShadowColor = System.Drawing.Color.Black;
            this.btnRestore.Size = new System.Drawing.Size(80, 24);
            this.btnRestore.TabIndex = 13;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSizeBorder = true;
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnSave.BorderSize = 8;
            this.btnSave.Clicked = false;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Gold;
            this.btnSave.Location = new System.Drawing.Point(182, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Selected = false;
            this.btnSave.ShadowColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(80, 24);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkSound
            // 
            this.chkSound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkSound.AutoSize = true;
            this.chkSound.BackColor = System.Drawing.Color.Transparent;
            this.chkSound.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.chkSound.BoxColor = System.Drawing.Color.DarkRed;
            this.chkSound.Checked = true;
            this.chkSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSound.Clicked = false;
            this.chkSound.ClickSound = true;
            this.chkSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSound.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkSound.ForeColor = System.Drawing.Color.Gold;
            this.chkSound.Location = new System.Drawing.Point(15, 154);
            this.chkSound.Name = "chkSound";
            this.chkSound.Selected = false;
            this.chkSound.Size = new System.Drawing.Size(64, 22);
            this.chkSound.TabIndex = 0;
            this.chkSound.Text = "Sound";
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // trkSoundVolume
            // 
            this.trkSoundVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trkSoundVolume.BackColor = System.Drawing.Color.DarkRed;
            this.trkSoundVolume.Location = new System.Drawing.Point(108, 154);
            this.trkSoundVolume.Maximum = 100;
            this.trkSoundVolume.Name = "trkSoundVolume";
            this.trkSoundVolume.Size = new System.Drawing.Size(240, 45);
            this.trkSoundVolume.TabIndex = 14;
            this.trkSoundVolume.TickFrequency = 5;
            this.trkSoundVolume.Value = 80;
            this.trkSoundVolume.Scroll += new System.EventHandler(this.trkSoundVolume_Scroll);
            // 
            // chkFullScreen
            // 
            this.chkFullScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkFullScreen.AutoSize = true;
            this.chkFullScreen.BackColor = System.Drawing.Color.Transparent;
            this.chkFullScreen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.chkFullScreen.BoxColor = System.Drawing.Color.DarkRed;
            this.chkFullScreen.Checked = true;
            this.chkFullScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFullScreen.Clicked = false;
            this.chkFullScreen.ClickSound = true;
            this.chkFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFullScreen.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkFullScreen.ForeColor = System.Drawing.Color.Gold;
            this.chkFullScreen.Location = new System.Drawing.Point(15, 205);
            this.chkFullScreen.Name = "chkFullScreen";
            this.chkFullScreen.Selected = false;
            this.chkFullScreen.Size = new System.Drawing.Size(183, 22);
            this.chkFullScreen.TabIndex = 15;
            this.chkFullScreen.Text = "Full Screen (Experimental)";
            this.chkFullScreen.UseVisualStyleBackColor = true;
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
            this.btnBack.Location = new System.Drawing.Point(12, 264);
            this.btnBack.Name = "btnBack";
            this.btnBack.Selected = false;
            this.btnBack.ShadowColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(80, 24);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.chkAutoSave.BoxColor = System.Drawing.Color.DarkRed;
            this.chkAutoSave.Checked = true;
            this.chkAutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoSave.Clicked = false;
            this.chkAutoSave.ClickSound = true;
            this.chkAutoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoSave.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkAutoSave.ForeColor = System.Drawing.Color.Gold;
            this.chkAutoSave.Location = new System.Drawing.Point(15, 233);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.Selected = false;
            this.chkAutoSave.Size = new System.Drawing.Size(82, 22);
            this.chkAutoSave.TabIndex = 17;
            this.chkAutoSave.Text = "AutoSave";
            this.chkAutoSave.UseVisualStyleBackColor = true;
            // 
            // chkMapOverlay
            // 
            this.chkMapOverlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkMapOverlay.AutoSize = true;
            this.chkMapOverlay.BackColor = System.Drawing.Color.Transparent;
            this.chkMapOverlay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.chkMapOverlay.BoxColor = System.Drawing.Color.DarkRed;
            this.chkMapOverlay.Checked = true;
            this.chkMapOverlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMapOverlay.Clicked = false;
            this.chkMapOverlay.ClickSound = true;
            this.chkMapOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMapOverlay.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.chkMapOverlay.ForeColor = System.Drawing.Color.Gold;
            this.chkMapOverlay.Location = new System.Drawing.Point(108, 233);
            this.chkMapOverlay.Name = "chkMapOverlay";
            this.chkMapOverlay.Selected = false;
            this.chkMapOverlay.Size = new System.Drawing.Size(103, 22);
            this.chkMapOverlay.TabIndex = 18;
            this.chkMapOverlay.Text = "Map Overlay";
            this.chkMapOverlay.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = true;
            this.ClientSize = new System.Drawing.Size(360, 300);
            this.Controls.Add(this.chkMapOverlay);
            this.Controls.Add(this.chkAutoSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkFullScreen);
            this.Controls.Add(this.trkSoundVolume);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pbNarivia);
            this.Controls.Add(this.chkSound);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(360, 300);
            this.Name = "frmOptions";
            this.Text = "Narivia - Options";
            this.Controls.SetChildIndex(this.chkSound, 0);
            this.Controls.SetChildIndex(this.pbNarivia, 0);
            this.Controls.SetChildIndex(this.lblPlayerName, 0);
            this.Controls.SetChildIndex(this.txtPlayerName, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnRestore, 0);
            this.Controls.SetChildIndex(this.trkSoundVolume, 0);
            this.Controls.SetChildIndex(this.chkFullScreen, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.chkAutoSave, 0);
            this.Controls.SetChildIndex(this.chkMapOverlay, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbNarivia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkSoundVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNarivia;
        private CustomLabel lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private CustomCheckBox chkSound;
        private CustomButton btnSave;
        private CustomButton btnRestore;
        private System.Windows.Forms.TrackBar trkSoundVolume;
        private CustomCheckBox chkFullScreen;
        private CustomButton btnBack;
        private CustomCheckBox chkAutoSave;
        private CustomCheckBox chkMapOverlay;
    }
}