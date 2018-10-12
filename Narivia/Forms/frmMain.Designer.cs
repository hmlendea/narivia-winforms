namespace Narivia
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblAuthor = new Narivia.CustomLabel();
            this.pbNarivia = new System.Windows.Forms.PictureBox();
            this.lblVersion = new Narivia.CustomLabel();
            this.btnLoadGame = new Narivia.CustomButton();
            this.btnUpdate = new Narivia.CustomButton();
            this.btnTutorial = new Narivia.CustomButton();
            this.btnExit = new Narivia.CustomButton();
            this.btnOptions = new Narivia.CustomButton();
            this.btnEditor = new Narivia.CustomButton();
            this.btnNewGame = new Narivia.CustomButton();
            this.btnMoreGames = new Narivia.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbNarivia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAuthor.ForeColor = System.Drawing.Color.Gold;
            this.lblAuthor.Location = new System.Drawing.Point(204, 517);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.ShadowColor = System.Drawing.Color.Black;
            this.lblAuthor.Size = new System.Drawing.Size(168, 18);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Made by Mlendea Horatiu";
            // 
            // pbNarivia
            // 
            this.pbNarivia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbNarivia.BackColor = System.Drawing.Color.Transparent;
            this.pbNarivia.Location = new System.Drawing.Point(32, 42);
            this.pbNarivia.Name = "pbNarivia";
            this.pbNarivia.Size = new System.Drawing.Size(320, 56);
            this.pbNarivia.TabIndex = 8;
            this.pbNarivia.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVersion.ForeColor = System.Drawing.Color.Gold;
            this.lblVersion.Location = new System.Drawing.Point(12, 517);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.ShadowColor = System.Drawing.Color.Black;
            this.lblVersion.Size = new System.Drawing.Size(62, 18);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "Version: ";
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoadGame.AutoSizeBorder = true;
            this.btnLoadGame.BackColor = System.Drawing.Color.DarkRed;
            this.btnLoadGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadGame.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnLoadGame.BorderSize = 8;
            this.btnLoadGame.Clicked = false;
            this.btnLoadGame.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.btnLoadGame.ForeColor = System.Drawing.Color.Gold;
            this.btnLoadGame.Location = new System.Drawing.Point(64, 158);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Selected = false;
            this.btnLoadGame.ShadowColor = System.Drawing.Color.Black;
            this.btnLoadGame.Size = new System.Drawing.Size(256, 48);
            this.btnLoadGame.TabIndex = 10;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.AutoSizeBorder = true;
            this.btnUpdate.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnUpdate.BorderSize = 8;
            this.btnUpdate.Clicked = false;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Gold;
            this.btnUpdate.Location = new System.Drawing.Point(12, 490);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Selected = false;
            this.btnUpdate.ShadowColor = System.Drawing.Color.Black;
            this.btnUpdate.Size = new System.Drawing.Size(80, 24);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTutorial
            // 
            this.btnTutorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTutorial.AutoSizeBorder = true;
            this.btnTutorial.BackColor = System.Drawing.Color.DarkRed;
            this.btnTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTutorial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnTutorial.BorderSize = 8;
            this.btnTutorial.Clicked = false;
            this.btnTutorial.Enabled = false;
            this.btnTutorial.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.btnTutorial.ForeColor = System.Drawing.Color.Gold;
            this.btnTutorial.Location = new System.Drawing.Point(64, 212);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Selected = false;
            this.btnTutorial.ShadowColor = System.Drawing.Color.Black;
            this.btnTutorial.Size = new System.Drawing.Size(256, 48);
            this.btnTutorial.TabIndex = 7;
            this.btnTutorial.Text = "Tutorial";
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.AutoSizeBorder = true;
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnExit.BorderSize = 8;
            this.btnExit.Clicked = false;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(64, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Selected = false;
            this.btnExit.ShadowColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(256, 48);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOptions.AutoSizeBorder = true;
            this.btnOptions.BackColor = System.Drawing.Color.DarkRed;
            this.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnOptions.BorderSize = 8;
            this.btnOptions.Clicked = false;
            this.btnOptions.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.btnOptions.ForeColor = System.Drawing.Color.Gold;
            this.btnOptions.Location = new System.Drawing.Point(64, 320);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Selected = false;
            this.btnOptions.ShadowColor = System.Drawing.Color.Black;
            this.btnOptions.Size = new System.Drawing.Size(256, 48);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnEditor
            // 
            this.btnEditor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditor.AutoSizeBorder = true;
            this.btnEditor.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnEditor.BorderSize = 8;
            this.btnEditor.Clicked = false;
            this.btnEditor.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.btnEditor.ForeColor = System.Drawing.Color.Gold;
            this.btnEditor.Location = new System.Drawing.Point(64, 266);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Selected = false;
            this.btnEditor.ShadowColor = System.Drawing.Color.Black;
            this.btnEditor.Size = new System.Drawing.Size(256, 48);
            this.btnEditor.TabIndex = 4;
            this.btnEditor.Text = "Map Editor";
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewGame.AutoSizeBorder = true;
            this.btnNewGame.BackColor = System.Drawing.Color.DarkRed;
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewGame.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnNewGame.BorderSize = 8;
            this.btnNewGame.Clicked = false;
           this.btnNewGame.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.ForeColor = System.Drawing.Color.Gold;
            this.btnNewGame.Location = new System.Drawing.Point(64, 104);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Selected = false;
            this.btnNewGame.ShadowColor = System.Drawing.Color.Black;
            this.btnNewGame.Size = new System.Drawing.Size(256, 48);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnMoreGames
            // 
            this.btnMoreGames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMoreGames.AutoSizeBorder = true;
            this.btnMoreGames.BackColor = System.Drawing.Color.DarkRed;
            this.btnMoreGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMoreGames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnMoreGames.BorderSize = 8;
            this.btnMoreGames.Clicked = false;
            this.btnMoreGames.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.btnMoreGames.ForeColor = System.Drawing.Color.Gold;
            this.btnMoreGames.Location = new System.Drawing.Point(64, 374);
            this.btnMoreGames.Name = "btnMoreGames";
            this.btnMoreGames.Selected = false;
            this.btnMoreGames.ShadowColor = System.Drawing.Color.Black;
            this.btnMoreGames.Size = new System.Drawing.Size(256, 48);
            this.btnMoreGames.TabIndex = 11;
            this.btnMoreGames.Text = "More Games";
            this.btnMoreGames.Click += new System.EventHandler(this.btnMoreGames_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = true;
            this.ClientSize = new System.Drawing.Size(384, 544);
            this.Controls.Add(this.btnMoreGames);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pbNarivia);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnEditor);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblAuthor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(384, 544);
            this.Name = "frmMain";
            this.Text = "Narivia";
            this.Controls.SetChildIndex(this.lblAuthor, 0);
            this.Controls.SetChildIndex(this.btnNewGame, 0);
            this.Controls.SetChildIndex(this.btnEditor, 0);
            this.Controls.SetChildIndex(this.btnOptions, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnTutorial, 0);
            this.Controls.SetChildIndex(this.pbNarivia, 0);
            this.Controls.SetChildIndex(this.lblVersion, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnLoadGame, 0);
            this.Controls.SetChildIndex(this.btnMoreGames, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbNarivia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomLabel lblAuthor;
        private CustomButton btnNewGame;
        private CustomButton btnEditor;
        private CustomButton btnOptions;
        private CustomButton btnExit;
        private CustomButton btnTutorial;
        private CustomButton btnUpdate;
        private System.Windows.Forms.PictureBox pbNarivia;
        private CustomLabel lblVersion;
        private CustomButton btnLoadGame;
        private CustomButton btnMoreGames;
    }
}

