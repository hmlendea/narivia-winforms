using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Narivia.Game;

namespace Narivia.Battles
{
    public partial class frmBattle : CustomForm
    {
        static frmBattle Me;

        public World World;
        public int Attacker { get; set; }
        public int Defender { get; set; }
        public static BattleResult BattleResult { get; set; }
        public int Turn
        {
            get { return turn; }
            set
            {
                turn = value;
                lblTurn.Text = "Turn\n" + value;
            }
        } int turn;

        public frmBattle()
        {
            InitializeComponent();

            BackgroundImage = Properties.Resources.Stone_Bricks;
            pbAttackBonus.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "AttackBonus.PNG");
            pbDefenceBonus.Image = DrawingPlus.LoadImage(NarivianClass.IconsDirectory + "Health.PNG");

            Turn = 0;

            customToolTip.SetToolTip(btnAttack, "Attack");
            customToolTip.SetToolTip(btnSurrender, "Loose the battle but keep all your remaining units alive");
        }

        public void UpdateBattlefield()
        {
            int f1score = World.Faction[Attacker].UnitsCount;
            int f2score = World.Faction[Defender].UnitsCount;

            battleBar.AttackerScore = f1score;
            battleBar.DefenderScore = f2score;

            battleBar.Refresh();
            lblAttacker.Text = World.Faction[Attacker].Name + " (" + f1score + ")";
            lblDefender.Text = World.Faction[Defender].Name + " (" + f2score + ")";

            if (battleBar.AttackerScore > battleBar.DefenderScore)
                BattleResult = BattleResult.Won;
            else
                BattleResult = BattleResult.Lost;

            attackerUnitCard.SetUnit(World.Unit[attackerUnitCard.UnitID], World.Faction[Attacker]);
            defenderUnitCard.SetUnit(World.Unit[defenderUnitCard.UnitID], World.Faction[Defender]);

            if (World.Faction[Attacker].UnitsCount == 0)
            {
                BattleResult = BattleResult.Lost;
                this.Close();
            }
            else if (World.Faction[Defender].UnitsCount == 0)
            {
                BattleResult = BattleResult.Won;
                this.Close();
            }
        }

        public static BattleResult ShowBox(ref World world, int attackerID, int defenderID, int regionID)
        {
            if (world.Faction[defenderID].UnitsCount > 0)
            {
                Me = new frmBattle();

                Me.Text = "Battle of " + world.Region[regionID].Name;

                Me.World = world;
                Me.Attacker = attackerID;
                Me.Defender = defenderID;

                Me.attackerUnitCard.BackColor = Me.World.Faction[attackerID].Color;
                Me.defenderUnitCard.BackColor = Me.World.Faction[defenderID].Color;

                Me.attackerUnitCard.SetUnit( Me.World.Unit[0], Me.World.Faction[attackerID]);
                Me.defenderUnitCard.SetUnit(Me.World.Unit[0], Me.World.Faction[defenderID]);

                Me.lblAttackBonus.Text = "+" + Me.World.GetAttackBonus(attackerID);
                Me.lblDefenceBonus.Text = Me.World.GetDefenceBonus(defenderID) + "+";

                Me.battleBar.AttackerColor = world.Faction[attackerID].Color;
                Me.battleBar.DefenderColor = world.Faction[defenderID].Color;
                Me.battleBar.AttackerScore = world.Faction[attackerID].Units[0];
                Me.battleBar.DefenderScore = world.Faction[defenderID].Units[0];

                Me.UpdateBattlefield();

                if (Me.World.Player == Me.Attacker)
                    Me.btnAttack.Text = "Attack";
                else
                    Me.btnAttack.Text = "Defend";

                Me.ShowDialog();

                return BattleResult;
            }
            else
                return BattleResult.Won;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (World.Player == Attacker && World.Faction[Attacker].Units[attackerUnitCard.UnitID] > 0 ||
                World.Player == Defender && World.Faction[Defender].Units[defenderUnitCard.UnitID] > 0)
            {
                
                Sound.Play("Battlefield\\Attack.Mp3");
                Turn += 1;

                Random rnd = new Random();
                int attackerUnitID = rnd.Next(0, World.Unit.Count);
                int defenderUnitID = rnd.Next(0, World.Unit.Count);

                if (World.Player == Attacker)
                {
                    attackerUnitID = attackerUnitCard.UnitID;

                    while (World.Faction[Defender].Units[defenderUnitID] == 0)
                        defenderUnitID = rnd.Next(0, World.Unit.Count);
                }
                else
                {
                    defenderUnitID = defenderUnitCard.UnitID;

                    while (World.Faction[Attacker].Units[attackerUnitID] == 0)
                        attackerUnitID = rnd.Next(0, World.Unit.Count);
                }

                string attackerUnits = World.Faction[Attacker].Units[attackerUnitID] + "x " + World.Unit[attackerUnitID].Name;
                string defenderUnits = World.Faction[Defender].Units[defenderUnitID] + "x " + World.Unit[defenderUnitID].Name;

                Battle.Fight(ref World, Attacker, Defender, attackerUnitID, defenderUnitID);

                Notice.Show(
                    "Turn started with: " + Environment.NewLine +
                    "(Atk) " + World.Faction[Attacker].Name + ": " + attackerUnits + Environment.NewLine +
                    "(Def) " + World.Faction[Defender].Name + ": " + defenderUnits + Environment.NewLine + Environment.NewLine +
                    "Turn ended with: " + Environment.NewLine +
                    "(Atk) " + World.Faction[Attacker].Name + ": " + World.Faction[Attacker].Units[attackerUnitID] + "x " + World.Unit[attackerUnitID].Name + Environment.NewLine +
                    "(Def) " + World.Faction[Defender].Name + ": " + World.Faction[Defender].Units[defenderUnitID] + "x " + World.Unit[defenderUnitID].Name,
                    Text, "ConfirmAttack");

                UpdateBattlefield();
            }
            else
                Notice.Show("Please select a unit with more than zero troops!", "Choose your unit", "NotEnoughTroops");
        }

        private void btnDefend_Click(object sender, EventArgs e)
        {
            Sound.Play("Battlefield\\Defend.Mp3");
        }

        #region Unit selection
        private void btnAttackerUnitLeft_Click(object sender, EventArgs e)
        {
            int i = attackerUnitCard.UnitID - 1;

            if (i < 0)
                i = World.Unit.Count - 1;

            attackerUnitCard.SetUnit(World.Unit[i], World.Faction[Attacker]);
        }
        private void btnAttackerUnitRight_Click(object sender, EventArgs e)
        {
            int i = attackerUnitCard.UnitID + 1;

            if (i > World.Unit.Count - 1)
                i = 0;

            attackerUnitCard.SetUnit(World.Unit[i], World.Faction[Attacker]);
        }

        private void btnDefenderUnitLeft_Click(object sender, EventArgs e)
        {
            int i = defenderUnitCard.UnitID - 1;

            if (i < 0)
                i = World.Unit.Count - 1;

            defenderUnitCard.SetUnit(World.Unit[i], World.Faction[Defender]);
        }
        private void btnDefenderUnitRight_Click(object sender, EventArgs e)
        {
            int i = defenderUnitCard.UnitID + 1;

            if (i > World.Unit.Count - 1)
                i = 0;

            defenderUnitCard.SetUnit(World.Unit[i], World.Faction[Defender]);
        }
        #endregion

        private void btnSurrender_Click(object sender, EventArgs e)
        {
            if (World.Player == Attacker)
                BattleResult = BattleResult.Lost;
            else
                BattleResult = BattleResult.Won;

            this.Close();
        }
    }
}
