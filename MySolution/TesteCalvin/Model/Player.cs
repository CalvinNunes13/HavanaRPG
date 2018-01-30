using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCalvin.Model;

namespace HavanaRPG.Model
{
    public class Player
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string PlayerClass { get; set; }
        public HavanaLib.Sex PlayerSex { get; set; }
        public string FormatCall { get; set; }
        public decimal Alignment { get; set; }
        public decimal Experience { get; set; }
        public decimal PlayerLevel { get; set; }

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

        public Player()
        {
            if (PlayerSex == HavanaLib.Sex.Male)
            {
                FormatCall = "Sir";
            }
            else if (PlayerSex == HavanaLib.Sex.Female)
            {
                FormatCall = "Lady";
            }

            PlayerLevel = 1;
            Experience = 0;
            GoldPcs = 0;
            WeigthCarrying = 0;
            Armor = 0;
            DefensePts = 0;
            CurrentDefPts = DefensePts;
            EnergyPts = MaxEnergyPts;
            HealthPts = MaxHealthPts;
            Dexterity = MaxDexterity;
            Strenght = MaxStrenght;
            Magic = MaxMagic;
            PhysicalAtkPoints = Math.Floor(Strenght / 3);
            MagicalAtkPoints = Math.Floor(Magic / 3);
            WeigthCap = Math.Floor(Strenght * 10);
            HasLeveledUp = false;
            LevelsAwaiting = 0;
        }

        public virtual void OnDie()
        {
            HavanaLib.GameOver();
        }

        public virtual void OnLevelUp()
        {
            PlayerLevel++;
            LevelsAwaiting++;
            HasLeveledUp = true;
        }

        public virtual void OnXpGain(int xp)
        {
            HavanaLib.UpdateNewXp(xp);
        }
    }
}
