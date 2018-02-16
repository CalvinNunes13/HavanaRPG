using HavanaRPG.Controller;
using HavanaRPG.Model.RpgClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace HavanaRPG.Model
{
    public class GameplayLib : MonoBehaviour
    {
        //Global Definitions//
        public static string KingdomName = "Havana Kingdom";
        public static int GameDateDay = 1;
        public static int GameDateMonth = 1;
        public static int GameDateYear = 411;
        public static decimal CreaturesKilled = 0;
        public static HavanaLib.DayTime TimeofDay = HavanaLib.DayTime.Morning;
        
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

            var randomValue = new System.Random();
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
            GameController.GamePlayer.MaxStrenght = rpgClass.InitialStrenght;
            GameController.GamePlayer.MaxMagic = rpgClass.InitialMagic;
            GameController.GamePlayer.MaxDexterity = rpgClass.InitialDexterity;
            GameController.GamePlayer.MaxCreativity = rpgClass.InitialCreativity;
            GameController.GamePlayer.MaxWinsdom = rpgClass.InitialWinsdom;
            GameController.GamePlayer.MaxHealthPts = rpgClass.InitialHP;
            GameController.GamePlayer.MaxEnergyPts = rpgClass.InitialEP;
            GameController.GamePlayer.GoldPcs = rpgClass.InitialGold;
            if (rpgClass.InitialItens.Count > 0)
            {
                foreach (var item in rpgClass.InitialItens)
                {
                    GameController.GamePlayer.BackpackEquips.Add(item);
                }
            }
            if (rpgClass.InitialSkills.Count > 0)
            {
                foreach (var skill in rpgClass.InitialSkills)
                {
                    GameController.GamePlayer.Skills.Add(skill);
                }
            }
            if (rpgClass.InitialSpells.Count > 0)
            {
                foreach (var spell in rpgClass.InitialSpells)
                {
                    GameController.GamePlayer.Spells.Add(spell);
                }
            }

        }

        //toDISPLAY LIB - Retorno de valores para display como string
        public static string ReturnPlayerLocationToDisplay()
        {
            var localString = "";
            try
            {
                var local = GameController.GamePlayer.PlayerLocation;
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
            var MaxHP = GameController.GamePlayer.MaxHealthPts.ToString();
            var cHP = GameController.GamePlayer.HealthPts.ToString();
            return cHP + " / " + MaxHP;
        }

        public static string ReturnPlayerEPtoDisplay()
        {
            var MaxEP = GameController.GamePlayer.MaxEnergyPts.ToString();
            var cEP = GameController.GamePlayer.EnergyPts.ToString();
            return cEP + " / " + MaxEP;
        }

        public static string ReturnPlayerGoldToDisplay()
        {
            var gold = GameController.GamePlayer.GoldPcs.ToString();
            return gold;
        }

        public static string ReturnPlayerLevelToDisplay()
        {
            var lvl = GameController.GamePlayer.PlayerLevel.ToString();
            return lvl;
        }

        public static string ReturnPlayerXPtoDisplay()
        {
            var exp = GameController.GamePlayer.Experience.ToString();
            return exp;
        }

        public static string ReturnPlayerNameToDisplay()
        {
            var name = GameController.GamePlayer.Name.ToString();
            return name;
        }
       
        //Ajusta a barra de experiência da tela
        public static void AdjustExperienceBar()
        {
            UpdateReturnXpNextLevel(GameController.GamePlayer.PlayerLevel, true);
            decimal xpToLvl = GameController.GamePlayer.ExpToNextLevel;
            decimal cXP = GameController.GamePlayer.Experience;
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
            var equips = GameController.GamePlayer.Equipments;
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

            GameController.GamePlayer.DefensePts = totalDef;
            GameController.GamePlayer.Armor = totalArm;
        }

        //Modifica a Arm e def do player com base em apenas um item
        public static void UpdateSingleEquipmentValues(decimal itemArm)
        {
            UpdateSingleEquipmentValues(itemArm, 0);
        }

        public static void UpdateSingleEquipmentValues(decimal itemArm, decimal itemDef)
        {
            decimal totalArm = GameController.GamePlayer.Armor;
            decimal totalDef = GameController.GamePlayer.DefensePts;

            if (totalArm < 0)
            {
                totalArm = 0;
            }

            GameController.GamePlayer.Armor = totalArm + itemArm;
            if (GameController.GamePlayer.Armor < 0)
            {
                GameController.GamePlayer.Armor = 0;
            }
            var newDef = (GameController.GamePlayer.Armor / 3) + itemDef;
            if (newDef < 0)
            {
                newDef = 0;
            }

            GameController.GamePlayer.DefensePts = newDef;
        }

        //Ajusta o XP atual com base no xp recebido
        public static void UpdateNewXp(decimal xp)
        {
            var currentXP = GameController.GamePlayer.Experience;
            var currentLvl = GameController.GamePlayer.PlayerLevel;
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
                GameController.GamePlayer.OnLevelUp();
                GameController.GamePlayer.Experience = 0;
                AdjustExperienceBar();
                UpdateNewXp((int)remainingXp);
            }
            else
            {
                GameController.GamePlayer.Experience = newXp;
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
                GameController.GamePlayer.ExpToNextLevel = xpToNextLevel;
            }
            return xpToNextLevel;
        }

        //checa se player tem gold comparado a um valor
        public static bool CheckPlayerHaveGold(decimal value)
        {
            if (GameController.GamePlayer.GoldPcs < value)
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
                    var goldRemain = GameController.GamePlayer.GoldPcs - value;
                    if (goldRemain < 0)
                    {
                        goldRemain = 0;
                    }
                    GameController.GamePlayer.GoldPcs = goldRemain;
                }
            }
            else
            {
                var goldRemain = GameController.GamePlayer.GoldPcs + value;
                GameController.GamePlayer.GoldPcs = goldRemain;
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
                displayPoints = GameController.GamePlayer.EnergyPts.ToString();
            }
            else
            {
                display = "hp";
                BattleLib.RealPlayerGainHp(totalValue);
                displayPoints = GameController.GamePlayer.HealthPts.ToString();
            }

            msg += "\n" + "Restored " + totalValue + display;
            msg += "\n" + "Current " + display.ToUpper() + ": " + displayPoints;
            GameplayLib.ShowLogStatusMsg(msg);
        }

        //Adiciona efeito no player que corta os stats pela metade
        public static void CutPlayerStats()
        {
            Math.Floor(GameController.GamePlayer.Strenght /= 2);
            Math.Floor(GameController.GamePlayer.Dexterity /= 2);
            Math.Floor(GameController.GamePlayer.Magic /= 2);
            Math.Floor(GameController.GamePlayer.Creativity /= 2);
            Math.Floor(GameController.GamePlayer.Winsdom /= 2);
            GameController.GamePlayer.UpdateAllAttackingStats();
        }

        //Verifica se o player esta carregando mais peso do que pode
        public static void CheckPlayerCarryingWeight()
        {
            if (GameController.GamePlayer.WeigthCapRemaining < 0)
            {
                ShowLogStatusMsg("You are carrying more weight than you can! All your stats are halved.");
                GameController.GamePlayer.StatusEffects.Add(HavanaLib.StatusNames.Slow);
                GameController.GamePlayer.UpdateStatsByEffects();
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

            //ViewsController._MainContainerView.StatusLogBox.Text += "\n" + msg;
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
            GameController.Txt_MenuDateTime = GameObject.Find("Txt_MenuDateTime").GetComponent<Text>();
            GameController.Txt_MenuDateTime.text = date;
        }
    }
}
