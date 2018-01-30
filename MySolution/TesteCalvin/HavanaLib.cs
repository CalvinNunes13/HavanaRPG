using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public HavanaLib() { }

        //retorna um valor aleatório com base em um dado de determinados lados
        public static int RollDice(int diceSides)
        {
            var n = RollDice(diceSides, 0, false);
            return n;
        }

        public static int RollDice(int diceSides, int bonus)
        {
            var n = RollDice(diceSides, bonus, true);
            return n;
        }

        public static int RollDice(int diceSides, int bonus, bool returnWithBonus)
        {
            var min = 1;
            var max = diceSides;
            int diceValue = 0;

            var randomValue = new Random();
            diceValue = randomValue.Next(min, max);

            if (returnWithBonus && bonus > 0)
            {
                diceValue = ReturnWithBonus(diceValue, bonus);
            }

            return diceValue;
        }

        //Retorna valor com base em um bonus extra
        public static int ReturnWithBonus(int diceValue, int bonusValue)
        {
            var finalValue = 0;
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
        public static void UpdateDisplayDateAndTime()
        {
            string displayDate = "";
            displayDate = MainGame.GameDateDay.ToString() + "/";
            displayDate = displayDate + MainGame.GameDateMonth.ToString() + "/";
            displayDate = displayDate + MainGame.GameDateYear.ToString();
            //Adicionar o staticdisplay no menu principal do jogo, alterar ele aqui, ajustar tambem a exibição de dia e noite
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
        public static void UpdateEquipmentValues()
        {

        }

        //checa se player tem gold comparado a um valor
        public static bool CheckPlayerHaveGold(int value)
        {
            if (Player.GoldPcs < value)
            {
                return false;
            }
            return true;
        }

        //faz a compra ou venda de algo com gold do player
        public static void MovementPlayerGold(int value, string action) //buy or sell
        {
            if (action == "buy")
            {
                if (CheckPlayerHaveGold(value))
                {
                    var goldRemain = Player.GoldPcs - value;
                    if (goldRemain < 0)
                    {
                        goldRemain = 0;
                    }
                    Player.GoldPcs = goldRemain;
                }
            }
            else
            {
                var goldRemain = Player.GoldPcs + value;
                Player.GoldPcs = goldRemain;
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
