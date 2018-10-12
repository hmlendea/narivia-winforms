using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Narivia.Game;

namespace Narivia.Battles
{
    public enum BattleResult
    {
        Won,
        Lost
    }

    class Battle
    {
        public static BattleResult Start(ref World world, int attackerID, int defenderID, int regionID)
        {
            if (world.Player == attackerID || world.Player == defenderID)
                return frmBattle.ShowBox(ref world, attackerID, defenderID, regionID);
            else
            {
                Random rnd = new Random();

                while (world.Faction[attackerID].UnitsCount > 0 &&
                    world.Faction[defenderID].UnitsCount > 0)
                {
                    int attackerUnitID = rnd.Next(0, world.Unit.Count);
                    while (world.Faction[attackerID].Units[attackerUnitID] == 0)
                        attackerUnitID = rnd.Next(0, world.Unit.Count);

                    int defenderUnitID = rnd.Next(0, world.Unit.Count);
                    while (world.Faction[defenderID].Units[defenderUnitID] == 0)
                        defenderUnitID = rnd.Next(0, world.Unit.Count);

                    Battle.Fight(ref world, attackerID, defenderID, attackerUnitID, defenderUnitID);
                }

                if (world.Faction[attackerID].UnitsCount >
                    world.Faction[defenderID].UnitsCount)
                    return BattleResult.Won;
                else
                    return BattleResult.Lost;
            }
        }

        public static void Fight(ref World world, int attackerID, int defenderID, int attackerUnitID, int defenderUnitID)
        {
            int attackerUnitsLeft = Math.Max(0,
                (world.Unit[attackerUnitID].Health * world.Faction[attackerID].Units[attackerUnitID] + world.GetAttackBonus(attackerID) -
                world.Unit[defenderUnitID].Attack * world.Faction[defenderID].Units[defenderUnitID] + world.GetDefenceBonus(defenderID)) / 
                world.Unit[attackerUnitID].Health);

            int defenderUnitsLeft = Math.Max(0,
                (world.Unit[defenderUnitID].Health * world.Faction[defenderID].Units[defenderUnitID] + world.GetDefenceBonus(defenderID) -
                world.Unit[attackerUnitID].Attack * world.Faction[attackerID].Units[attackerUnitID] + world.GetAttackBonus(attackerID)) /
                world.Unit[defenderUnitID].Health);

            world.Faction[attackerID].Units[attackerUnitID] = attackerUnitsLeft;
            world.Faction[defenderID].Units[defenderUnitID] = defenderUnitsLeft;
        }
    }
}
