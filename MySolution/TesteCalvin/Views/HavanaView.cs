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
    public partial class HavanaView : Form
    {
        public HavanaView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ViewsController.SetOpenClosed(this.Name);
            ViewsController.CurrentView = this.Name;
            base.OnLoad(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ViewsController.SetOpenClosed(this.Name);
            ViewsController.LastView = this.Name;
            base.OnFormClosed(e);
        }
    }
}
