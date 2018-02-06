using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    public class Ability
    {
        public string AbilityName { get; set; }
        public string Description { get; set; }
        public string DiceStyle { get;  set; }
        public decimal RequiredLvl { get; set; }
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
        public decimal DiceBonusPts { get; set; }
        public decimal EnergyCost { get; set; }
        public decimal HealthCost { get; set; }
        public List<HavanaLib.Elements> Elements { get; set; }
        public bool HasBasicEffect { get; set; }
        public bool HasSpecialEffect { get; set; }
        public bool HasStatusModifier { get; set; }

        public Ability()
        {
            Elements = new List<HavanaLib.Elements>();
            AbilityName = "";
            Description = "";
            RequiredLvl = 0;
            DiceRolls = 0;
            DiceSides = 0;
            DiceBonusPts = 0;
            EnergyCost = 0;
            HealthCost = 0;
            DiceStyle = DiceRolls.ToString() + "d" + DiceSides.ToString();
            HasBasicEffect = false;
            HasSpecialEffect = false;
            HasStatusModifier = false;
        }

        public virtual void BasicEffect()
        {

        }

        public virtual void SpecialEffect()
        {

        }

        public virtual void AddRemoveStatus()
        {

        }
    }
}
