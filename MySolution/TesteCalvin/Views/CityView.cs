using HavanaRPG.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HavanaRPG.Views
{
    public partial class CityView : HavanaRPG.Views.Controls.BaseForm
    {
        public Location LocationData { get; set; }

        public CityView()
        {
            InitializeComponent();
        }
    }
}
