namespace Narivia
{
    partial class frmDownloadMaps
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
            this.btnDownload = new Narivia.CustomButton();
            this.btnOpenFolder = new Narivia.CustomButton();
            this.pnlMapsBig = new Narivia.CustomPanel();
            this.pnlMaps = new System.Windows.Forms.Panel();
            this.btnCancel = new Narivia.CustomButton();
            this.btnRefresh = new Narivia.CustomButton();
            this.pnlMapsBig.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSizeBorder = true;
            this.btnDownload.BackColor = System.Drawing.Color.DarkRed;
            this.btnDownload.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnDownload.BorderSize = 8;
            this.btnDownload.Clicked = false;
            this.btnDownload.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDownload.ForeColor = System.Drawing.Color.Gold;
            this.btnDownload.Location = new System.Drawing.Point(111, 344);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Selected = false;
            this.btnDownload.ShadowColor = System.Drawing.Color.Black;
            this.btnDownload.Size = new System.Drawing.Size(96, 32);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.Visible = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.AutoSizeBorder = true;
            this.btnOpenFolder.BackColor = System.Drawing.Color.DarkRed;
            this.btnOpenFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnOpenFolder.BorderSize = 8;
            this.btnOpenFolder.Clicked = false;
            this.btnOpenFolder.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpenFolder.ForeColor = System.Drawing.Color.Gold;
            this.btnOpenFolder.Location = new System.Drawing.Point(9, 344);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Selected = false;
            this.btnOpenFolder.ShadowColor = System.Drawing.Color.Black;
            this.btnOpenFolder.Size = new System.Drawing.Size(96, 32);
            this.btnOpenFolder.TabIndex = 5;
            this.btnOpenFolder.Text = "Open folder";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // pnlMapsBig
            // 
            this.pnlMapsBig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMapsBig.BackColor = System.Drawing.Color.DarkRed;
            this.pnlMapsBig.Controls.Add(this.pnlMaps);
            this.pnlMapsBig.Font = new System.Drawing.Font("Palatino Linotype", 147F, System.Drawing.FontStyle.Bold);
            this.pnlMapsBig.ForeColor = System.Drawing.Color.Gold;
            this.pnlMapsBig.Location = new System.Drawing.Point(9, 42);
            this.pnlMapsBig.Name = "pnlMapsBig";
            this.pnlMapsBig.ShadowColor = System.Drawing.Color.Black;
            this.pnlMapsBig.Size = new System.Drawing.Size(622, 295);
            this.pnlMapsBig.TabIndex = 11;
            this.pnlMapsBig.TitleText = null;
            this.pnlMapsBig.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMaps
            // 
            this.pnlMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaps.AutoScroll = true;
            this.pnlMaps.BackColor = System.Drawing.Color.Black;
            this.pnlMaps.Location = new System.Drawing.Point(3, 3);
            this.pnlMaps.Name = "pnlMaps";
            this.pnlMaps.Size = new System.Drawing.Size(616, 289);
            this.pnlMaps.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeBorder = true;
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnCancel.BorderSize = 8;
            this.btnCancel.Clicked = false;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gold;
            this.btnCancel.Location = new System.Drawing.Point(535, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Selected = false;
            this.btnCancel.ShadowColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(96, 32);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSizeBorder = true;
            this.btnRefresh.BackColor = System.Drawing.Color.DarkRed;
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnRefresh.BorderSize = 8;
            this.btnRefresh.Clicked = false;
            this.btnRefresh.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Gold;
            this.btnRefresh.Location = new System.Drawing.Point(433, 344);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Selected = false;
            this.btnRefresh.ShadowColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(96, 32);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmDownloadMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = true;
            this.ClientSize = new System.Drawing.Size(640, 385);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlMapsBig);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnDownload);
            this.MaximizeBox = true;
            this.Name = "frmDownloadMaps";
            this.Text = "Download Maps";
            this.Controls.SetChildIndex(this.btnDownload, 0);
            this.Controls.SetChildIndex(this.btnOpenFolder, 0);
            this.Controls.SetChildIndex(this.pnlMapsBig, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnRefresh, 0);
            this.pnlMapsBig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton btnDownload;
        private CustomButton btnOpenFolder;
        private CustomPanel pnlMapsBig;
        private System.Windows.Forms.Panel pnlMaps;
        private CustomButton btnCancel;
        private CustomButton btnRefresh;
    }
}