using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Narivia.Game;

namespace Narivia
{
    class BuildingCard : CustomPanel
    {
        private CustomLabel lblTitle;
        private CustomLabel lblDetails;
        private PictureBox pbIcon;

        public int BuildingID { get; set; }
        public int CultureID { get; set; }
        public bool Owned { get; set; }

        private void InitializeComponent()
        {
            this.lblTitle = new Narivia.CustomLabel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblDetails = new Narivia.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.ShadowColor = System.Drawing.Color.Black;
            this.lblTitle.Size = new System.Drawing.Size(256, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Unit (Nr)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbIcon
            // 
            this.pbIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbIcon.Location = new System.Drawing.Point(166, 31);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(78, 62);
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            this.pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // lblDetails
            // 
            this.lblDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDetails.AutoSize = false;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDetails.ForeColor = System.Drawing.Color.Gold;
            this.lblDetails.Location = new System.Drawing.Point(12, 31);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.ShadowColor = System.Drawing.Color.Black;
            this.lblDetails.Size = new System.Drawing.Size(150, 62);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "0";
            // 
            // UnitCard
            // 
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblDetails);
            this.Size = new System.Drawing.Size(256, 105);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public BuildingCard()
        {
            InitializeComponent();
        }

        public void SetBuilding(Building building, Faction faction)
        {
            BuildingID = building.ID;
            CultureID = faction.Culture;

            lblTitle.Text = building.Name;
            if (Owned)
                lblTitle.Text += " (Owned)";

            pbIcon.Image = building.Icon[CultureID];

            lblDetails.Text = building.Description + "\n\n";

            lblDetails.Text += "Maintenance: " + building.Maintenance;

            if (building.Income != 0)
                lblDetails.Text += "\nIncome: " + building.Income;
            if (building.AttackBonus != 0)
                lblDetails.Text += "\nAttack Bonus: " + building.AttackBonus;
            if (building.DefenceBonus != 0)
                lblDetails.Text += "\nDefence Bonus: " + building.DefenceBonus;
            if (building.RecruitmentBonus != 0)
                lblDetails.Text += "\nRecruitment Bonus: " + building.RecruitmentBonus;
            if (building.ReligionInfluence != 0)
                lblDetails.Text += "\nReligion Influence: " + building.ReligionInfluence;
        }
    }
}
