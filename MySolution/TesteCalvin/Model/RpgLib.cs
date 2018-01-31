using HavanaRPG.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    public class RpgLib
    {
        public static int GameDateDay = 1;
        public static int GameDateMonth = 1;
        public static int GameDateYear = 411;
        public static decimal CreaturesKilled = 0;
        public static HavanaLib.DayTime TimeofDay = HavanaLib.DayTime.Morning;
        public static Player GamePlayer = new Player();

        public static void RunGameTime()
        {
            HavanaLib.RunLoopTimer(AdvanceDayTime, new TimeSpan(60000)); //600000 = 10 minutos
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

        //Ajusta o XP com base no xp recebido
        public static void UpdateNewXp(decimal xp)
        {
            var currentXP = GamePlayer.Experience;
            var currentLvl = GamePlayer.PlayerLevel;
            var nextLevel = currentLvl + 1;
            var xpTable = ExperienceTable.XpTable;
            var xpToNextLevel = xpTable[(int)nextLevel - 1];
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
                UpdateNewXp((int)remainingXp);
            }
            else
            {
                GamePlayer.Experience = newXp;
            }
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
        public static void PlayerGoldTransaction(int value, string action) //buy or sell
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
                BattleLib.PlayerGainEnergy(totalValue);
                displayPoints = GamePlayer.EnergyPts.ToString();
            }
            else
            {
                display = "hp";
                BattleLib.PlayerGainHp(totalValue);
                displayPoints = GamePlayer.HealthPts.ToString();
            }

            msg += "\n" + "Restored " + totalValue + display;
            msg += "\n" + "Current " + display.ToUpper() + ": " + displayPoints;
            RpgLib.ShowLogStatusMsg(msg);
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
                var newDate = HavanaLib.ReturnDisplayDateAndTime();
                //fazer uma forma de ajusta na view
            }
        }
    }
}
