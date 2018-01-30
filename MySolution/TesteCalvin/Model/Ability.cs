using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCalvin.Model
{
    class Ability
    {
        public string AbilityName { get; set; }
        public string Description { get; set; }
        public decimal DiceRolls { get; set; }
        public decimal DiceSides { get; set; }
        public decimal BonusAtk { get; set; }
        public decimal BonusDef { get; set; }
        public decimal BonusHp { get; set; }
        public decimal BonusEp { get; set; }
        public decimal BonusStr { get; set; }
        public decimal BonusMag { get; set; }
        public decimal BonusDex { get; set; }
        public decimal BonusCre { get; set; }
        public decimal BonusWin { get; set; }
    }
}
