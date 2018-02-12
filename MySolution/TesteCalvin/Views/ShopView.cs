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
    public partial class ShopView : HavanaRPG.Views.Controls.BaseForm
    {
        protected List<Item> itensShopBuy = new List<Item>();
        protected List<Item> itensShopSell = new List<Item>();
        protected HavanaLib.ItemTypes shopBuyType;

        public ShopView(Shop shop)
        {
            InitializeComponent();
            this.txt_shopName.Text = shop.ShopName + " - " + Enum.GetName(typeof(HavanaLib.ItemTypes), (int)shop.SellingTypes).ToString();
            itensShopBuy.AddRange(shop.Buying);
            shopBuyType = shop.SellingTypes;
            LoadItensShopBuy();
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedIndex == 0)
            {
                btn_buy.Enabled = true;
                btn_sell.Enabled = false;
            }
            else if (this.tabControl.SelectedIndex == 1)
            {
                btn_buy.Enabled = false;
                btn_sell.Enabled = true;
            }
            else
            {
                btn_buy.Enabled = false;
                btn_sell.Enabled = false;
            }
        }

        private void ShopView_Shown(object sender, EventArgs e)
        {
            //TODO: carregar itens a venda e a compra
            this.list_itensToBuy.DataSource = itensShopSell;
            this.list_itensToSell.DataSource = itensShopBuy;
        }

        private void btn_leaveShop_Click(object sender, EventArgs e)
        {
            ViewsController.OpenNewCloseCurrent(ViewsController.LastForm, true);
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (!HavanaLib.IsEmpty(this.list_itensToBuy.SelectedIndex))
            {
                var item = this.list_itensToBuy.SelectedItem;
                var itemIndex = this.list_itensToBuy.SelectedIndex;

                var itemB = this.itensShopSell[itemIndex];
                var price = itemB.BuyValue;
                if (GameplayLib.CheckPlayerHaveGold(price))
                {
                    GameplayLib.PlayerGoldTransaction(price, "buy");
                    GameplayLib.ShowLogStatusMsg(GameplayLib.GamePlayer.Name + " acquired " + itemB.ItemName);
                    GameplayLib.GamePlayer.BackpackEquips.Add(itemB);
                    ViewsController._MainContainerView.txt_Gold.Text = GameplayLib.ReturnPlayerGoldToDisplay();
                }
                else
                {
                    HavanaLib.MsgBox("You don't have enough gold to buy this.");
                }
            }
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            if (!HavanaLib.IsEmpty(this.list_itensToSell.SelectedIndex))
            {
                var item = this.list_itensToSell.SelectedItem;
                var itemIndex = this.list_itensToSell.SelectedIndex;

                var itemB = this.itensShopBuy[itemIndex];
                var price = itemB.BuyValue;

                GameplayLib.PlayerGoldTransaction(price, "sell");
                GameplayLib.ShowLogStatusMsg(GameplayLib.GamePlayer.Name + " sold " + itemB.ItemName);
                GameplayLib.GamePlayer.BackpackEquips.Remove(itemB);
                ViewsController._MainContainerView.txt_Gold.Text = GameplayLib.ReturnPlayerGoldToDisplay();
                LoadItensShopBuy();
            }
        }

        private void LoadItensShopBuy()
        {
            itensShopBuy.Clear();
            var playerItens = GameplayLib.GamePlayer.BackpackEquips;
            foreach (var item in playerItens)
            {
                if (item.Type == shopBuyType || shopBuyType == HavanaLib.ItemTypes.Generic)
                {
                    itensShopBuy.Add(item);
                }
            }
            this.list_itensToSell.DataSource = itensShopBuy;
            this.list_itensToSell.Update();
        }
    }
}
