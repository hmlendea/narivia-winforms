using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Narivia.Game;

namespace Narivia
{
    public partial class frmRecruit : CustomForm
    {
        frmGame frmGame { get; set; }

        public frmRecruit(frmGame frmGame)
        {
            InitializeComponent();
            this.frmGame = frmGame;

            unitCard.BackColor = frmGame.World.Faction[frmGame.Player].Color;

            pbMoney.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "Money.PNG");
            lblMoney.Text = frmGame.World.Faction[frmGame.Player].Money + " gold";

            SelectUnit(1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (unitCard.UnitID >= 2)
                SelectUnit(unitCard.UnitID - 1);
            else
                SelectUnit(frmGame.World.Unit.Count - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (unitCard.UnitID < frmGame.World.Unit.Count - 1)
                SelectUnit(unitCard.UnitID + 1);
            else
                SelectUnit(1);
        }

        private void SelectUnit(int unit)
        {
            unitCard.SetUnit(frmGame.World.Unit[unit], frmGame.World.Faction[frmGame.Player]);

            numCount.Maximum = (int)(frmGame.World.Faction[frmGame.Player].Money / frmGame.World.Unit[unitCard.UnitID].Price);
            lblPrice.Text = "for -" + (int)(frmGame.World.Unit[unitCard.UnitID].Price * numCount.Value) + " gold";
        }

        private void btnRecruit_Click(object sender, EventArgs e)
        {
            if (numCount.Value > 0)
                if (frmGame.World.Faction[frmGame.Player].Money - frmGame.World.Unit[unitCard.UnitID].Price * (int)numCount.Value >= 0)
                    if (Notice.Show(
                        frmGame.World.Unit[unitCard.UnitID].Description + Environment.NewLine +
                        "___________" + Environment.NewLine +
                        "Recruit this " + lblPrice.Text + "?",
                        frmGame.World.Unit[unitCard.UnitID].Name, "Recruitment")
                        == DialogResult.Yes)
                    {
                        frmGame.RecruitUnit(frmGame.Player, unitCard.UnitID, (int)numCount.Value);
                        numCount.Value = 0;
                        SelectUnit(unitCard.UnitID);
                        lblMoney.Text = frmGame.World.Faction[frmGame.Player].Money + " gold";
                    }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numCount_ValueChanged(object sender, EventArgs e)
        {
            lblPrice.Text = "for -" + (frmGame.World.Unit[unitCard.UnitID].Price * (int)numCount.Value) + " gold";
        }
    }
}
