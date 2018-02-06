using HavanaRPG.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavanaRPG.Views
{
    public partial class MainGameStartContainer : Form
    {
        public MainGameStartContainer()
        {
            InitializeComponent();
        }

        private void MainGameStartContainer_Load(object sender, EventArgs e)
        {

            //------ CHAMA O INICIO DE JOGO ------\\
            GameController.StartGame();
        }
    }
}
