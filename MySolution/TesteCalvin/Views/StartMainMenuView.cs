using HavanaRPG.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HavanaRPG.Views
{
    public partial class StartMainMenuView : HavanaRPG.Views.Controls.BaseForm
    {
        public StartMainMenuView()
        {
            InitializeComponent();
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            GameController.StartGame();
        }

        private void btn_loadGame_Click(object sender, EventArgs e)
        {
            GameController.LoadGame();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            GameController.ExitGame();
        }
    }
}
