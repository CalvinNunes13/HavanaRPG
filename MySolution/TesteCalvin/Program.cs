using HavanaRPG.Controller;
using HavanaRPG.Model;
using HavanaRPG.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavanaRPG
{
    static class Program
    {
        public static Form HavanaViewMdi { get; set; }
        //public static GameController MainGameController;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            HavanaViewMdi = new HavanaView();
            GameController.ExecuteBasics(HavanaViewMdi);

            var startMainmenu = new StartMainMenuView();
            startMainmenu.MdiParent = null;
            Application.Run(startMainmenu);

            GameController.StartGame();

        }
    }
}
