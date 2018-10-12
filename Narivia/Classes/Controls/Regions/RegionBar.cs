using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

using Narivia.Game;

namespace Narivia
{
    class RegionBar : Panel
    {
        private Label lblRegionName;
        private CustomButton btnRight;
        private CustomButton btnLeft;

        public frmGame frmGame { get; set; }
        public World World { get { return frmGame.World; } }
        public int RegionID { get; set; }
        public int FactionID { get { return World.Region[RegionID].Faction; } }

        int reg = 0;
        int fct = 0;

        public RegionBar()
        {
            Size = new System.Drawing.Size(240, 36);

            InitializeComponent();
            AddControls();

            lblRegionName.Image = DrawingPlus.LoadImage(NarivianClass.PanelsDirectory + "Region Name.PNG");
        }
        public void SetGame(frmGame frmGame)
        {
            this.frmGame = frmGame;
        }
        public void Initialize(int regionID)
        {
            RegionID = regionID;
        }

        public void GetRegion(int regionID)
        {
            reg = regionID;
            fct = World.Region[regionID].Faction;

            //if (isRunning)
            {
                if (regionID != 0)
                {
                    lblRegionName.BackColor = World.Faction[World.Region[regionID].Faction].Color;
                    lblRegionName.Text = World.Region[regionID].Name;
                }
                else
                {
                    lblRegionName.BackColor = Color.White;
                    lblRegionName.Text = "";
                }

                if (fct == World.Player)
                {
                    btnLeft.Enabled = true;
                    btnRight.Enabled = true;
                }
                else
                {
                    btnLeft.Enabled = false;
                    btnRight.Enabled = false;
                }

            }
        }

        private void InitializeComponent()
        {
            this.btnLeft = new Narivia.CustomButton();
            this.lblRegionName = new CustomLabel();
            this.btnRight = new Narivia.CustomButton();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.DarkRed;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLeft.ForeColor = System.Drawing.Color.Gold;
            this.btnLeft.Location = new System.Drawing.Point(0, 0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(36, 36);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "◄";
            this.btnLeft.Enabled = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lblRegionName
            // 
            this.lblRegionName.BackColor = System.Drawing.Color.White;
            this.lblRegionName.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegionName.ForeColor = System.Drawing.Color.Gold;
            this.lblRegionName.Location = new System.Drawing.Point(36, 0);
            this.lblRegionName.Name = "lblRegionName";
            this.lblRegionName.Size = new System.Drawing.Size(168, 36);
            this.lblRegionName.TabIndex = 0;
            this.lblRegionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.DarkRed;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRight.ForeColor = System.Drawing.Color.Gold;
            this.btnRight.Location = new System.Drawing.Point(204, 0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(36, 36);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "►";
            this.btnRight.Enabled = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // RegionBar
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.MaximumSize = new System.Drawing.Size(240, 36);
            this.MinimumSize = new System.Drawing.Size(240, 36);
            this.Size = new System.Drawing.Size(240, 36);
            this.ResumeLayout(false);

        }
        private void AddControls()
        {
            this.Controls.Add(btnLeft);
            this.Controls.Add(lblRegionName);
            this.Controls.Add(btnRight);
        }

        private int GetRegPos()
        {
            int regPos = 0;

            for (regPos = 0; regPos <= World.Faction[fct].RegionCount; regPos++)
                if (World.Faction[fct].Region[regPos] == reg)
                    break;

            return regPos;
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            int regPos = GetRegPos();

            if (regPos == 0)
                frmGame.UpdateRegionInfo(World.Faction[fct].Region[World.Faction[fct].RegionCount - 1]);
            else
                frmGame.UpdateRegionInfo(World.Faction[fct].Region[regPos - 1]);
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            int regPos = GetRegPos();

            if (regPos == World.Faction[fct].RegionCount - 1)
                frmGame.UpdateRegionInfo(World.Faction[fct].Region[0]);
            else
                frmGame.UpdateRegionInfo(World.Faction[fct].Region[regPos + 1]);
        }
    }
}
