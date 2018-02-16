using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HavanaRPG.Model.Spells
{
    class MagicalCure : Ability
    {
        public MagicalCure()
        {
            AbilityName = "Magical Cure";
            RequiredLvl = 1;
            DiceRolls = 1;
            DiceSides = 6;
            DiceBonusPts = 1;
            EnergyCost = 4;
            Description = "The magical ability to cure yourself and restore a few amount of HP \n" + DiceStyle;
            Elements.Add(HavanaLib.Elements.Light);
            HasBasicEffect = true;
        }

        public override void BasicEffect()
        {
            base.BasicEffect();
            BattleLib.RealPlayerLoseEnergy(EnergyCost);
            GameplayLib.RestorePlayer(DiceSides, DiceRolls, DiceBonusPts, "hp");
        }
    }
}
