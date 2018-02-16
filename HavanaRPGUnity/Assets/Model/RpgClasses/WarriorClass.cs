using HavanaRPG.Model.Skills;
using HavanaRPG.Model.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace HavanaRPG.Model.RpgClasses
{
    class WarriorClass : RpgClass
    {
        public WarriorClass()
        {
            ClassName = HavanaLib.ClassNames.Warrior;
            ClassDescription = "Warriors are known by their strenght and vitality. They focuses their abilities in strenghtful skills and powerful physical hits. The main purpose of a Warrior is acquire power and more vitality.";
            InitialStrenght = 10;
            InitialMagic = 3;
            InitialDexterity = 8;
            InitialCreativity = 7;
            InitialWinsdom = 6;
            InitialHP = 27;
            InitialEP = 12;
            HpPerLevel = 5;
            EpPerLevel = 2;
            var wClub = new Club();
            InitialItens.Add(wClub);

            var sFury = new Fury();
            InitialSkills.Add(sFury);
            InitialGold = 0;
            InitialAlignment = 0;

            ImgSource = Resources.Load<Sprite>("Graphics/humano") as Sprite;
        }
    }
}
