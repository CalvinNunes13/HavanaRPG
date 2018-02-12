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
        public static MainContainerView _MainContainerView { get; set; }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _MainContainerView = new MainContainerView
            {
                IsMdiContainer = true
            };
            GameController.ExecuteBasics(_MainContainerView);

            Application.Run(ViewsController._MainContainerView);
        }
    }
}
