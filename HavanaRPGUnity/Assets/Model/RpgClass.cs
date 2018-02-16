using System;
using System.Collections.Generic;
using HavanaRPG.Model.Weapons;
using HavanaRPG.Model.Spells;
using HavanaRPG.Model.Skills;
using HavanaRPG.Model.Armors;
using HavanaRPG.Model.Items;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using UnityEngine;

namespace HavanaRPG.Model
{
    class RpgClass : MonoBehaviour
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
        public decimal InitialAlignment { get; set; }
        public List<Item> InitialItens { get; set; }
        public List<Ability> InitialSkills { get; set; }
        public List<Ability> InitialSpells { get; set; }
        public decimal HpPerLevel { get; set; }
        public decimal EpPerLevel { get; set; }
        public Sprite ImgSource { get; set; }

        public RpgClass()
        {
            InitialItens = new List<Item>();
            InitialSkills = new List<Ability>();
            InitialSpells = new List<Ability>();
        }

        public override string ToString()
        {
            var stringReturn = "";
            stringReturn += 
                "Initial Strenght: " + InitialStrenght + Environment.NewLine +
                "Initial Magic: " + InitialMagic + Environment.NewLine +
                "Initial Dexterity: " + InitialDexterity + Environment.NewLine +
                "Initial Creativity: " + InitialCreativity + Environment.NewLine +
                "Initial Winsdom: " + InitialWinsdom + Environment.NewLine +
                "HP: " + InitialHP + Environment.NewLine +
                "EP: " + InitialEP + Environment.NewLine +
                "Every Level Up gains: " + HpPerLevel + " HP and " + EpPerLevel + " EP" + Environment.NewLine +
                "Initial Gold Coins: " + InitialGold + Environment.NewLine;
            if (InitialItens.Count > 0)
            {
                stringReturn += Environment.NewLine;
                stringReturn += "Starting Itens: ";
                foreach (var item in InitialItens)
                {
                    stringReturn += item.ItemName + "; ";
                }
            }

            if (InitialSkills.Count > 0)
            {
                stringReturn += Environment.NewLine;
                stringReturn += "Starting Skills: ";
                foreach (var skill in InitialSkills)
                {
                    stringReturn += skill.AbilityName + "; ";
                }
            }

            if (InitialSpells.Count > 0)
            {
                stringReturn += Environment.NewLine;
                stringReturn += "Starting Spells: ";
                foreach (var spell in InitialSpells)
                {
                    stringReturn += spell.AbilityName + "; ";
                }
            }
            
            return stringReturn;
        }

        public string ToDescription()
        {
            var desc = "";
            desc += ClassName.ToString().ToUpper() + Environment.NewLine + Environment.NewLine +
                 ClassDescription + Environment.NewLine;
            return desc;
        }
    }
}
