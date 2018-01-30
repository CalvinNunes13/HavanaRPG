﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    class Creature
    {
        public string Name { get; set; }
        public decimal GoldPcs { get; set; }
        public decimal HealthPts { get; set; }
        public decimal MaxHealthPts { get; set; }
        public decimal EnergyPts { get; set; }
        public decimal MaxEnergyPts { get; set; }
        public decimal Strenght { get; set; }
        public decimal MaxStrenght { get; set; }
        public decimal Dexterity { get; set; }
        public decimal MaxDexterity { get; set; }
        public decimal Magic { get; set; }
        public decimal MaxMagic { get; set; }
        public string DiceStyle { get; set; }
        public decimal BonusAtk { get; set; }

        public decimal PhysicalAtkPoints { get; set; }
        public decimal MagicalAtkPoints { get; set; }
        public decimal DefensePts { get; set; }
        public List<Item> Recompenses { get; set; }

        public Creature() {
            EnergyPts = MaxEnergyPts;
            HealthPts = MaxHealthPts;
            Dexterity = MaxDexterity;
            Strenght = MaxStrenght;
            Magic = MaxMagic;
            PhysicalAtkPoints = Math.Floor(Strenght / 3);
            MagicalAtkPoints = Math.Floor(Magic / 3);
        }

        public virtual void OnDie()
        {

        }

        public virtual void OnBattleStart()
        {

        }
    }
}