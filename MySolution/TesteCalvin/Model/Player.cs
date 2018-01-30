using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCalvin.Model;

namespace HavanaRPG.Model
{
    class Player
    {
        public static string Name = "";
        public static string Race = "";
        public static string PlayerClass = "";
        public static HavanaLib.Sex PlayerSex = HavanaLib.Sex.None;
        public static string FormatCall = "";
        public static decimal Alignment = 0;
        public static decimal Experience = 0;
        public static decimal PlayerLevel = 0;

        public static decimal HealthPts = 0;
        public static decimal MaxHealthPts = 0;
        public static decimal EnergyPts = 0;
        public static decimal MaxEnergyPts = 0;
        public static decimal Strenght = 0;
        public static decimal MaxStrenght = 0;
        public static decimal Dexterity = 0;
        public static decimal MaxDexterity = 0;
        public static decimal Magic = 0;
        public static decimal MaxMagic = 0;
        public static decimal Creativity = 0;
        public static decimal MaxCreativity = 0;
        public static decimal Winsdom = 0;
        public static decimal MaxWinsdom = 0;

        public static decimal GoldPcs = 0;
        public static List<Item> Equipments = new List<Item>();
        public static List<Item> BackpackEquips = new List<Item>();
        public static Item HandOne = new Item();
        public static Item HandTwo = new Item();
        public static Item BodyArmor = new Item();
        public static Item HeadArmor = new Item();
        public static Item FootArmor = new Item();

        public static decimal WeigthCap = 0;
        public static decimal WeigthCarrying = 0;
        public static decimal PhysicalAtkPoints = 0;
        public static decimal MagicalAtkPoints = 0;
        public static decimal Armor = 0;
        public static decimal DefensePts = 0;

        public List<Ability> Skills = new List<Ability>();
        public List<Ability> Spells = new List<Ability>();
        public List<Quest> OpenQuests = new List<Quest>();
        public List<Quest> CompletedQuests = new List<Quest>();

        public HavanaLib.Locations PlayerLocation = HavanaLib.Locations.Limbo;

        public Player()
        {
            if (PlayerSex == HavanaLib.Sex.Male)
            {
                formatCall = "Sir";
            }
            else if (PlayerSex == HavanaLib.Sex.Female)
            {
                formatCall = "Lady";
            }
        }

        public void OnDie()
        {
            HavanaLib.GameOver();
        }

        public static void OnLevelUp()
        {
            PlayerLevel = PlayerLevel + 1;
        }

        public static void OnXpGain(int xp)
        {
            HavanaLib.UpdateNewXp(xp);
        }
    }
}
