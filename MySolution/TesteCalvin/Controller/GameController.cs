using HavanaRPG.Model;
using HavanaRPG.Model.Cities;
using HavanaRPG.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavanaRPG.Controller
{
    public static class GameController
    {
        public static bool IsNewGame = true;

        //Global Cities
        public static Leto leto {get; set;}

        public static void ExecuteBasics(MainContainerView MainView)
        {
            ViewsController._MainContainerView = MainView;
        }

        public static void StartGame()
        {
            var startView = new StartMainMenuView
            {
                Name = "StartMainMenuView",
                MdiParent = ViewsController._MainContainerView
            };
            ViewsController.LoadNewView(startView);
        }

        public static void StartNewGame()
        {
            var startView = new PlayerCreationView
            {
                Name = "PlayerCreationView"
            };
            ViewsController.LoadNewView(startView);
        }             

        public static void LoadGame()
        {
            if (LoadGameState() && LoadPlayerInfo())
            {
                var startView = new GameView
                {
                    Name = "GameView",
                    MdiParent = ViewsController._MainContainerView
                };
                ViewsController.LoadNewView(startView);
            }
            else
            {
                HavanaLib.MsgBox("There was an error while loading the game. \n", "error", "Error");
            }
        }

        public static void ExitGame()
        {
            Application.Exit();
        }

        public static void DoTravel(Location travelDestination)
        {
            var currentLocal = GameplayLib.GamePlayer.PlayerLocation;
            var newLocal = travelDestination;
            if (newLocal.PossibleEvents != null && newLocal.PossibleEvents.Count > 0)
            {
                HavanaLib.VerifyRandomEvent(newLocal.PossibleEvents);
            }
            GameplayLib.GamePlayer.PlayerLocation = newLocal;
            ViewsController.LastViewName = ViewsController.CurrentViewName;
            CityView cityView = new CityView
            {
                LocationData = travelDestination
            };
            ViewsController.CloseForm(ViewsController._MainContainerView.ActiveMdiChild);
            ViewsController.OpenNewForm(cityView, true);
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
            GameplayLib.GamePlayer = new Player(name, playerClass, gender);
            InitializateCities();
            InitializatePlaces();
            GameplayLib.GamePlayer.SetFirstDefaults();
        }

        public static void LaunchGameplay()
        {
            ViewsController._MainContainerView.toolStrip1.Visible = true;
            ViewsController._MainContainerView.panelBoxBottom.Visible = true;
            ViewsController._MainContainerView.txt_PlayerName.Text = GameplayLib.ReturnPlayerNameToDisplay();
            ViewsController._MainContainerView.txt_dateTime.Text = GameplayLib.ReturnDisplayDateAndTime();
            ViewsController._MainContainerView.txt_PlayerLocation.Text = GameplayLib.ReturnPlayerLocationToDisplay();
            ViewsController._MainContainerView.txt_PlayerHp.Text = GameplayLib.ReturnPlayerHPtoDisplay();
            ViewsController._MainContainerView.txt_PlayerEp.Text = GameplayLib.ReturnPlayerEPtoDisplay();
            ViewsController._MainContainerView.txt_Gold.Text = GameplayLib.ReturnPlayerGoldToDisplay();
            ViewsController._MainContainerView.txt_Level.Text = GameplayLib.ReturnPlayerLevelToDisplay();
            ViewsController._MainContainerView.pb_ExpBar.Value = 25; //RpgLib.ReturnPlayerXPtoDisplay(); Ajustar para isso
            GameplayLib.AdjustExperienceBar();

            ViewsController.CloseForm(ViewsController._MainContainerView.ActiveMdiChild);
            var firstCityView = new CityView();
            firstCityView.LocationData = leto;
            ViewsController.OpenNewForm(firstCityView, true);
            ViewsController.SaveLastView();

            if (IsNewGame)
            {
                HavanaLib.MsgBox("So, the journey begins!" + Environment.NewLine +
                    "You, " + GameplayLib.GamePlayer.Name + ", are now ready to explore the world and become known by your actions in " + GameplayLib.KingdomName + "!" + Environment.NewLine +
                    "Create your own destiny " + GameplayLib.GamePlayer.CallTitle + ".", "info", "Your Journey Begins");
                IsNewGame = false;
            }
            GameplayLib.RunGameTime();
            GameplayLib.ShowLogStatusMsg("You waked up recently... It's time to move.");
        }

        public static void InitializateCities()
        {
            leto = new Leto();
        }

        public static void InitializatePlaces()
        {

        }
        // -------------------------------- FIM FUNÇOES INICIALIZADORAS DO JOGO ------------------------------------- //
    }
}
