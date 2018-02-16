using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace HavanaRPG.Model
{
    public class Item : MonoBehaviour
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal DiceRolls { get; set; }
        public decimal DiceSides { get; set; }
        public decimal Weight { get; set; }
        public HavanaLib.ItemTypes Type { get; set; }
        public int AttackPts { get; set; }
        public int BonusValue { get; set; }
        public int ArmorPts { get; set; }
        public int DefensePts { get; set; }
        public int EnergyCost { get; set; }
        public int RequiredLvl { get; set; }
        public decimal BuyValue { get; set; }
        public decimal SellValue { get; set; }
        public List<HavanaLib.Elements> EquipElements { get; set; }
        public List<HavanaLib.ClassNames> ExcludedClasses { get; set; }
        public HavanaLib.AdvDvd Advantage { get; set; }
        public HavanaLib.AdvDvd Disadvantage { get; set; }
        public List<Item> CraftIngredients { get; set; }
        public bool HasSpecialEffect { get; set; }
        public Image ImgSource { get; set; }

        public Item()
        {
            EquipElements = new List<HavanaLib.Elements>();
            ExcludedClasses = new List<HavanaLib.ClassNames>();

            ItemName = "";
            Description = "";
            Type = HavanaLib.ItemTypes.None;
            DiceRolls = 1;
            DiceSides = 4;
            Weight = 0;
            AttackPts = 0;
            BonusValue = 0;
            ArmorPts = 0;
            DefensePts = 0;
            EnergyCost = 0;
            RequiredLvl = 0;
            BuyValue = 1;
            SellValue = Math.Floor(BuyValue / 2);
            HasSpecialEffect = false;
        }

        public virtual void OnEquiped()
        {
            GameplayLib.UpdateSingleEquipmentValues(ArmorPts, DefensePts);
        }

        public virtual void OnUnequiped()
        {
            decimal negativeArm = ArmorPts * -1;
            decimal negativeDef = DefensePts * -1;
            GameplayLib.UpdateSingleEquipmentValues(negativeArm, negativeDef);
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
