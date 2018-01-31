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
    public class GameController
    {

        public static void ExecuteBasics()
        {
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
