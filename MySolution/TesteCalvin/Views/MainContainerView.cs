using HavanaRPG.Controller;
using HavanaRPG.Model;
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
    public partial class MainContainerView : Form
    {
        public MainContainerView()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.ControlBox = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            ViewsController.SetOpenClosed(this.Name);
            ViewsController.CurrentViewName = this.Name;
            ViewsController.CurrentForm = this;
            base.OnLoad(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ViewsController.SetOpenClosed(this.Name);
            ViewsController.LastViewName = this.Name;
            ViewsController.LastForm = this;
            base.OnFormClosed(e);
        }

        private void img_MapButton_Click(object sender, EventArgs e)
        {
            //TODO: Fazer função que abre o mapa
        }

        private void HavanaView_Load(object sender, EventArgs e)
        {
            GameController.StartGame();
        }

        private void btn_talkTo_Click(object sender, EventArgs e)
        {
            var currentLocal = GameplayLib.GamePlayer.PlayerLocation;
            if (currentLocal.LocalName.ToUpper() == HavanaLib.Locations.Limbo.ToString().ToUpper())
            {
                HavanaLib.MsgBox("Your current location doesn't allow you to talk.", "error");
            }
            else
            {
                var talkView = new TalkView(currentLocal);
                ViewsController.OpenNewCloseCurrent(talkView, true);
            }
        }
    }
}
