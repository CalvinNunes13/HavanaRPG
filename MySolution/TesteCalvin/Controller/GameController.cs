using HavanaRPG.Model;
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
        public static MainContainerView _MainContainerView;
        public static bool IsNewGame = true;
        //public static MainGameStartContainer _MainGameStartContainer;

        public static void ExecuteBasics(MainContainerView MainView/*, MainGameStartContainer MainContainerView*/)
        {
            _MainContainerView = MainView;
            //_MainGameStartContainer = MainContainerView;
        }

        public static void StartGame()
        {
            var startView = new StartMainMenuView();
            startView.Name = "StartMainMenuView";
            startView.MdiParent = _MainContainerView;
            ViewsController.LoadNewView(startView);
        }

        public static void StartNewGame()
        {
            var startView = new PlayerCreationView();
            startView.Name = "PlayerCreationView";
            ViewsController.LoadNewView(startView);
        }

        public static void LaunchGameplay()
        {
            _MainContainerView.toolStrip1.Visible = true;
            _MainContainerView.panelBoxBottom.Visible = true;
            GameplayLib.AdjustExperienceBar();
            _MainContainerView.txt_PlayerName.Text = GameplayLib.ReturnPlayerNameToDisplay();
            _MainContainerView.txt_dateTime.Text = HavanaLib.ReturnDisplayDateAndTime();
            _MainContainerView.txt_PlayerLocation.Text = GameplayLib.ReturnPlayerLocationToDisplay();
            _MainContainerView.txt_PlayerHp.Text = GameplayLib.ReturnPlayerHPtoDisplay();
            _MainContainerView.txt_PlayerEp.Text  = GameplayLib.ReturnPlayerEPtoDisplay();
            _MainContainerView.txt_Gold.Text = GameplayLib.ReturnPlayerGoldToDisplay();
            _MainContainerView.txt_Level.Text = GameplayLib.ReturnPlayerLevelToDisplay();
            _MainContainerView.pb_ExpBar.Value = 50; //RpgLib.ReturnPlayerXPtoDisplay();
            if (IsNewGame)
            {
                HavanaLib.MsgBox("So, the journey begins!\n" +
                    "You, " + GameplayLib.GamePlayer.Name, " are now ready to explore the world and become known by your actions in " + GameplayLib.KingdomName + "!\n" +
                    "Create your own destiny " + GameplayLib.GamePlayer.CallTitle, "info", "You Journey Begins");
                IsNewGame = false;
            }
        }

        public static void LoadGame()
        {
            if (LoadGameState() && LoadPlayerInfo())
            {
                var startView = new GameView();
                startView.Name = "GameView";
                startView.MdiParent = _MainContainerView;
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
            CityView cityView = new CityView();
            cityView.LocationData = travelDestination;
            ViewsController.CloseForm(_MainContainerView.ActiveMdiChild);
            ViewsController.OpenNewForm(cityView);
            //Application.Run(newLocal.SpecificView);
        }

        public static void UpdateViewMenus()
        {
            var view = Form.ActiveForm;
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

        public static void SetFirstPlayerData(string name, HavanaLib.ClassNames playerClass, HavanaLib.Gender gender)
        {
            GameplayLib.GamePlayer = new Player(name, playerClass, gender);
        }
    }
}
