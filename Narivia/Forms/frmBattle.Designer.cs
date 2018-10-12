namespace Narivia.Battles
{
    partial class frmBattle
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
            this.btnSurrender = new Narivia.CustomButton();
            this.btnAttack = new Narivia.CustomButton();
            this.lblDefender = new Narivia.CustomLabel();
            this.lblAttacker = new Narivia.CustomLabel();
            this.battleBar = new Narivia.Battles.BattleBar();
            this.customToolTip = new Narivia.CustomToolTip();
            this.attackerUnitCard = new Narivia.Battles.UnitCard();
            this.defenderUnitCard = new Narivia.Battles.UnitCard();
            this.customVs = new Narivia.CustomLabel();
            this.btnAttackerUnitLeft = new Narivia.CustomButton();
            this.btnAttackerUnitRight = new Narivia.CustomButton();
            this.btnDefenderUnitRight = new Narivia.CustomButton();
            this.btnDefenderUnitLeft = new Narivia.CustomButton();
            this.lblTurn = new Narivia.CustomLabel();
            this.pbAttackBonus = new System.Windows.Forms.PictureBox();
            this.pbDefenceBonus = new System.Windows.Forms.PictureBox();
            this.lblAttackBonus = new Narivia.CustomLabel();
            this.lblDefenceBonus = new Narivia.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.battleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttackBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefenceBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSurrender
            // 
            this.btnSurrender.AutoSizeBorder = true;
            this.btnSurrender.BackColor = System.Drawing.Color.DarkRed;
            this.btnSurrender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSurrender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnSurrender.BorderSize = 8;
            this.btnSurrender.Clicked = false;
            this.btnSurrender.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnSurrender.ForeColor = System.Drawing.Color.Gold;
            this.btnSurrender.Location = new System.Drawing.Point(280, 300);
            this.btnSurrender.Name = "btnSurrender";
            this.btnSurrender.Selected = false;
            this.btnSurrender.ShadowColor = System.Drawing.Color.Black;
            this.btnSurrender.Size = new System.Drawing.Size(80, 24);
            this.btnSurrender.TabIndex = 18;
            this.btnSurrender.Text = "Surrender";
            this.btnSurrender.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.AutoSizeBorder = true;
            this.btnAttack.BackColor = System.Drawing.Color.DarkRed;
            this.btnAttack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAttack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnAttack.BorderSize = 8;
            this.btnAttack.Clicked = false;
            this.btnAttack.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold);
            this.btnAttack.ForeColor = System.Drawing.Color.Gold;
            this.btnAttack.Location = new System.Drawing.Point(260, 256);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Selected = false;
            this.btnAttack.ShadowColor = System.Drawing.Color.Black;
            this.btnAttack.Size = new System.Drawing.Size(120, 38);
            this.btnAttack.TabIndex = 16;
            this.btnAttack.Text = "Attack";
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblDefender
            // 
            this.lblDefender.BackColor = System.Drawing.Color.Transparent;
            this.lblDefender.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDefender.ForeColor = System.Drawing.Color.Gold;
            this.lblDefender.Location = new System.Drawing.Point(377, 252);
            this.lblDefender.Name = "lblDefender";
            this.lblDefender.ShadowColor = System.Drawing.Color.Black;
            this.lblDefender.Size = new System.Drawing.Size(251, 23);
            this.lblDefender.TabIndex = 19;
            this.lblDefender.Text = "Defender (0)";
            this.lblDefender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAttacker
            // 
            this.lblAttacker.BackColor = System.Drawing.Color.Transparent;
            this.lblAttacker.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAttacker.ForeColor = System.Drawing.Color.Gold;
            this.lblAttacker.Location = new System.Drawing.Point(12, 252);
            this.lblAttacker.Name = "lblAttacker";
            this.lblAttacker.ShadowColor = System.Drawing.Color.Black;
            this.lblAttacker.Size = new System.Drawing.Size(252, 23);
            this.lblAttacker.TabIndex = 6;
            this.lblAttacker.Text = "Attacker (0)";
            this.lblAttacker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // battleBar
            // 
            this.battleBar.AttackerColor = System.Drawing.Color.Empty;
            this.battleBar.AttackerScore = 0;
            this.battleBar.AutoSizeBorder = true;
            this.battleBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.battleBar.BorderSize = 6;
            this.battleBar.DefenderColor = System.Drawing.Color.Empty;
            this.battleBar.DefenderScore = 0;
            this.battleBar.Location = new System.Drawing.Point(12, 202);
            this.battleBar.Name = "battleBar";
            this.battleBar.Size = new System.Drawing.Size(616, 48);
            this.battleBar.TabIndex = 4;
            this.battleBar.TabStop = false;
            // 
            // customToolTip
            // 
            this.customToolTip.AutoPopDelay = 5000;
            this.customToolTip.BackColor = System.Drawing.Color.DarkRed;
            this.customToolTip.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.customToolTip.ForeColor = System.Drawing.Color.Gold;
            this.customToolTip.InitialDelay = 0;
            this.customToolTip.Offset = 6;
            this.customToolTip.OwnerDraw = true;
            this.customToolTip.ReshowDelay = 100;
            this.customToolTip.UseFading = false;
            // 
            // attackerUnitCard
            // 
            this.attackerUnitCard.BackColor = System.Drawing.Color.DarkRed;
            this.attackerUnitCard.Font = new System.Drawing.Font("Palatino Linotype", 52F, System.Drawing.FontStyle.Bold);
            this.attackerUnitCard.ForeColor = System.Drawing.Color.Gold;
            this.attackerUnitCard.Location = new System.Drawing.Point(12, 42);
            this.attackerUnitCard.Name = "attackerUnitCard";
            this.attackerUnitCard.ShadowColor = System.Drawing.Color.Black;
            this.attackerUnitCard.Size = new System.Drawing.Size(256, 105);
            this.attackerUnitCard.TabIndex = 21;
            this.attackerUnitCard.TitleText = null;
            this.attackerUnitCard.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.attackerUnitCard.UnitID = 0;
            // 
            // defenderUnitCard
            // 
            this.defenderUnitCard.BackColor = System.Drawing.Color.DarkRed;
            this.defenderUnitCard.Font = new System.Drawing.Font("Palatino Linotype", 52F, System.Drawing.FontStyle.Bold);
            this.defenderUnitCard.ForeColor = System.Drawing.Color.Gold;
            this.defenderUnitCard.Location = new System.Drawing.Point(372, 42);
            this.defenderUnitCard.Name = "defenderUnitCard";
            this.defenderUnitCard.ShadowColor = System.Drawing.Color.Black;
            this.defenderUnitCard.Size = new System.Drawing.Size(256, 105);
            this.defenderUnitCard.TabIndex = 22;
            this.defenderUnitCard.TitleText = null;
            this.defenderUnitCard.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.defenderUnitCard.UnitID = 0;
            // 
            // customVs
            // 
            this.customVs.AutoSize = true;
            this.customVs.BackColor = System.Drawing.Color.Transparent;
            this.customVs.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customVs.ForeColor = System.Drawing.Color.Gold;
            this.customVs.Location = new System.Drawing.Point(301, 115);
            this.customVs.Name = "customVs";
            this.customVs.ShadowColor = System.Drawing.Color.Black;
            this.customVs.Size = new System.Drawing.Size(39, 32);
            this.customVs.TabIndex = 23;
            this.customVs.Text = "vs";
            this.customVs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAttackerUnitLeft
            // 
            this.btnAttackerUnitLeft.AutoSizeBorder = true;
            this.btnAttackerUnitLeft.BackColor = System.Drawing.Color.DarkRed;
            this.btnAttackerUnitLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnAttackerUnitLeft.BorderSize = 8;
            this.btnAttackerUnitLeft.Clicked = false;
            this.btnAttackerUnitLeft.Font = new System.Drawing.Font("Palatino Linotype", 8F);
            this.btnAttackerUnitLeft.ForeColor = System.Drawing.Color.Gold;
            this.btnAttackerUnitLeft.Location = new System.Drawing.Point(12, 153);
            this.btnAttackerUnitLeft.Name = "btnAttackerUnitLeft";
            this.btnAttackerUnitLeft.Selected = false;
            this.btnAttackerUnitLeft.ShadowColor = System.Drawing.Color.Black;
            this.btnAttackerUnitLeft.Size = new System.Drawing.Size(36, 36);
            this.btnAttackerUnitLeft.TabIndex = 24;
            this.btnAttackerUnitLeft.Text = "◄";
            this.btnAttackerUnitLeft.Click += new System.EventHandler(this.btnAttackerUnitLeft_Click);
            // 
            // btnAttackerUnitRight
            // 
            this.btnAttackerUnitRight.AutoSizeBorder = true;
            this.btnAttackerUnitRight.BackColor = System.Drawing.Color.DarkRed;
            this.btnAttackerUnitRight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnAttackerUnitRight.BorderSize = 8;
            this.btnAttackerUnitRight.Clicked = false;
            this.btnAttackerUnitRight.Font = new System.Drawing.Font("Palatino Linotype", 8F);
            this.btnAttackerUnitRight.ForeColor = System.Drawing.Color.Gold;
            this.btnAttackerUnitRight.Location = new System.Drawing.Point(54, 153);
            this.btnAttackerUnitRight.Name = "btnAttackerUnitRight";
            this.btnAttackerUnitRight.Selected = false;
            this.btnAttackerUnitRight.ShadowColor = System.Drawing.Color.Black;
            this.btnAttackerUnitRight.Size = new System.Drawing.Size(36, 36);
            this.btnAttackerUnitRight.TabIndex = 25;
            this.btnAttackerUnitRight.Text = "►";
            this.btnAttackerUnitRight.Click += new System.EventHandler(this.btnAttackerUnitRight_Click);
            // 
            // btnDefenderUnitRight
            // 
            this.btnDefenderUnitRight.AutoSizeBorder = true;
            this.btnDefenderUnitRight.BackColor = System.Drawing.Color.DarkRed;
            this.btnDefenderUnitRight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnDefenderUnitRight.BorderSize = 8;
            this.btnDefenderUnitRight.Clicked = false;
            this.btnDefenderUnitRight.Font = new System.Drawing.Font("Palatino Linotype", 8F);
            this.btnDefenderUnitRight.ForeColor = System.Drawing.Color.Gold;
            this.btnDefenderUnitRight.Location = new System.Drawing.Point(592, 153);
            this.btnDefenderUnitRight.Name = "btnDefenderUnitRight";
            this.btnDefenderUnitRight.Selected = false;
            this.btnDefenderUnitRight.ShadowColor = System.Drawing.Color.Black;
            this.btnDefenderUnitRight.Size = new System.Drawing.Size(36, 36);
            this.btnDefenderUnitRight.TabIndex = 27;
            this.btnDefenderUnitRight.Text = "►";
            this.btnDefenderUnitRight.Click += new System.EventHandler(this.btnDefenderUnitRight_Click);
            // 
            // btnDefenderUnitLeft
            // 
            this.btnDefenderUnitLeft.AutoSizeBorder = true;
            this.btnDefenderUnitLeft.BackColor = System.Drawing.Color.DarkRed;
            this.btnDefenderUnitLeft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnDefenderUnitLeft.BorderSize = 8;
            this.btnDefenderUnitLeft.Clicked = false;
            this.btnDefenderUnitLeft.Font = new System.Drawing.Font("Palatino Linotype", 8F);
            this.btnDefenderUnitLeft.ForeColor = System.Drawing.Color.Gold;
            this.btnDefenderUnitLeft.Location = new System.Drawing.Point(550, 153);
            this.btnDefenderUnitLeft.Name = "btnDefenderUnitLeft";
            this.btnDefenderUnitLeft.Selected = false;
            this.btnDefenderUnitLeft.ShadowColor = System.Drawing.Color.Black;
            this.btnDefenderUnitLeft.Size = new System.Drawing.Size(36, 36);
            this.btnDefenderUnitLeft.TabIndex = 26;
            this.btnDefenderUnitLeft.Text = "◄";
            this.btnDefenderUnitLeft.Click += new System.EventHandler(this.btnDefenderUnitLeft_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTurn.ForeColor = System.Drawing.Color.Gold;
            this.lblTurn.Location = new System.Drawing.Point(286, 42);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.ShadowColor = System.Drawing.Color.Black;
            this.lblTurn.Size = new System.Drawing.Size(68, 64);
            this.lblTurn.TabIndex = 29;
            this.lblTurn.Text = "Turn\r\n0";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbAttackBonus
            // 
            this.pbAttackBonus.BackColor = System.Drawing.Color.Transparent;
            this.pbAttackBonus.Image = global::Narivia.Properties.Resources.MissingTexture;
            this.pbAttackBonus.Location = new System.Drawing.Point(96, 153);
            this.pbAttackBonus.Name = "pbAttackBonus";
            this.pbAttackBonus.Size = new System.Drawing.Size(16, 16);
            this.pbAttackBonus.TabIndex = 30;
            this.pbAttackBonus.TabStop = false;
            // 
            // pbDefenceBonus
            // 
            this.pbDefenceBonus.BackColor = System.Drawing.Color.Transparent;
            this.pbDefenceBonus.Image = global::Narivia.Properties.Resources.MissingTexture;
            this.pbDefenceBonus.Location = new System.Drawing.Point(532, 153);
            this.pbDefenceBonus.Name = "pbDefenceBonus";
            this.pbDefenceBonus.Size = new System.Drawing.Size(16, 16);
            this.pbDefenceBonus.TabIndex = 31;
            this.pbDefenceBonus.TabStop = false;
            // 
            // lblAttackBonus
            // 
            this.lblAttackBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblAttackBonus.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAttackBonus.ForeColor = System.Drawing.Color.Gold;
            this.lblAttackBonus.Location = new System.Drawing.Point(118, 151);
            this.lblAttackBonus.Name = "lblAttackBonus";
            this.lblAttackBonus.ShadowColor = System.Drawing.Color.Black;
            this.lblAttackBonus.Size = new System.Drawing.Size(150, 18);
            this.lblAttackBonus.TabIndex = 32;
            this.lblAttackBonus.Text = "+0";
            // 
            // lblDefenceBonus
            // 
            this.lblDefenceBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblDefenceBonus.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDefenceBonus.ForeColor = System.Drawing.Color.Gold;
            this.lblDefenceBonus.Location = new System.Drawing.Point(372, 151);
            this.lblDefenceBonus.Name = "lblDefenceBonus";
            this.lblDefenceBonus.ShadowColor = System.Drawing.Color.Black;
            this.lblDefenceBonus.Size = new System.Drawing.Size(154, 18);
            this.lblDefenceBonus.TabIndex = 33;
            this.lblDefenceBonus.Text = "0+";
            this.lblDefenceBonus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = true;
            this.ClientSize = new System.Drawing.Size(640, 332);
            this.Controls.Add(this.lblDefenceBonus);
            this.Controls.Add(this.lblAttackBonus);
            this.Controls.Add(this.pbDefenceBonus);
            this.Controls.Add(this.pbAttackBonus);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnDefenderUnitRight);
            this.Controls.Add(this.btnDefenderUnitLeft);
            this.Controls.Add(this.btnAttackerUnitRight);
            this.Controls.Add(this.btnAttackerUnitLeft);
            this.Controls.Add(this.customVs);
            this.Controls.Add(this.defenderUnitCard);
            this.Controls.Add(this.attackerUnitCard);
            this.Controls.Add(this.btnSurrender);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblDefender);
            this.Controls.Add(this.lblAttacker);
            this.Controls.Add(this.battleBar);
            this.MaximizeBox = true;
            this.Name = "frmBattle";
            this.Text = "Battle of Region";
            this.Controls.SetChildIndex(this.battleBar, 0);
            this.Controls.SetChildIndex(this.lblAttacker, 0);
            this.Controls.SetChildIndex(this.lblDefender, 0);
            this.Controls.SetChildIndex(this.btnAttack, 0);
            this.Controls.SetChildIndex(this.btnSurrender, 0);
            this.Controls.SetChildIndex(this.attackerUnitCard, 0);
            this.Controls.SetChildIndex(this.defenderUnitCard, 0);
            this.Controls.SetChildIndex(this.customVs, 0);
            this.Controls.SetChildIndex(this.btnAttackerUnitLeft, 0);
            this.Controls.SetChildIndex(this.btnAttackerUnitRight, 0);
            this.Controls.SetChildIndex(this.btnDefenderUnitLeft, 0);
            this.Controls.SetChildIndex(this.btnDefenderUnitRight, 0);
            this.Controls.SetChildIndex(this.lblTurn, 0);
            this.Controls.SetChildIndex(this.pbAttackBonus, 0);
            this.Controls.SetChildIndex(this.pbDefenceBonus, 0);
            this.Controls.SetChildIndex(this.lblAttackBonus, 0);
            this.Controls.SetChildIndex(this.lblDefenceBonus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.battleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttackBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefenceBonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BattleBar battleBar;
        private CustomLabel lblAttacker;
        private CustomButton btnAttack;
        private CustomButton btnSurrender;
        private CustomLabel lblDefender;
        private CustomToolTip customToolTip;
        private UnitCard attackerUnitCard;
        private UnitCard defenderUnitCard;
        private CustomLabel customVs;
        private CustomButton btnAttackerUnitLeft;
        private CustomButton btnAttackerUnitRight;
        private CustomButton btnDefenderUnitRight;
        private CustomButton btnDefenderUnitLeft;
        private CustomLabel lblTurn;
        private System.Windows.Forms.PictureBox pbAttackBonus;
        private System.Windows.Forms.PictureBox pbDefenceBonus;
        private CustomLabel lblAttackBonus;
        private CustomLabel lblDefenceBonus;

    }
}