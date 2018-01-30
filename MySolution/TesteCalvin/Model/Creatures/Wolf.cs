using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HavanaRPG.Model;

namespace TesteCalvin.Model.Creatures
{
    class Wolf : Creature
    {
        new string Name = "Wolf";
        new decimal GoldPcs = 0;
        new decimal MaxHealthPts = 14;
        new decimal MaxEnergyPts = 6;
        new decimal MaxStrenght = 6;
        new decimal MaxDexterity = 10;
        new decimal MaxMagic = 3;
        new string DiceStyle = "1d4";
        new decimal BonusAtk = -1;

        new decimal DefensePts = 0;
        new List<Item> Recompenses;
    }
}
