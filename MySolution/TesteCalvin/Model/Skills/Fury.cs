using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model.Skills
{
    class Fury : Ability
    {
        public Fury()
        {
            AbilityName = "Fury";
            RequiredLvl = 1;
            DiceRolls = 0;
            DiceSides = 0;
            DiceBonusPts = 1;
            EnergyCost = 5;
            Description = "The user focus all his angry to hit the enemy with more power in the next attack \n +1 bonus to all physical attacks in a battle";
            Elements.Add(HavanaLib.Elements.Physical);
            HasBasicEffect = true;
        }

        public override void BasicEffect()
        {
            base.BasicEffect();
            BattleLib.RealPlayerLoseEnergy(EnergyCost);
            BattleLib.IncreasePlayerStatTemp(DiceBonusPts, HavanaLib.StatsNames.Strenght);
        }
    }
}
