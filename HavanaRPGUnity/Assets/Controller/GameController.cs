using HavanaRPG.Model;
using HavanaRPG.Model.Cities;
using UnityEngine;
using System.Collections;
//using HavanaRPG.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;
//
//using System.Windows.Forms;

namespace HavanaRPG.Controller
{
    public class GameController : MonoBehaviour
    {
        public static bool IsNewGame = true;

        //Global Cities
        public static Leto leto { get; set; }

        //Game Options//
        public static decimal DiceShowTime = 2500;

        //Global UI Gameplay Menu//
        public static Text Txt_MenuDateTime;
        public static Text Txt_MenuCurrentCity;
        public static Text Txt_MenuLogView;
        public static Text Txt_MenuExp;
        public static Text Txt_MenuLevel;
        public static Text Txt_MenuGold;
        public static Text Txt_MenuHP;
        public static Text Txt_MenuEP;
        public static Text Txt_MenuPlayerName;

        //Global Variables//
        public static Player GamePlayer = new Player("", HavanaLib.ClassNames.None, HavanaLib.Gender.None);
        public static decimal DayTimer = 0;

        //------------------- Game Functions -------------------------------------//
        public static void RunGameTime()
        {
            //HavanaLib.RunLoopTimer(() => AdvanceDayTime(), TimeSpan.FromSeconds(2));
            DayTimer++;
            if (DayTimer > 20)
            {
                GameplayLib.AdvanceDayTime();
                DayTimer = 0;
            }

        }              
        
        public static void StartGame()
        {
            ViewsController.OpenNewCloseCurrent("PlayerCreation_View");
        }

        public static void LoadGame()
        {
            ViewsController.OpenNewCloseCurrent("LoadGame_View");
        }
        
        public static void ExitGame()
        {
            Application.Quit();
        }

        public static void DoTravel(Location travelDestination)
        {
            var currentLocal = GamePlayer.PlayerLocation;
            var newLocal = travelDestination;
            if (newLocal.PossibleEvents != null && newLocal.PossibleEvents.Count > 0)
            {
                HavanaLib.VerifyRandomEvent(newLocal.PossibleEvents);
            }
            GamePlayer.PlayerLocation = newLocal;
            ViewsController.LastViewName = ViewsController.CurrentViewName;
            //CityView cityView = new CityView
            //{
            //    LocationData = travelDestination
            //};
            //ViewsController.CloseForm(ViewsController._MainContainerView.ActiveMdiChild);
            //ViewsController.OpenNewForm(cityView, true);
            //Application.Run(newLocal.SpecificView);
        }

        public static bool LoadPlayerInfo()
        {
            return true;
        }

        public static bool LoadGameState()
        {
            return true;
        }

        public static void SavePlayerInfo()
        {

        }

        public static void SaveGameState()
        {

        }

        // ------ FUNÇOES INICIALIZADORAS DO JOGO -------\\
        public static void PerformStart(string name, HavanaLib.ClassNames _class, HavanaLib.Gender gender)
        {
            SetFirstPlayerData(name, _class, gender);
            LaunchGameplay();
        }

        public static void SetFirstPlayerData(string name, HavanaLib.ClassNames playerClass, HavanaLib.Gender gender)
        {
            GamePlayer = new Player(name, playerClass, gender);
            InitializateCities();
            InitializatePlaces();
            GamePlayer.SetFirstDefaults();
        }

        public static void LaunchGameplay()
        {
            ViewsController.OpenNewCityView(leto);
            SetUIMenu();
        }

        public static void InitializateCities()
        {
            leto = new Leto();
        }

        public static void InitializatePlaces()
        {

        }
        // -------------------------------- FIM FUNÇOES INICIALIZADORAS DO JOGO ------------------------------------- //

        public static void SetUIMenu()
        {
            Txt_MenuCurrentCity = GameObject.Find("Txt_MenuCurrentCity").GetComponent<Text>();
            Txt_MenuDateTime = GameObject.Find("Txt_MenuDateTime").GetComponent<Text>();
            Txt_MenuLogView = GameObject.Find("Txt_MenuLogView").GetComponent<Text>();
            Txt_MenuExp = GameObject.Find("Txt_MenuExp").GetComponent<Text>();
            Txt_MenuLevel = GameObject.Find("Txt_MenuLevel").GetComponent<Text>();
            Txt_MenuGold = GameObject.Find("Txt_MenuGold").GetComponent<Text>();
            Txt_MenuHP = GameObject.Find("Txt_MenuHP").GetComponent<Text>();
            Txt_MenuEP = GameObject.Find("Txt_MenuEP").GetComponent<Text>();
            Txt_MenuPlayerName = GameObject.Find("Txt_MenuPlayerName").GetComponent<Text>();

            Txt_MenuCurrentCity.text = GameplayLib.ReturnPlayerLocationToDisplay();
            Txt_MenuDateTime.text = GameplayLib.ReturnDisplayDateAndTime();
            Txt_MenuExp.text = GameplayLib.ReturnPlayerXPtoDisplay();
            Txt_MenuLevel.text = GameplayLib.ReturnPlayerLevelToDisplay();
            Txt_MenuGold.text = GameplayLib.ReturnPlayerGoldToDisplay();
            Txt_MenuHP.text = GameplayLib.ReturnPlayerHPtoDisplay();
            Txt_MenuEP.text = GameplayLib.ReturnPlayerEPtoDisplay();
            Txt_MenuPlayerName.text = GameplayLib.ReturnPlayerNameToDisplay();
        }

    }
}
