using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HavanaRPG.Model;

namespace HavanaRPG.Model.Weapons
{
    class Club : Item
    {
        new string ItemName = "Club";
        new string Description = "A very simple weapon made with wood.";
        new decimal BuyValue  = 7;
        new string DiceStyle = "1d4";
        new int BonusAtkPts = -1;
    }
}
