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
        public Wolf()
        {
            Name = "Wolf";
            GoldPcs = 0;
            MaxHealthPts = 14;
            MaxEnergyPts = 6;
            MaxStrenght = 6;
            MaxDexterity = 10;
            MaxMagic = 3;
            DiceRolls = 1;
            DiceSides = 4;
            BonusAtk = -1;
            DefensePts = 0;
        }
    }
}
