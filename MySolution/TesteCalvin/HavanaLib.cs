using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using HavanaRPG.Controller;

namespace HavanaRPG.Model
{
    public class HavanaLib
    {
        public enum raceNames { Human, Orc, Elf, Naga, Dwarf };
        public enum ClassNames { Warrior, Sorcerer, Druid, Paladin, Archer, Monk, Thief };
        public enum CitiesNames { Leto, Monxevis };
        public enum Locations { Limbo, Leto, Monxevis, Gibraltar_Forest, };
        public enum StatusNames { Blind, Slow, Confused };
        public enum DayTime { Morning, Afternoon, Night };
        public enum AdvDvd { Resistance, Advantage, Normal, Disadvantage, Weakness }
        public enum Elements { Water, Fire, Air, Earth, Dark, Light, Physical }
        public enum Sex { Male, Female, None};

        public HavanaLib() { }

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

        //Retorna a quantidade de lançamentos de um dado
        public static int ReturnDiceRolls(string diceNameStyle) //entrada exemplo: 2d8, retorno 2
        {
            var diceRolls = 1;
            diceNameStyle = diceNameStyle.ToLower();
            diceNameStyle = diceNameStyle.Replace(" ", "");
            try
            {
                var splitReturn = diceNameStyle.Split('d');
                diceRolls = int.Parse(splitReturn[0]);
            }
            catch
            {
                return 1;
            }
            return diceRolls;
        }

        //Retorna a quantidade de lados de um dado
        public static int ReturnDiceSides(string diceNameStyle) //entrada exemplo: 3d6, retorno 6
        {
            var diceSides = 1;
            diceNameStyle = diceNameStyle.ToLower();
            diceNameStyle = diceNameStyle.Replace(" ", "");
            try
            {
                var splitReturn = diceNameStyle.Split('d');
                diceSides = int.Parse(splitReturn[1]);
            }
            catch
            {
                return 1;
            }
            return diceSides;
        }

        //Chama uma função a cada certo período de tempo
        public static async Task RunLoopTimer(Action action, TimeSpan timeout)
        {
            await Task.Delay(timeout).ConfigureAwait(false);

            action();

            RunLoopTimer(action, timeout);
        }

        //Avança o período do dia se for preciso, avança um dia na data do jogo
        public static void AdvanceDayTime()
        {
            var actualPeriod = MainGame.TimeofDay;
            if (actualPeriod == DayTime.Morning)
            {
                MainGame.TimeofDay = DayTime.Afternoon;
            }
            else if (actualPeriod == DayTime.Afternoon)
            {
                MainGame.TimeofDay = DayTime.Night;
            }
            else
            {
                MainGame.TimeofDay = HavanaLib.DayTime.Morning;
                MainGame.GameDateDay++;
                if (MainGame.GameDateDay > 30)
                {
                    MainGame.GameDateDay = 1;
                    MainGame.GameDateMonth++;
                    if (MainGame.GameDateMonth > 12)
                    {
                        MainGame.GameDateMonth = 1;
                        MainGame.GameDateYear++;
                    }
                }
                UpdateDisplayDateAndTime();
            }
        }

        //Ajusta a visualização da data do jogo
        public static string UpdateDisplayDateAndTime()
        {
            string displayDate = "";
            displayDate = MainGame.GameDateDay.ToString() + "/";
            displayDate = displayDate + MainGame.GameDateMonth.ToString() + "/";
            displayDate = displayDate + MainGame.GameDateYear.ToString();
            return displayDate;
        }

        //Verifica se objeto é vazio
        public static Boolean IsEmpty(object obj)
        {
            if (obj == null)
                return true;
            else
            {
                if (obj.ToString().Trim().Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        //Ajusta todos valores de Atk, Def e Armor do player com base nos equipamentos
        public static void UpdateAllEquipmentValues()
        {
            var equips = MainGame.GamePlayer.Equipments;
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


            MainGame.GamePlayer.DefensePts = totalDef;
            MainGame.GamePlayer.Armor = totalArm;
        }

        //Modifica a Arm e def do player com base em apenas um item
        public static void UpdateSingleEquipmentValues(decimal itemArm)
        {
            UpdateSingleEquipmentValues(itemArm, 0);
        }

        public static void UpdateSingleEquipmentValues(decimal itemArm, decimal itemDef)
        {
            decimal totalArm = MainGame.GamePlayer.Armor;
            decimal totalDef = MainGame.GamePlayer.DefensePts;

            if (totalArm < 0)
            {
                totalArm = 0;
            }

            MainGame.GamePlayer.Armor = totalArm + itemArm;
            if (MainGame.GamePlayer.Armor < 0)
            {
                MainGame.GamePlayer.Armor = 0;
            }
            var newDef = (MainGame.GamePlayer.Armor / 3) + itemDef;
            if (newDef < 0)
            {
                newDef = 0;
            }

            MainGame.GamePlayer.DefensePts = newDef;
        }

        public static void UpdateNewXp(int xp)
        {
            var currentXP = MainGame.GamePlayer.Experience;
            var currentLvl = MainGame.GamePlayer.PlayerLevel;
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
                MainGame.GamePlayer.OnLevelUp();
                MainGame.GamePlayer.Experience = 0;
                UpdateNewXp((int)remainingXp);
            }
            else
            {
                MainGame.GamePlayer.Experience = newXp;
            }
        }

        //checa se player tem gold comparado a um valor
        public static bool CheckPlayerHaveGold(decimal value)
        {
            if (MainGame.GamePlayer.GoldPcs < value)
            {
                return false;
            }
            return true;
        }

        //quando acaba o jogo
        public static void GameOver()
        {

        }

        //faz a compra ou venda de algo com gold do player
        public static void PlayerGoldTransaction(int value, string action) //buy or sell
        {
            if (action == "buy")
            {
                if (CheckPlayerHaveGold(value))
                {
                    var goldRemain = MainGame.GamePlayer.GoldPcs - value;
                    if (goldRemain < 0)
                    {
                        goldRemain = 0;
                    }
                    MainGame.GamePlayer.GoldPcs = goldRemain;
                }
            }
            else
            {
                var goldRemain = MainGame.GamePlayer.GoldPcs + value;
                MainGame.GamePlayer.GoldPcs = goldRemain;
            }
        }

        //Exibe imagem do dado na tela com o valor
        public static void ShowDiceOnScreen(decimal diceValue)
        {

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
                ShowDiceOnScreen(value);                
                totalValue += value;
                if (IsEmpty(msg)) {
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
                displayPoints = MainGame.GamePlayer.EnergyPts.ToString();
            }
            else
            {
                display = "hp";
                BattleLib.PlayerGainHp(totalValue);
                displayPoints = MainGame.GamePlayer.HealthPts.ToString();
            }
           
            msg += "\n" + "Restored " + totalValue + display;            
            msg += "\n" + "Current " + display.ToUpper() + ": " + displayPoints;
            ShowLogStatusMsg(msg);
        }

        //Adiciona log de acontecimento na barra de status da view
        public static void ShowLogStatusMsg(string msg)
        {

        }

        //Chama na view de talk uma pergunta com respostas
        public static void CreateQuestionTalks(string question, List<string> answers)
        {
            if (ViewsController.CurrentView.ToUpper() == "TALKVIEW")
            {

            }
        }

        public static void MsgBox(string msg)
        {
            MsgBox(msg, "info", "");
        }

        public static void MsgBox(string msg, string type)
        {
            MsgBox(msg, type, "");
        }

        public static void MsgBox(string msg, string type, string caption) //alert, error, info
        {
            if (type == "alert")
            {
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (type == "error")
            {
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void ConfirmBox(string msg) //alert, error, info
        {
            MessageBox.Show(msg, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
