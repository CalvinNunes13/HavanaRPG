using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HavanaRPG.Views;
using System.Windows.Forms;

namespace HavanaRPG.Controller
{
    class ViewsController
    {
        public static bool BattleViewOpen = false;
        public static bool CityViewOpen = false;
        public static bool GameViewOpen = false;
        public static bool PlayerEquipsViewOpen = false;
        public static bool PlayerViewOpen = false;
        public static bool ShopViewOpen = false;
        public static bool TalkViewOpen = false;
        public static bool StartMainMenuView = true;
        public static Form CurrentForm;
        public static Form LastForm;
        public static string CurrentViewName = "STARTMAINMENUVIEW";
        public static string LastViewName = "STARTMAINMENUVIEW";

        public static void LoadNewView(Form newForm)
        {
            //if (!newForm.IsMdiChild)
            //{
            //    newForm.MdiParent = GameController._MainContainerView;                
            //}
            newForm.Show();
            SetOpenClosed(newForm.Name);
        }

        public static void OpenNewForm(Form newFormView)
        {
            SetOpenClosed(newFormView.Name);
            newFormView.Show();
        }

        public static void SaveLastView()
        {
            LastForm = GameController._MainContainerView.ActiveMdiChild;
        }

        public static void CloseForm(Form formToClose)
        {
            SaveLastView();
            SetOpenClosed(formToClose.Name);
            formToClose.Close();
        }

        public static void SetOpenClosed(string viewName)
        {
            viewName = viewName.ToUpper();
            switch (viewName)
            {
                case "STARTMAINMENUVIEW":
                    if (StartMainMenuView)
                    {
                        StartMainMenuView = false;
                    }
                    else
                    {
                        StartMainMenuView = true;
                    }
                    break;

                case "BATTLEVIEW":
                    if (BattleViewOpen)
                    {
                        BattleViewOpen = false;
                    }
                    else
                    {
                        BattleViewOpen = true;
                    }
                    break;

                case "CITYVIEW":
                    if (CityViewOpen)
                    {
                        CityViewOpen = false;
                    }
                    else
                    {
                        CityViewOpen = true;
                    }
                    break;

                case "GAMEVIEW":
                    if (GameViewOpen)
                    {
                        GameViewOpen = false;
                    }
                    else
                    {
                        GameViewOpen = true;
                    }
                    break;

                case "PLAYEREQUIPSVIEW":
                    if (PlayerEquipsViewOpen)
                    {
                        PlayerEquipsViewOpen = false;
                    }
                    else
                    {
                        PlayerEquipsViewOpen = true;
                    }
                    break;

                case "PLAYERVIEW":
                    if (PlayerViewOpen)
                    {
                        PlayerViewOpen = false;
                    }
                    else
                    {
                        PlayerViewOpen = true;
                    }
                    
                    break;

                case "SHOPVIEW":
                    if (ShopViewOpen)
                    {
                        ShopViewOpen = false;
                    }
                    else
                    {
                        ShopViewOpen = true;
                    }
                    break;

                case "TALKVIEW":
                    if (TalkViewOpen)
                    {
                        TalkViewOpen = false;
                    }
                    else
                    {
                        TalkViewOpen = true;
                    }
                    break;
            }
        }
    }
}
