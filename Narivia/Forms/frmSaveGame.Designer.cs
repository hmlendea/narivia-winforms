namespace Narivia
{
    partial class frmSaveGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaveGame));
            this.btnSave = new Narivia.CustomButton();
            this.btnBack = new Narivia.CustomButton();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
           this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Gold;
            this.btnSave.Location = new System.Drawing.Point(438, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(80, 24);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //Appearance.BorderSize = 0;
            //Style = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.Gold;
            this.btnBack.Location = new System.Drawing.Point(12, 114);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(80, 24);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            //StyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSave
            // 
            this.txtSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSave.BackColor = System.Drawing.Color.DarkRed;
            this.txtSave.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSave.ForeColor = System.Drawing.Color.Gold;
            this.txtSave.Location = new System.Drawing.Point(12, 65);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(506, 25);
            this.txtSave.TabIndex = 15;
            // 
            // frmSaveGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = true;
            this.ClientSize = new System.Drawing.Size(530, 150);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(360, 150);
            this.Name = "frmSaveGame";
            this.Text = "Narivia - Save Game";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.txtSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton btnSave;
        private CustomButton btnBack;
        private System.Windows.Forms.TextBox txtSave;
    }
}