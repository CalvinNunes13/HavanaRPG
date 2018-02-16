using HavanaRPG.Controller;
using HavanaRPG.Model.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace HavanaRPG.Model
{
    public class Player : MonoBehaviour
    {
        public string Name { get; set; }
        public HavanaLib.raceNames Race { get; set; }
        public HavanaLib.ClassNames PlayerClass { get; set; }
        public HavanaLib.Gender PlayerSex { get; set; }
        public HavanaLib.PastHistories PlasyerHistory { get; set; }
        public string CallTitle { get; set; }
        public decimal Alignment { get; set; }
        public decimal Experience { get; set; }
        public decimal PlayerLevel { get; set; }
        public decimal ExpToNextLevel { get; set; }

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
        public decimal Creativity { get; set; }
        public decimal MaxCreativity { get; set; }
        public decimal Winsdom { get; set; }
        public decimal MaxWinsdom { get; set; }

        public decimal GoldPcs { get; set; }
        public List<Item> Equipments { get; set; }
        public List<Item> BackpackEquips { get; set; }
        public Item HandOne { get; set; }
        public Item HandTwo { get; set; }
        public Item BodyArmor { get; set; }
        public Item HeadArmor { get; set; }
        public Item FootArmor { get; set; }

        public decimal WeigthCap { get; set; }
        public decimal WeigthCarrying { get; set; }
        public decimal WeigthCapRemaining { get; set; }
        public decimal PhysicalAtkPoints { get; set; }
        public decimal MagicalAtkPoints { get; set; }
        public decimal Armor { get; set; }
        public decimal DefensePts { get; set; }
        public decimal CurrentDefPts { get; set; }

        public List<Ability> Skills { get; set; }
        public List<Ability> Spells { get; set; }
        public List<Quest> OpenQuests { get; set; }
        public List<Quest> CompletedQuests { get; set; }
        public List<HavanaLib.StatusNames> StatusEffects { get; set; }
        public Location PlayerLocation { get; set; }
        public bool HasLeveledUp { get; set; }
        public decimal LevelsAwaiting { get; set; }

        public Player(string name, HavanaLib.ClassNames playerClass, HavanaLib.Gender gender)
        {
            Equipments = new List<Item>();
            BackpackEquips = new List<Item>();
            Skills = new List<Ability>();
            Spells = new List<Ability>();
            OpenQuests = new List<Quest>();
            CompletedQuests = new List<Quest>();
            StatusEffects = new List<HavanaLib.StatusNames>();

            Name = HavanaLib.ToProperCase(name);
            PlayerClass = playerClass;
            PlayerSex = gender;
            PlayerLevel = 1;
            Experience = 0;
            PlayerLocation = new Location();

            if (PlayerSex == HavanaLib.Gender.Male)
            {
                CallTitle = "Sir";
            }
            else if (PlayerSex == HavanaLib.Gender.Female)
            {
                CallTitle = "Lady";
            }                       

            HasLeveledUp = false;
            LevelsAwaiting = 0;
        }

        public virtual void SetFirstDefaults()
        {
            GameplayLib.SetDataByPlayerClass(PlayerClass);
            WeigthCap = Math.Floor(Strenght * 10);
            PlayerLocation = GameController.leto;

            AdjustCarryingWeight();

            CurrentDefPts = DefensePts;
            EnergyPts = MaxEnergyPts;
            HealthPts = MaxHealthPts;
            Dexterity = MaxDexterity;
            Strenght = MaxStrenght;
            Magic = MaxMagic;

            PhysicalAtkPoints = Math.Floor(Strenght / 3);
            MagicalAtkPoints = Math.Floor(Magic / 3);
            ExpToNextLevel = GameplayLib.UpdateReturnXpNextLevel(PlayerLevel, false);
        }

        public virtual void AdjustCarryingWeight()
        {
            if (BackpackEquips != null && BackpackEquips.Count > 0)
            {
                decimal carrying = 0;
                foreach (var item in BackpackEquips)
                {
                    carrying += item.Weight;
                }
                WeigthCarrying = carrying;
                WeigthCapRemaining = WeigthCap - WeigthCarrying;
                GameplayLib.CheckPlayerCarryingWeight();
            }
        }

        public virtual void UpdateStatsByEffects()
        {
            if (StatusEffects != null && StatusEffects.Count > 0)
            {
                foreach (var effect in StatusEffects)
                {
                    if (effect == HavanaLib.StatusNames.Slow)
                    {
                        GameplayLib.CutPlayerStats();
                    }

                    if (effect == HavanaLib.StatusNames.Blind)
                    {
                    }

                    if (effect == HavanaLib.StatusNames.Confused)
                    {
                    }
                }
            }
        }

        public virtual void UpdateAllAttackingStats()
        {
            PhysicalAtkPoints = Math.Floor(Strenght / 3);
            MagicalAtkPoints = Math.Floor(Magic / 3);
        }

        public virtual void OnDie()
        {
            HavanaLib.GameOver();
        }

        public virtual void OnLevelUp()
        {
            GameplayLib.ShowLogStatusMsg(Name + " leveled up!", true);
            PlayerLevel++;
            LevelsAwaiting++;
            HasLeveledUp = true;
        }

        public virtual void OnXpGain(decimal xp)
        {
            GameplayLib.UpdateNewXp(xp);
        }

        public virtual void CalculateDefenseByArmor()
        {
            if (Armor > 3)
            {
                decimal def = 0;
                def = Math.Floor(Armor / 3);
                DefensePts = def;
            }
            else
            {
                DefensePts = 0;
            }
        }
    }
}
