using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HavanaRPG.Model;

namespace HavanaRPG.Model.Weapons
{
    class Club : Item
    {
        public Club() {
            ItemName = "Club";
            Description = "A very simple weapon made with wood.";
            BuyValue = 7;
            DiceRolls = 1;
            DiceSides = 4;
            BonusValue = -1;
        }
    }
}
