using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Narivia.Game;

namespace Narivia.Battles
{
    class UnitCard : CustomPanel
    {
        private CustomLabel lblTitle;
        private PictureBox pbIcon;
        private PictureBox pbAttack;
        private PictureBox pbHealth;
        private CustomLabel lblAttack;
        private CustomLabel lblHealth;

        public int UnitID { get; set; }

        private void InitializeComponent()
        {
            this.lblTitle = new Narivia.CustomLabel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbAttack = new System.Windows.Forms.PictureBox();
            this.pbHealth = new System.Windows.Forms.PictureBox();
            this.lblAttack = new Narivia.CustomLabel();
            this.lblHealth = new Narivia.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHealth)).BeginInit();
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
            this.pbIcon.Location = new System.Drawing.Point(180, 29);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(64, 64);
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            this.pbIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // pbAttack
            // 
            this.pbAttack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbAttack.Location = new System.Drawing.Point(12, 31);
            this.pbAttack.Name = "pbAttack";
            this.pbAttack.Size = new System.Drawing.Size(16, 16);
            this.pbAttack.TabIndex = 0;
            this.pbAttack.TabStop = false;
            // 
            // pbHealth
            // 
            this.pbHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbHealth.Location = new System.Drawing.Point(12, 53);
            this.pbHealth.Name = "pbHealth";
            this.pbHealth.Size = new System.Drawing.Size(16, 16);
            this.pbHealth.TabIndex = 0;
            this.pbHealth.TabStop = false;
            // 
            // lblAttack
            // 
            this.lblAttack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAttack.AutoSize = true;
            this.lblAttack.BackColor = System.Drawing.Color.Transparent;
            this.lblAttack.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAttack.ForeColor = System.Drawing.Color.Gold;
            this.lblAttack.Location = new System.Drawing.Point(34, 30);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.ShadowColor = System.Drawing.Color.Black;
            this.lblAttack.Size = new System.Drawing.Size(15, 18);
            this.lblAttack.TabIndex = 0;
            this.lblAttack.Text = "0";
            // 
            // lblHealth
            // 
            this.lblHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHealth.ForeColor = System.Drawing.Color.Gold;
            this.lblHealth.Location = new System.Drawing.Point(34, 52);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.ShadowColor = System.Drawing.Color.Black;
            this.lblHealth.Size = new System.Drawing.Size(15, 18);
            this.lblHealth.TabIndex = 0;
            this.lblHealth.Text = "0";
            // 
            // UnitCard
            // 
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.pbAttack);
            this.Controls.Add(this.pbHealth);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.lblHealth);
            this.Size = new System.Drawing.Size(256, 105);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHealth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public UnitCard()
        {
            InitializeComponent();

            pbAttack.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "AttackBonus.PNG");
            pbHealth.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "Health.PNG");
        }

        public void SetUnit(Unit unit, Faction faction)
        {
            UnitID = unit.ID;

            lblTitle.Text = unit.Name + " (" + faction.Units[unit.ID] + ")";
            pbIcon.Image = unit.Icon;

            lblAttack.Text = unit.Attack.ToString();
            lblHealth.Text = unit.Health.ToString();
        }
    }
}
