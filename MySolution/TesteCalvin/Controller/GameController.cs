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
        public static Form HavanaViewMdi;

        public static void ExecuteBasics(Form MainView)
        {
            HavanaViewMdi = MainView;            
        }

        public static void DoTravel(Location travelDestination)
        {
            var currentLocal = RpgLib.GamePlayer.PlayerLocation;
            var newLocal = travelDestination;
            if (newLocal.PossibleEvents != null && newLocal.PossibleEvents.Count > 0)
            {
                HavanaLib.VerifyRandomEvent(newLocal.PossibleEvents);
            }
            RpgLib.GamePlayer.PlayerLocation = newLocal;
            ViewsController.LastViewName = ViewsController.CurrentViewName;
            ViewsController.CloseCurrentForm();
            Application.Run(newLocal.SpecificView);
        }

        public static void StartGame()
        {
            var startView = new GameView();
            startView.Name = "GameView";
            startView.MdiParent = HavanaViewMdi;
            ViewsController.LoadNewView(startView);
        }

        public static void UpdateViewMenus()
        {
            var view = Form.ActiveForm;
        }

        public static void LoadPlayerInfo()
        {

        }

        public static void LoadGameState()
        {

        }

        public static void SavePlayerInfo()
        {

        }

        public static void SaveGameState()
        {

        }
    }
}
