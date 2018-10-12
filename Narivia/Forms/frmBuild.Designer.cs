namespace Narivia
{
    partial class frmBuild
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
            this.lblBuildingName = new Narivia.CustomLabel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblDetails = new Narivia.CustomLabel();
            this.btnExit = new Narivia.CustomButton();
            this.btnBuild = new Narivia.CustomButton();
            this.pnlBuildingsBig = new Narivia.CustomPanel();
            this.pnlBuildings = new System.Windows.Forms.Panel();
            this.lblPriceText = new Narivia.CustomLabel();
            this.pbMoney = new System.Windows.Forms.PictureBox();
            this.lblPrice = new Narivia.CustomLabel();
            this.pnlBuilding = new System.Windows.Forms.Panel();
            this.lblMoney = new Narivia.CustomLabel();
            this.pbMoney2 = new System.Windows.Forms.PictureBox();
            this.lblMoneyText = new Narivia.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.pnlBuildingsBig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoney)).BeginInit();
            this.pnlBuilding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoney2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuildingName.BackColor = System.Drawing.Color.Transparent;
            this.lblBuildingName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBuildingName.ForeColor = System.Drawing.Color.Gold;
            this.lblBuildingName.Location = new System.Drawing.Point(0, 0);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.ShadowColor = System.Drawing.Color.Black;
            this.lblBuildingName.Size = new System.Drawing.Size(262, 24);
            this.lblBuildingName.TabIndex = 5;
            this.lblBuildingName.Text = "BuildingName";
            this.lblBuildingName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbIcon
            // 
            this.pbIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Location = new System.Drawing.Point(92, 28);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(78, 62);
            this.pbIcon.TabIndex = 6;
            this.pbIcon.TabStop = false;
            // 
            // lblDetails
            // 
            this.lblDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDetails.ForeColor = System.Drawing.Color.Gold;
            this.lblDetails.Location = new System.Drawing.Point(3, 93);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.ShadowColor = System.Drawing.Color.Black;
            this.lblDetails.Size = new System.Drawing.Size(256, 189);
            this.lblDetails.TabIndex = 7;
            this.lblDetails.Text = "Description\r\n\r\nDetails";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSizeBorder = true;
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnExit.BorderSize = 8;
            this.btnExit.Clicked = false;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(238, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Selected = false;
            this.btnExit.ShadowColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(128, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuild.AutoSizeBorder = true;
            this.btnBuild.BackColor = System.Drawing.Color.DarkRed;
            this.btnBuild.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnBuild.BorderSize = 8;
            this.btnBuild.Clicked = false;
            this.btnBuild.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBuild.ForeColor = System.Drawing.Color.Gold;
            this.btnBuild.Location = new System.Drawing.Point(372, 330);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Selected = false;
            this.btnBuild.ShadowColor = System.Drawing.Color.Black;
            this.btnBuild.Size = new System.Drawing.Size(128, 32);
            this.btnBuild.TabIndex = 9;
            this.btnBuild.Text = "Build";
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // pnlBuildingsBig
            // 
            this.pnlBuildingsBig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBuildingsBig.BackColor = System.Drawing.Color.DarkRed;
            this.pnlBuildingsBig.Controls.Add(this.pnlBuildings);
            this.pnlBuildingsBig.Font = new System.Drawing.Font("Palatino Linotype", 160F, System.Drawing.FontStyle.Bold);
            this.pnlBuildingsBig.ForeColor = System.Drawing.Color.Gold;
            this.pnlBuildingsBig.Location = new System.Drawing.Point(9, 42);
            this.pnlBuildingsBig.Name = "pnlBuildingsBig";
            this.pnlBuildingsBig.ShadowColor = System.Drawing.Color.Black;
            this.pnlBuildingsBig.Size = new System.Drawing.Size(223, 320);
            this.pnlBuildingsBig.TabIndex = 10;
            this.pnlBuildingsBig.TitleText = null;
            this.pnlBuildingsBig.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBuildings
            // 
            this.pnlBuildings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBuildings.AutoScroll = true;
            this.pnlBuildings.BackColor = System.Drawing.Color.Black;
            this.pnlBuildings.Location = new System.Drawing.Point(3, 3);
            this.pnlBuildings.Name = "pnlBuildings";
            this.pnlBuildings.Size = new System.Drawing.Size(217, 314);
            this.pnlBuildings.TabIndex = 0;
            // 
            // lblPriceText
            // 
            this.lblPriceText.AutoSize = true;
            this.lblPriceText.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceText.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPriceText.ForeColor = System.Drawing.Color.Gold;
            this.lblPriceText.Location = new System.Drawing.Point(3, 28);
            this.lblPriceText.Name = "lblPriceText";
            this.lblPriceText.ShadowColor = System.Drawing.Color.Black;
            this.lblPriceText.Size = new System.Drawing.Size(38, 18);
            this.lblPriceText.TabIndex = 11;
            this.lblPriceText.Text = "Price";
            // 
            // pbMoney
            // 
            this.pbMoney.Location = new System.Drawing.Point(6, 49);
            this.pbMoney.Name = "pbMoney";
            this.pbMoney.Size = new System.Drawing.Size(16, 16);
            this.pbMoney.TabIndex = 12;
            this.pbMoney.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Gold;
            this.lblPrice.Location = new System.Drawing.Point(28, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.ShadowColor = System.Drawing.Color.Black;
            this.lblPrice.Size = new System.Drawing.Size(15, 18);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "0";
            // 
            // pnlBuilding
            // 
            this.pnlBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBuilding.BackColor = System.Drawing.Color.Transparent;
            this.pnlBuilding.Controls.Add(this.lblMoney);
            this.pnlBuilding.Controls.Add(this.pbMoney2);
            this.pnlBuilding.Controls.Add(this.lblMoneyText);
            this.pnlBuilding.Controls.Add(this.lblPrice);
            this.pnlBuilding.Controls.Add(this.lblBuildingName);
            this.pnlBuilding.Controls.Add(this.pbMoney);
            this.pnlBuilding.Controls.Add(this.pbIcon);
            this.pnlBuilding.Controls.Add(this.lblPriceText);
            this.pnlBuilding.Controls.Add(this.lblDetails);
            this.pnlBuilding.Location = new System.Drawing.Point(238, 42);
            this.pnlBuilding.Name = "pnlBuilding";
            this.pnlBuilding.Size = new System.Drawing.Size(262, 282);
            this.pnlBuilding.TabIndex = 14;
            this.pnlBuilding.Visible = false;
            // 
            // lblMoney
            // 
            this.lblMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMoney.ForeColor = System.Drawing.Color.Gold;
            this.lblMoney.Location = new System.Drawing.Point(177, 47);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.ShadowColor = System.Drawing.Color.Black;
            this.lblMoney.Size = new System.Drawing.Size(58, 18);
            this.lblMoney.TabIndex = 16;
            this.lblMoney.Text = "0";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbMoney2
            // 
            this.pbMoney2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMoney2.Location = new System.Drawing.Point(241, 49);
            this.pbMoney2.Name = "pbMoney2";
            this.pbMoney2.Size = new System.Drawing.Size(16, 16);
            this.pbMoney2.TabIndex = 15;
            this.pbMoney2.TabStop = false;
            // 
            // lblMoneyText
            // 
            this.lblMoneyText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoneyText.AutoSize = true;
            this.lblMoneyText.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneyText.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMoneyText.ForeColor = System.Drawing.Color.Gold;
            this.lblMoneyText.Location = new System.Drawing.Point(208, 28);
            this.lblMoneyText.Name = "lblMoneyText";
            this.lblMoneyText.ShadowColor = System.Drawing.Color.Black;
            this.lblMoneyText.Size = new System.Drawing.Size(51, 18);
            this.lblMoneyText.TabIndex = 14;
            this.lblMoneyText.Text = "Money";
            // 
            // frmBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = true;
            this.ClientSize = new System.Drawing.Size(515, 371);
            this.Controls.Add(this.pnlBuilding);
            this.Controls.Add(this.pnlBuildingsBig);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = true;
            this.Name = "frmBuild";
            this.Text = "Build";
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.btnBuild, 0);
            this.Controls.SetChildIndex(this.pnlBuildingsBig, 0);
            this.Controls.SetChildIndex(this.pnlBuilding, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.pnlBuildingsBig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMoney)).EndInit();
            this.pnlBuilding.ResumeLayout(false);
            this.pnlBuilding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoney2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomLabel lblBuildingName;
        private System.Windows.Forms.PictureBox pbIcon;
        private CustomLabel lblDetails;
        private CustomButton btnExit;
        private CustomButton btnBuild;
        private CustomPanel pnlBuildingsBig;
        private System.Windows.Forms.Panel pnlBuildings;
        private CustomLabel lblPriceText;
        private System.Windows.Forms.PictureBox pbMoney;
        private CustomLabel lblPrice;
        private System.Windows.Forms.Panel pnlBuilding;
        private CustomLabel lblMoney;
        private System.Windows.Forms.PictureBox pbMoney2;
        private CustomLabel lblMoneyText;
    }
}