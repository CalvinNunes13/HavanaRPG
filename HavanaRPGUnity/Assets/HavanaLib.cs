using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
//using System.Windows.Forms;
using System.Threading;
using HavanaRPG.Controller;
using UnityEngine;
using UnityEditor;
using System.Globalization;

namespace HavanaRPG.Model
{
    public class HavanaLib
    {
        public enum raceNames { Human, Orc, Elf, Naga, Dwarf };
        public enum ClassNames { None, Warrior, Sorcerer, Druid, Paladin, Archer, Monk, Thief };
        public enum CitiesNames { Leto, Monxevis };
        public enum Locations { Limbo, Leto, Monxevis, Gibraltar_Forest, };
        public enum StatsNames { Strenght, Magic, Dexterity, Creativity, Winsdom }
        public enum StatusNames { None, Blind, Slow, Confused };
        public enum DayTime { Morning, Afternoon, Night };
        public enum AdvDvd { None, Resistance, Advantage, Normal, Disadvantage, Weakness }
        public enum Elements { None, Water, Fire, Air, Earth, Dark, Light, Physical }
        public enum Gender { None, Male, Female };
        public enum ItemTypes { None, Weapons, Armors, Generic, Potions, Magical, Archery }
        public enum PastHistories { None }

        public HavanaLib() { }

        public static void NewGame()
        {
        }

        public static void SaveGame()
        {
            try
            {
                GameController.SavePlayerInfo();
                GameController.SaveGameState();
            }
            catch (Exception ex)
            {
                MsgBox("ERROR WHILE SAVING! The game may not be correctly saved\n" + ex.Message + "\n Contact the developers at HavanaRpg@outlook.com", "error", "ERROR");
            }
        }

        public static void LoadGame()
        {
            try
            {
                GameController.LoadPlayerInfo();
                GameController.LoadGameState();
            }
            catch (Exception ex)
            {
                MsgBox("ERROR WHILE LOADING! The game will not start.\n" + ex.Message + "\n Contact the developers at HavanaRpg@outlook.com", "error", "ERROR");
            }

        }

        public static ClassNames ReturnEnumClassByString(string value)
        {
            var enumOption = (ClassNames)Enum.Parse(typeof(ClassNames), value);
            return enumOption;
        }

        public static Gender ReturnEnumGenderByString(string value)
        {
            var enumOption = (Gender)Enum.Parse(typeof(Gender), value);
            return enumOption;
        }

        public static string ToProperCase(string text)
        {
            text = text.ToLower();
            var properCulture = new CultureInfo("en-US", false).TextInfo;
            var textReturn = properCulture.ToTitleCase(text);
            return textReturn;
        }

        //Retorna a quantidade de lançamentos de um dado
        public static decimal ReturnDiceRolls(string diceNameStyle) //entrada exemplo: 2d8, retorno 2
        {
            decimal diceRolls = 1;
            diceNameStyle = diceNameStyle.ToLower();
            diceNameStyle = diceNameStyle.Replace(" ", "");
            try
            {
                var splitReturn = diceNameStyle.Split('d');
                diceRolls = int.Parse(splitReturn[0]);
            }
            catch (Exception ex)
            {
                return 1;
            }
            return diceRolls;
        }

        //Retorna a quantidade de lados de um dado
        public static decimal ReturnDiceSides(string diceNameStyle) //entrada exemplo: 3d6, retorno 6
        {
            decimal diceSides = 1;
            diceNameStyle = diceNameStyle.ToLower();
            diceNameStyle = diceNameStyle.Replace(" ", "");
            try
            {
                var splitReturn = diceNameStyle.Split('d');
                diceSides = int.Parse(splitReturn[1]);
            }
            catch (Exception ex)
            {
                return 1;
            }
            return diceSides;
        }

        //Chama uma função a cada certo período de tempo
//        public static async Task RunLoopTimer(Action action, TimeSpan timeout)
//        {
//            await Task.Delay(timeout).ConfigureAwait(false);
//
//            action();
//
//            RunLoopTimer(action, timeout);
//
//        }
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

        //quando acaba o jogo
        public static void GameOver()
        {

        }

        //Exibe imagem do dado na tela com o valor
        public static void ShowDiceOnScreen(decimal diceValue)
        {

        }

        //verifica randomEvents
        public static void VerifyRandomEvent(List<RandomEvent> randomEvents)
        {
            VerifyRandomEvent(randomEvents, 1);
        }

        public static void VerifyRandomEvent(List<RandomEvent> randomEvents, int numberOfEvents)
        {
            var eventsHappen = 0;
            foreach (var rndEvent in randomEvents)
            {
                var prob = rndEvent.Probability;
                if (prob > 100)
                {
                    prob = 100;
                }
                if (prob > 0)
                {
                    var testFor = new System.Random();
                    var returnedRnd = testFor.Next(0, 100);
                    if (returnedRnd <= prob)
                    {
                        rndEvent.OnEventCall();
                        eventsHappen++;
                    }
                }
                if (eventsHappen >= numberOfEvents)
                {
                    break;
                }
            }
        }

        //Chama na view de talk uma pergunta com respostas
        public static void CreateQuestionTalks(string question, List<string> answers)
        {
            if (ViewsController.CurrentViewName.ToUpper() == "TALKVIEW")
            {

            }
        }

        //Exibe pop-up de mensagem
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
            if (type.ToUpper() == "ALERT")
            {
                EditorUtility.DisplayDialog(caption, msg , "Ok");
            }
            else if (type.ToUpper() == "ERROR")
            {
                EditorUtility.DisplayDialog(caption, msg, "Ok");
            }
            else
            {
                EditorUtility.DisplayDialog(caption, msg, "Ok");
            }
        }

        //exibe pop-up de mensagem com botões de confirmar e cancelar
        public static bool ConfirmBox(string msg) //alert, error, info
        {
            var ret = EditorUtility.DisplayDialog("?", msg, "Ok", "Cancel");
            
            if (ret)
            {
                return true;
            }
            return false;
        }
    }
}
