using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace HavanaRPG.Model
{
    public class Shop : MonoBehaviour
    {
        public string ShopName { get; set; }
        public Location Local { get; set; }
        public Npc OwnedBy { get; set; }
        public List<Item> Selling { get; set; }
        public HavanaLib.ItemTypes SellingTypes { get; set; }
        public List<Item> Buying { get; set; }
        public string ImgSource { get; set; }
        public string PlayerBuyMessage { get; set; }
        public string PlayerSellMessage { get; set; }

        public Shop()
        {
            Selling = new List<Item>();
            Buying = new List<Item>();
            ShopName = "Shop";
            SellingTypes = HavanaLib.ItemTypes.None;
            //SpecificView = new ShopView();
            PlayerBuyMessage = "Thanks!";
            PlayerSellMessage = "Thank you.";
        }
    }
}
