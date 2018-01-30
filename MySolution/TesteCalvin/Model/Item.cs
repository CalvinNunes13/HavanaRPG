using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    public class Item
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal DiceRolls { get; set; }
        public decimal DiceSides { get; set; }
        public int AttackPts { get; set; }
        public int BonusValue { get; set; }
        public int ArmorPts { get; set; }
        public int DefensePts { get; set; }
        public int EnergyCost { get; set; }
        public int RequiredLvl { get; set; }
        public decimal BuyValue { get; set; }
        public decimal SellValue { get; set; }
        public HavanaLib.Elements Element1 { get; set; }
        public HavanaLib.Elements Element2 { get; set; }
        public HavanaLib.Elements Element3 { get; set; }
        public List<HavanaLib.Elements> EquipElements { get; set; }
        public List<HavanaLib.ClassNames> ExcludedClasses {get; set;}
        public HavanaLib.AdvDvd Advantage { get; set; }
        public HavanaLib.AdvDvd Disadvantage { get; set; }
        public List<Item> CraftIngredients { get; set; }
        public bool HasSpecialEffect { get; set; }

        public Item()
        {
            ItemName = "";
            Description = "";
            DiceRolls = 1;
            DiceSides = 4;
            AttackPts = 0;
            BonusValue = 0;
            ArmorPts = 0;
            DefensePts = 0;
            EnergyCost = 0;
            RequiredLvl = 0;
            BuyValue = 1;
            SellValue = Math.Floor(BuyValue / 2);
            Element1 = HavanaLib.Elements.Physical;
            EquipElements.Add(Element1);
            EquipElements.Add(Element2);
            EquipElements.Add(Element3);
            HasSpecialEffect = false;
        }        

        public virtual void OnEquiped()
        {
            HavanaLib.UpdateSingleEquipmentValues(ArmorPts, DefensePts);
        }

        public virtual void OnUnequiped()
        {
            decimal negativeArm = ArmorPts * -1;
            decimal negativeDef = DefensePts * -1;
            HavanaLib.UpdateSingleEquipmentValues(negativeArm, negativeDef);
        }

        public virtual void OnUse()
        {

        }

        public virtual void OnSold()
        {

        }

        public virtual void OnSpecialEffect()
        {

        }

        public virtual void OnCrafted()
        {

        }

        public virtual void OnBattleUse()
        {

        }
    }
}
