﻿using HavanaRPG.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavanaRPG.Views.Controls
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
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
    }
}
