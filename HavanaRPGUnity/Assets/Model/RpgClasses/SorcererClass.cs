using HavanaRPG.Model.Armors;
using HavanaRPG.Model.Items;
using HavanaRPG.Model.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace HavanaRPG.Model.RpgClasses
{
    class SorcererClass : RpgClass
    {
        public SorcererClass()
        {
            ClassName = HavanaLib.ClassNames.Sorcerer;
            ClassDescription = "";
            InitialStrenght = 3;
            InitialMagic = 10;
            InitialDexterity = 6;
            InitialCreativity = 8;
            InitialWinsdom = 7;
            InitialHP = 17;
            InitialEP = 28;
            HpPerLevel = 2;
            EpPerLevel = 5;
            var aSimpleCloth = new SimpleClothes();
            InitialItens.Add(aSimpleCloth);

            var iPotion = new SmallHealthPotion();
            InitialItens.Add(iPotion);
            InitialGold = 5;
            InitialAlignment = 0;
            ImgSource = Resources.Load<Sprite>("Graphics/anao") as Sprite;


        }
    }
}
