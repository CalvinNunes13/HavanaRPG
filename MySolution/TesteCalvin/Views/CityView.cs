using HavanaRPG.Controller;
using HavanaRPG.Model;
using HavanaRPG.Model.Shops;
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

        private void CityView_Load(object sender, EventArgs e)
        {
            if (HavanaLib.IsEmpty(LocationData))
            {
                HavanaLib.MsgBox("Error loading city. Please leave and try again.", "error", "Game Error");
            }
        }

        private void btn_shops_Click(object sender, EventArgs e)
        {
            if (ValidShopChoice())
            {
                var shop = new SimpleEquipShop(); // Ajustar para shop escolhida
                var shopView = new ShopView(shop);
                ViewsController.OpenNewCloseCurrent(shopView, true);
            }
        }

        private bool ValidShopChoice()
        {
            var selectedShop = this.list_shops.SelectedItem;
            var selectedShopIndex = this.list_shops.SelectedIndex;
            if (HavanaLib.IsEmpty(selectedShop))
            {
                return false;
            }
            return true;
        }

        private bool ValidPlaceChoice()
        {
            var selectedPlace = this.list_places.SelectedItem;
            var selectedPlaceIndex = this.list_places.SelectedIndex;
            if (HavanaLib.IsEmpty(selectedPlace))
            {
                return false;
            }
            return true;
        }

        private void btn_places_Click(object sender, EventArgs e)
        {
            if (ValidPlaceChoice())
            {
                //var place = new SimpleEquipShop();
                //var placeView = new PlaceView(place);
                //ViewsController.OpenNewCloseCurrent(placeView, true);
            }
        }

        private void CityView_Shown(object sender, EventArgs e)
        {
            this.txt_cityName.Text = LocationData.LocalName;
        }
    }
}
