﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HavanaRPG.Model.Items
{
    class SmallHealthPotion : Item
    {
        public SmallHealthPotion()
        {
            ItemName = "Small Health Potion";
            Description = "Restores a small amount of HP \n 1d6+1";
            DiceSides = 6;
            DiceRolls = 1;
            BonusValue = 1;
        }

        public override void OnUse()
        {
            base.OnUse();
            GameplayLib.RestorePlayer(DiceSides, DiceRolls, BonusValue, "hp");
        }               

    }
}
