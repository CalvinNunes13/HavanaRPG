using HavanaRPG.Controller;
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
    public partial class PlayerCreationView : HavanaRPG.Views.Controls.BaseForm
    {
        public PlayerCreationView()
        {
            InitializeComponent();
            this.MdiParent = null; 
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ViewsController.CloseCurrentForm();
            ViewsController.OpenNewForm(new StartMainMenuView());
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                if (HavanaLib.ConfirmBox("Confirm?"))
                {
                    GameController.SetFirstPlayerData();
                }
            }
            else
            {
                HavanaLib.MsgBox("Fill all the fields before start the game.");
            }
        }

        private bool ValidateFields()
        {
            if (HavanaLib.IsEmpty(txt_name.Text))
            {
                txt_name.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Red);
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(txt_name.Location.X - variance, txt_name.Location.Y - variance, txt_name.Width + variance, txt_name.Height + variance));
                return false;
            }
            else
            {
                txt_name.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Black);
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(txt_name.Location.X - variance, txt_name.Location.Y - variance, txt_name.Width + variance, txt_name.Height + variance));
            }

            if (HavanaLib.IsEmpty(cbx_class.SelectedItem))
            {
                return false;
            }

            if (HavanaLib.IsEmpty(cbx_gender.SelectedItem))
            {
                return false;
            }

            return true;
        }
    }
}
