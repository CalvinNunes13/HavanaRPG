using HavanaRPG.Controller;
using HavanaRPG.Model.RpgClasses;
using HavanaRPG.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    public class GameplayLib
    {
        //Global Definitions//
        public static string KingdomName = "Havana Kingdom";
        public static int GameDateDay = 1;
        public static int GameDateMonth = 1;
        public static int GameDateYear = 411;
        public static decimal CreaturesKilled = 0;
        public static HavanaLib.DayTime TimeofDay = HavanaLib.DayTime.Morning;
        public static Player GamePlayer = new Player("", HavanaLib.ClassNames.None, HavanaLib.Gender.None);

        //Game Options//
        public static decimal DiceShowTime = 2000;


        //Game Functions//
        public static void RunGameTime()
        {
            HavanaLib.RunLoopTimer(() => AdvanceDayTime(), TimeSpan.FromSeconds(10));
        }

        //retorna um valor aleatório com base em um dado de determinados lados
        public static decimal RollDice(decimal diceSides)
        {
            var n = RollDice(diceSides, 0, false);
            return n;
        }

        public static decimal RollDice(decimal diceSides, decimal bonus)
        {
            var n = RollDice(diceSides, bonus, true);
            return n;
        }

        public static decimal RollDice(decimal diceSides, decimal bonus, bool returnWithBonus)
        {
            var min = 1;
            var max = (int)diceSides;
            decimal diceValue = 0;

            var randomValue = new Random();
            diceValue = randomValue.Next(min, max);

            if (returnWithBonus && bonus > 0)
            {
                diceValue = ReturnWithBonus(diceValue, bonus);
            }

            return diceValue;
        }

        //---- AO INICIAR JOGO NOVO - Adiciona todos dados iniciais do player baseado em uma classe --------//
        public static void SetDataByPlayerClass(HavanaLib.ClassNames playerClass)
        {
            RpgClass rpgClass;
            switch (playerClass)
            {
                case HavanaLib.ClassNames.Warrior:
                    rpgClass = new WarriorClass();
                    break;

                case HavanaLib.ClassNames.Sorcerer:
                    rpgClass = new SorcererClass();
                    break;

                case HavanaLib.ClassNames.Druid:
                    rpgClass = new DruidClass();
                    break;

                case HavanaLib.ClassNames.Paladin:
                    rpgClass = new PaladinClass();
                    break;

                case HavanaLib.ClassNames.Monk:
                    rpgClass = new MonkClass();
                    break;

                case HavanaLib.ClassNames.Archer:
                    rpgClass = new ArcherClass();
                    break;

                case HavanaLib.ClassNames.Thief:
                    rpgClass = new ThiefClass();
                    break;

                default:
                    rpgClass = new RpgClass();
                    break;
            }
            GamePlayer.MaxStrenght = rpgClass.InitialStrenght;
            GamePlayer.MaxMagic = rpgClass.InitialMagic;
            GamePlayer.MaxDexterity = rpgClass.InitialDexterity;
            GamePlayer.MaxCreativity = rpgClass.InitialCreativity;
            GamePlayer.MaxWinsdom = rpgClass.InitialWinsdom;
            GamePlayer.MaxHealthPts = rpgClass.InitialHP;
            GamePlayer.MaxEnergyPts = rpgClass.InitialEP;
            GamePlayer.GoldPcs = rpgClass.InitialGold;
            if (rpgClass.InitialItens.Count > 0)
            {
                foreach (var item in rpgClass.InitialItens)
                {
                    GamePlayer.BackpackEquips.Add(item);
                }
            }
            if (rpgClass.InitialSkills.Count > 0)
            {
                foreach (var skill in rpgClass.InitialSkills)
                {
                    GamePlayer.Skills.Add(skill);
                }
            }
            if (rpgClass.InitialSpells.Count > 0)
            {
                foreach (var spell in rpgClass.InitialSpells)
                {
                    GamePlayer.Spells.Add(spell);
                }
            }

        }

        //toDISPLAY LIB - Retorno de valores para display como string
        public static string ReturnPlayerLocationToDisplay()
        {
            var localString = "";
            try
            {
                var local = GamePlayer.PlayerLocation;
                if (local == null)
                {
                    localString = "Somewhere";
                }
                else
                {
                    localString = local.LocalName.ToString();
                }
            }
            catch (Exception ex)
            {
                localString = "Somewhere";
            }
            return localString;
        }

        public static string ReturnPlayerHPtoDisplay()
        {
            var MaxHP = GamePlayer.MaxHealthPts.ToString();
            var cHP = GamePlayer.HealthPts.ToString();
            return cHP + " / " + MaxHP;
        }

        public static string ReturnPlayerEPtoDisplay()
        {
            var MaxEP = GamePlayer.MaxEnergyPts.ToString();
            var cEP = GamePlayer.EnergyPts.ToString();
            return cEP + " / " + MaxEP;
        }

        public static string ReturnPlayerGoldToDisplay()
        {
            var gold = GamePlayer.GoldPcs.ToString();
            return gold;
        }

        public static string ReturnPlayerLevelToDisplay()
        {
            var lvl = GamePlayer.PlayerLevel.ToString();
            return lvl;
        }

        public static string ReturnPlayerXPtoDisplay()
        {
            var exp = GamePlayer.Experience.ToString();
            return exp;
        }

        public static string ReturnPlayerNameToDisplay()
        {
            var name = GamePlayer.Name.ToString();
            return name;
        }
       
        //Ajusta a barra de experiência da tela
        public static void AdjustExperienceBar()
        {
            UpdateReturnXpNextLevel(GamePlayer.PlayerLevel, true);
            decimal xpToLvl = GamePlayer.ExpToNextLevel;
            decimal cXP = GamePlayer.Experience;
            ViewsController._MainContainerView.pb_ExpBar.Value = 0;
            ViewsController._MainContainerView.pb_ExpBar.Maximum = (int)xpToLvl;            
            ViewsController._MainContainerView.pb_ExpBar.Step = (int)cXP;
            ViewsController._MainContainerView.pb_ExpBar.PerformStep();
            ViewsController._MainContainerView.pb_ExpBar.ToolTipText = "Experience: " + cXP;
        }
        //------------ FIM ToDisplay LIB -------------//

        //Retorna valor com base em um bonus extra
        public static decimal ReturnWithBonus(decimal diceValue, decimal bonusValue)
        {
            decimal finalValue = 0;
            if (bonusValue < 0)
            {
                finalValue = diceValue - (bonusValue * 1);
            }
            else
            {
                finalValue = diceValue + bonusValue;
            }

            if (finalValue < 0)
            {
                return 0;
            }
            return finalValue;
        }

        //Ajusta todos valores de Atk, Def e Armor do player com base nos equipamentos
        public static void UpdateAllEquipmentValues()
        {
            var equips = GamePlayer.Equipments;
            decimal totalArm = 0;
            decimal sumDef = 0;
            decimal totalDef = 0;
            for (var i = 0; i < equips.Count; i++)
            {
                var equip = equips[i];
                totalArm += equip.ArmorPts;
                totalDef += equip.DefensePts;
            }

            sumDef = Math.Floor(totalArm / 3);
            totalDef += sumDef;

            if (totalDef < 0)
            {
                totalDef = 0;
            }
            if (totalArm < 0)
            {
                totalArm = 0;
            }

            GamePlayer.DefensePts = totalDef;
            GamePlayer.Armor = totalArm;
        }

        //Modifica a Arm e def do player com base em apenas um item
        public static void UpdateSingleEquipmentValues(decimal itemArm)
        {
            UpdateSingleEquipmentValues(itemArm, 0);
        }

        public static void UpdateSingleEquipmentValues(decimal itemArm, decimal itemDef)
        {
            decimal totalArm = GamePlayer.Armor;
            decimal totalDef = GamePlayer.DefensePts;

            if (totalArm < 0)
            {
                totalArm = 0;
            }

            GamePlayer.Armor = totalArm + itemArm;
            if (GamePlayer.Armor < 0)
            {
                GamePlayer.Armor = 0;
            }
            var newDef = (GamePlayer.Armor / 3) + itemDef;
            if (newDef < 0)
            {
                newDef = 0;
            }

            GamePlayer.DefensePts = newDef;
        }

        //Ajusta o XP atual com base no xp recebido
        public static void UpdateNewXp(decimal xp)
        {
            var currentXP = GamePlayer.Experience;
            var currentLvl = GamePlayer.PlayerLevel;
            var nextLevel = currentLvl + 1;
            var xpToNextLevel = UpdateReturnXpNextLevel(currentLvl, true);
            var newXp = currentXP + xp;
            var remainingXp = newXp;
            if (newXp >= xpToNextLevel)
            {
                remainingXp = newXp - xpToNextLevel;
                if (remainingXp < 0)
                {
                    remainingXp = 0;
                }
                GamePlayer.OnLevelUp();
                GamePlayer.Experience = 0;
                AdjustExperienceBar();
                UpdateNewXp((int)remainingXp);
            }
            else
            {
                GamePlayer.Experience = newXp;
                AdjustExperienceBar();
            }

        }

        //Retorna o valor de xp para o proximo level
        public static decimal UpdateReturnXpNextLevel(decimal currentLevel, bool updateInPlayer)
        {
            var xpTable = ExperienceTable.XpTable;
            var xpToNextLevel = xpTable[(int)currentLevel];
            if (updateInPlayer)
            {
                GamePlayer.ExpToNextLevel = xpToNextLevel;
            }
            return xpToNextLevel;
        }

        //checa se player tem gold comparado a um valor
        public static bool CheckPlayerHaveGold(decimal value)
        {
            if (GamePlayer.GoldPcs < value)
            {
                return false;
            }
            return true;
        }

        //faz a compra ou venda de algo com gold do player
        public static void PlayerGoldTransaction(decimal value, string action) //buy or sell
        {
            if (action == "buy")
            {
                if (CheckPlayerHaveGold(value))
                {
                    var goldRemain = GamePlayer.GoldPcs - value;
                    if (goldRemain < 0)
                    {
                        goldRemain = 0;
                    }
                    GamePlayer.GoldPcs = goldRemain;
                }
            }
            else
            {
                var goldRemain = GamePlayer.GoldPcs + value;
                GamePlayer.GoldPcs = goldRemain;
            }
        }

        //Restabelece vida ou ep do player
        public static void RestorePlayer(decimal diceSides, decimal diceRolls, decimal bonusValue, string type) //type = hp ou ep
        {
            decimal totalValue = 0;
            string display = "";
            string displayPoints = "";
            var msg = "";

            for (var i = 0; i < diceRolls; i++)
            {
                var value = RollDice(diceSides);
                HavanaLib.ShowDiceOnScreen(value);
                totalValue += value;
                if (HavanaLib.IsEmpty(msg))
                {
                    msg += "Rolled: ";
                }
                else
                {
                    msg += " | ";
                }
                msg += value;
                Thread.Sleep(2500); //2,5 segundos 
            }

            if (bonusValue > 0)
            {
                msg += " Bonus: " + bonusValue;
            }
            totalValue += bonusValue;

            if (type == "ep")
            {
                display = "ep";
                BattleLib.RealPlayerGainEnergy(totalValue);
                displayPoints = GamePlayer.EnergyPts.ToString();
            }
            else
            {
                display = "hp";
                BattleLib.RealPlayerGainHp(totalValue);
                displayPoints = GamePlayer.HealthPts.ToString();
            }

            msg += "\n" + "Restored " + totalValue + display;
            msg += "\n" + "Current " + display.ToUpper() + ": " + displayPoints;
            GameplayLib.ShowLogStatusMsg(msg);
        }

        //Adiciona efeito no player que corta os stats pela metade
        public static void CutPlayerStats()
        {
            Math.Floor(GamePlayer.Strenght /= 2);
            Math.Floor(GamePlayer.Dexterity /= 2);
            Math.Floor(GamePlayer.Magic /= 2);
            Math.Floor(GamePlayer.Creativity /= 2);
            Math.Floor(GamePlayer.Winsdom /= 2);
            GamePlayer.UpdateAllAttackingStats();
        }

        //Verifica se o player esta carregando mais peso do que pode
        public static void CheckPlayerCarryingWeight()
        {
            if (GamePlayer.WeigthCapRemaining < 0)
            {
                ShowLogStatusMsg("You are carrying more weight than you can! All your stats are halved.");
                GamePlayer.StatusEffects.Add(HavanaLib.StatusNames.Slow);
                GamePlayer.UpdateStatsByEffects();
            }
        }

        //Adiciona log de acontecimento na barra de status da view
        public static void ShowLogStatusMsg(string msg)
        {
            ShowLogStatusMsg(msg, false);
        }

        public static void ShowLogStatusMsg(string msg, bool featured)
        {
            if (featured)
            {
                msg = msg.ToUpper();
            }

            ViewsController._MainContainerView.StatusLogBox.Text += "\n" + msg;
        }

        //Avança o período do dia se for preciso, avança um dia na data do jogo
        public static void AdvanceDayTime()
        {
            var actualPeriod = TimeofDay;
            if (actualPeriod == HavanaLib.DayTime.Morning)
            {
                TimeofDay = HavanaLib.DayTime.Afternoon;
            }
            else if (actualPeriod == HavanaLib.DayTime.Afternoon)
            {
                TimeofDay = HavanaLib.DayTime.Night;
            }
            else
            {
                TimeofDay = HavanaLib.DayTime.Morning;
                GameDateDay++;
                if (GameDateDay > 30)
                {
                    GameDateDay = 1;
                    GameDateMonth++;
                    if (GameDateMonth > 12)
                    {
                        GameDateMonth = 1;
                        GameDateYear++;
                    }
                }
            }
            var newDate = ReturnDisplayDateAndTime();
            AdjustDayTimeDisplay(newDate);
        }

        //Retorna string da visualização da data do jogo
        public static string ReturnDisplayDateAndTime()
        {
            string displayDate = "";
            displayDate += TimeofDay.ToString() + " - ";
            displayDate += GameDateDay.ToString() + "/";
            displayDate += GameDateMonth.ToString() + "/";
            displayDate += GameDateYear.ToString();
            return displayDate;
        }

        public static void AdjustDayTimeDisplay(string date)
        {
            ViewsController._MainContainerView.txt_dateTime.Text = null;
            ViewsController._MainContainerView.txt_dateTime.Text = date;
            var txtTest = ViewsController._MainContainerView.txt_dateTime.Text;
        }
    }
}
