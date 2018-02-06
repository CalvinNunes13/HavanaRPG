using HavanaRPG.Controller;
using HavanaRPG.Model;
using HavanaRPG.Model.RpgClasses;
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
            this.MdiParent = GameController._MainContainerView;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StartMainMenuView startView = new StartMainMenuView();
            startView.Name = "StartMainMenuView";
            startView.MdiParent = GameController._MainContainerView;
            ViewsController.OpenNewForm(startView);
            this.Close();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string name = txt_name.Text;
                string classSelected = cbx_class.SelectedItem.ToString();
                var _class = HavanaLib.ReturnEnumClassByString(classSelected);
                string genderSelected = cbx_gender.SelectedItem.ToString();
                var gender = HavanaLib.ReturnEnumGenderByString(classSelected);
                if (HavanaLib.ConfirmBox("Confirm?\n" + "Name: " + HavanaLib.ToProperCase(name) + "\nClass: " + classSelected + "\nGender: " + genderSelected))
                {
                    GameController.SetFirstPlayerData(name, _class, gender);
                    GameController.LaunchGameplay();
                }
            }

        }

        private bool ValidateFields()
        {
            if (HavanaLib.IsEmpty(txt_name.Text))
            {
                HavanaLib.MsgBox("Name is Empty!");
                return false;
            }
            else if (txt_name.Text.Length < 3)
            {
                HavanaLib.MsgBox("Name is too short!");
                return false;

            }

            if (HavanaLib.IsEmpty(cbx_class.SelectedItem) || cbx_class.SelectedItem.ToString() == "None")
            {
                HavanaLib.MsgBox("Please, choose a class.");
                return false;
            }

            if (HavanaLib.IsEmpty(cbx_gender.SelectedItem) || cbx_gender.SelectedItem.ToString() == "None" )
            {
                HavanaLib.MsgBox("Please, choose a gender.");
                return false;
            }

            return true;
        }

        private void PlayerCreationView_Shown(object sender, EventArgs e)
        {
            //Insere as classes no combobox
            foreach (var className in Enum.GetValues(typeof(HavanaLib.ClassNames)))
            {
                cbx_class.Items.Add(className);
            }
            cbx_class.SelectedIndex = 0;

            //Insere os sexos no combobox
            foreach (var gender in Enum.GetValues(typeof(HavanaLib.Gender)))
            {
                cbx_gender.Items.Add(gender);
            }
            cbx_gender.SelectedIndex = 0;
        }

        private void cbx_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            var classString = cbx_class.SelectedItem.ToString();
            RpgClass class_;
            HavanaLib.ClassNames class_selected = HavanaLib.ReturnEnumClassByString(classString);
            switch (class_selected)
            {
                case HavanaLib.ClassNames.Warrior:
                    class_ = new WarriorClass();
                    this.txt_classInfo.Text = class_.ToString();
                    this.img_charRace.Image = Properties.Resources.humano;
                    break;

                case HavanaLib.ClassNames.Sorcerer:
                    class_ = new SorcererClass();
                    this.txt_classInfo.Text = class_.ToString();
                    break;

                case HavanaLib.ClassNames.Paladin:
                    class_ = new PaladinClass();
                    this.txt_classInfo.Text = class_.ToString();
                    break;

                case HavanaLib.ClassNames.Druid:
                    class_ = new DruidClass();
                    this.txt_classInfo.Text = class_.ToString();
                    break;

                case HavanaLib.ClassNames.Archer:
                    class_ = new ArcherClass();
                    this.txt_classInfo.Text = class_.ToString();
                    break;

                case HavanaLib.ClassNames.Monk:
                    class_ = new MonkClass();
                    this.txt_classInfo.Text = class_.ToString();
                    break;

                case HavanaLib.ClassNames.Thief:
                    class_ = new ThiefClass();
                    this.txt_classInfo.Text = class_.ToString();
                    break;
            }
        }

        private void cbx_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
