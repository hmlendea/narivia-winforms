using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Narivia
{
    public partial class frmMenu : CustomForm
    {
        frmGame frmGame;

        public frmMenu(frmGame game)
        {
            InitializeComponent();
            frmGame = game;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            frmSaveGame frmSaveGame = new frmSaveGame(frmGame);
            frmSaveGame.Show();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            frmLoadGame frmLoadGame = new frmLoadGame();
            frmLoadGame.Show();
            frmLoadGame.FormClosing += delegate
            {
                Close();
                frmGame.Close();
            };
        }

        private void btnGameRules_Click(object sender, EventArgs e)
        {
            Notice.Show(
                "Homeland Priority: " + frmGame.HomelandPriority.ToString() + Environment.NewLine +
                "Base Region Income: " + frmGame.World.BaseRegionIncome + Environment.NewLine +
                "Base Region Recruitment: " + frmGame.World.BaseRegionRecruitment + Environment.NewLine +
                "Recruitment rate: " + frmGame.World.RecruitmentRate.Min + "-" + frmGame.World.RecruitmentRate.Max + Environment.NewLine +
                "Attacker bonus: " + frmGame.World.AttackerBonus.Min + "%-" + frmGame.World.AttackerBonus.Max + "%" + Environment.NewLine +
                "Defender bonus: " + frmGame.World.DefenderBonus.Min + "%-" + frmGame.World.DefenderBonus.Max + "%" + Environment.NewLine +
                "Min. Troops to Attack = " + frmGame.World.MinTroopsAttack + Environment.NewLine +
                "Healing rate: " + frmGame.World.HealingRate + "%" + Environment.NewLine,
                "Game Rules", "GameRules");
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmOptions frmOptions = new frmOptions();
            frmOptions.FormClosing += delegate { UpdateFormWindowState(); };
            frmOptions.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            frmGame.Close();
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
