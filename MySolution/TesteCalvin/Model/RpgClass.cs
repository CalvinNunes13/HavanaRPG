using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    class RpgClass
    {
        public HavanaLib.ClassNames ClassName { get; set; }
        public string ClassDescription { get; set; }
        public decimal InitialStrenght { get; set; }
        public decimal InitialMagic { get; set; }
        public decimal InitialDexterity { get; set; }
        public decimal InitialCreativity { get; set; }
        public decimal InitialWinsdom { get; set; }
        public decimal InitialHP { get; set; }
        public decimal InitialEP { get; set; }
        public decimal InitialGold { get; set; }
        public List<Item> InitialItens { get; set; }
        public List<Ability> InitialSkills { get; set; }
        public List<Ability> InitialSpells { get; set; }
        public decimal HpPerLevel { get; set; }
        public decimal EpPerLevel { get; set; }

        public RpgClass()
        {

        }

        public override string ToString()
        {
            var stringReturn = "";
            stringReturn += ClassName.ToString() + "\n\n" +
                 ClassDescription +
                "\nInitial Strenght: " + InitialStrenght +
                "\nInitial Magic: " + InitialMagic +
                "\nInitial Dexterity: " + InitialDexterity +
                "\nInitial Creativity: " + InitialCreativity +
                "\nInitial Winsdom: " + InitialWinsdom +
                "\nInitial HP: " + InitialHP +
                "\nInitial EP:" + InitialEP +
                "\nEvery Level Up gains: " + HpPerLevel + " HP and " + EpPerLevel + " EP" +
                "\nInitial Gold Coins: " + InitialGold;
            if (InitialItens.Count > 0)
            {
                stringReturn += "\n";
                foreach (var item in InitialItens)
                {
                    stringReturn += item.ItemName + "; ";
                }
            }

            if (InitialSkills.Count > 0)
            {
                stringReturn += "\n";
                foreach (var skill in InitialSkills)
                {
                    stringReturn += skill.AbilityName + "; ";
                }
            }

            if (InitialSpells.Count > 0)
            {
                stringReturn += "\n";
                foreach (var spell in InitialSpells)
                {
                    stringReturn += spell.AbilityName + "; ";
                }
            }
            
            return stringReturn;
        }
    }
}
