using HavanaRPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HavanaRPG.Controller
{
    public class ViewsController : MonoBehaviour
    {
        public static string CurrentViewName = "StartMenu_View";
        public static string LastViewName = "StartMenu_View";
        public static List<string> AllSceneViews = new List<string>();
        public static Location CityToOpen = null;
        public static Npc TalkToOpen = null;
        public static Shop ShopToOpen = null;
        public static List<Creature> CreaturesToOpen = null;

        public static void LoadAllSceneToArray()
        {
            AllSceneViews.Add("StartMenu_View");
            AllSceneViews.Add("PlayerCreation_View");
            AllSceneViews.Add("City_View");
            AllSceneViews.Add("Talk_View");
            AllSceneViews.Add("Shop_View");
            AllSceneViews.Add("Battle_View");
        }

        public static void OpenNewCloseCurrent(string viewName)
        {
            SaveLastView();

            CurrentViewName = viewName;
            SceneManager.LoadScene(viewName);
        }

        public static void OpenNewCityView(Location city)
        {
            SaveLastView();
            CityToOpen = city;
            SceneManager.LoadScene("City_View");
        }

        public static void OpenNewTalkView(Npc talkPerson)
        {
            SaveLastView();
            TalkToOpen = talkPerson;
            SceneManager.LoadScene("Talk_View");
        }

        public static void OpenNewShopView(Shop shop)
        {
            SaveLastView();
            ShopToOpen = shop;
            SceneManager.LoadScene("Shop_View");
        }

        public static void OpenNewBattleView(List<Creature> creatures)
        {
            SaveLastView();
            CreaturesToOpen = creatures;
            SceneManager.LoadScene("Battle_View");
        }
        
        public static void SaveLastView()
        {
            LastViewName = CurrentViewName;
        }

    }
}
