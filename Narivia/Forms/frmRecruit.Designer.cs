namespace Narivia
{
    partial class frmRecruit
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
            this.unitCard = new Narivia.Battles.UnitCard();
            this.btnBack = new Narivia.CustomButton();
            this.btnNext = new Narivia.CustomButton();
            this.btnExit = new Narivia.CustomButton();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btnRecruit = new Narivia.CustomButton();
            this.lblPrice = new Narivia.CustomLabel();
            this.pbMoney = new System.Windows.Forms.PictureBox();
            this.lblMoney = new Narivia.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // unitCard
            // 
            this.unitCard.BackColor = System.Drawing.Color.DarkRed;
            this.unitCard.Font = new System.Drawing.Font("Palatino Linotype", 52F, System.Drawing.FontStyle.Bold);
            this.unitCard.ForeColor = System.Drawing.Color.Gold;
            this.unitCard.Location = new System.Drawing.Point(28, 42);
            this.unitCard.Name = "unitCard";
            this.unitCard.ShadowColor = System.Drawing.Color.Black;
            this.unitCard.Size = new System.Drawing.Size(256, 105);
            this.unitCard.TabIndex = 4;
            this.unitCard.TitleText = null;
            this.unitCard.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unitCard.UnitID = 0;
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeBorder = true;
            this.btnBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnBack.BorderSize = 8;
            this.btnBack.Clicked = false;
            this.btnBack.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.btnBack.ForeColor = System.Drawing.Color.Gold;
            this.btnBack.Location = new System.Drawing.Point(28, 153);
            this.btnBack.Name = "btnBack";
            this.btnBack.Selected = false;
            this.btnBack.ShadowColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "◄";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSizeBorder = true;
            this.btnNext.BackColor = System.Drawing.Color.DarkRed;
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnNext.BorderSize = 8;
            this.btnNext.Clicked = false;
            this.btnNext.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.btnNext.ForeColor = System.Drawing.Color.Gold;
            this.btnNext.Location = new System.Drawing.Point(66, 153);
            this.btnNext.Name = "btnNext";
            this.btnNext.Selected = false;
            this.btnNext.ShadowColor = System.Drawing.Color.Black;
            this.btnNext.Size = new System.Drawing.Size(32, 32);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "►";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeBorder = true;
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnExit.BorderSize = 8;
            this.btnExit.Clicked = false;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(28, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.Selected = false;
            this.btnExit.ShadowColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(70, 32);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // numCount
            // 
            this.numCount.BackColor = System.Drawing.Color.DarkRed;
            this.numCount.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.numCount.ForeColor = System.Drawing.Color.Gold;
            this.numCount.Location = new System.Drawing.Point(104, 153);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(180, 25);
            this.numCount.TabIndex = 21;
            this.numCount.ValueChanged += new System.EventHandler(this.numCount_ValueChanged);
            // 
            // btnRecruit
            // 
            this.btnRecruit.AutoSizeBorder = true;
            this.btnRecruit.BackColor = System.Drawing.Color.DarkRed;
            this.btnRecruit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(46)))), ((int)(((byte)(40)))));
            this.btnRecruit.BorderSize = 8;
            this.btnRecruit.Clicked = false;
            this.btnRecruit.Font = new System.Drawing.Font("Palatino Linotype", 11F);
            this.btnRecruit.ForeColor = System.Drawing.Color.Gold;
            this.btnRecruit.Location = new System.Drawing.Point(104, 191);
            this.btnRecruit.Name = "btnRecruit";
            this.btnRecruit.Selected = false;
            this.btnRecruit.ShadowColor = System.Drawing.Color.Black;
            this.btnRecruit.Size = new System.Drawing.Size(70, 32);
            this.btnRecruit.TabIndex = 22;
            this.btnRecruit.Text = "Recruit";
            this.btnRecruit.Click += new System.EventHandler(this.btnRecruit_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Gold;
            this.lblPrice.Location = new System.Drawing.Point(180, 191);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.ShadowColor = System.Drawing.Color.Black;
            this.lblPrice.Size = new System.Drawing.Size(104, 32);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "for X gold";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbMoney
            // 
            this.pbMoney.BackColor = System.Drawing.Color.Transparent;
            this.pbMoney.Image = global::Narivia.Properties.Resources.MissingTexture;
            this.pbMoney.Location = new System.Drawing.Point(28, 229);
            this.pbMoney.Name = "pbMoney";
            this.pbMoney.Size = new System.Drawing.Size(16, 16);
            this.pbMoney.TabIndex = 24;
            this.pbMoney.TabStop = false;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMoney.ForeColor = System.Drawing.Color.Gold;
            this.lblMoney.Location = new System.Drawing.Point(50, 227);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.ShadowColor = System.Drawing.Color.Black;
            this.lblMoney.Size = new System.Drawing.Size(48, 18);
            this.lblMoney.TabIndex = 25;
            this.lblMoney.Text = "X gold";
            // 
            // frmRecruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border = true;
            this.ClientSize = new System.Drawing.Size(312, 257);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.pbMoney);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnRecruit);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.unitCard);
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(312, 257);
            this.Name = "frmRecruit";
            this.Text = "Recruitment";
            this.Controls.SetChildIndex(this.unitCard, 0);
            this.Controls.SetChildIndex(this.btnBack, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnExit, 0);
            this.Controls.SetChildIndex(this.numCount, 0);
            this.Controls.SetChildIndex(this.btnRecruit, 0);
            this.Controls.SetChildIndex(this.lblPrice, 0);
            this.Controls.SetChildIndex(this.pbMoney, 0);
            this.Controls.SetChildIndex(this.lblMoney, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Battles.UnitCard unitCard;
        private CustomButton btnBack;
        private CustomButton btnNext;
        private CustomButton btnExit;
        private System.Windows.Forms.NumericUpDown numCount;
        private CustomButton btnRecruit;
        private CustomLabel lblPrice;
        private System.Windows.Forms.PictureBox pbMoney;
        private CustomLabel lblMoney;


    }
}