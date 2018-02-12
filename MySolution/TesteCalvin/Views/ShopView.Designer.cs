namespace HavanaRPG.Views
{
    partial class ShopView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_buy = new System.Windows.Forms.TabPage();
            this.list_itensToBuy = new System.Windows.Forms.ListBox();
            this.tab_sell = new System.Windows.Forms.TabPage();
            this.list_itensToSell = new System.Windows.Forms.ListBox();
            this.txt_shopName = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.btn_leaveShop = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab_buy.SuspendLayout();
            this.tab_sell.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_buy);
            this.tabControl.Controls.Add(this.tab_sell);
            this.tabControl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(17, 18);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1100, 669);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            // 
            // tab_buy
            // 
            this.tab_buy.Controls.Add(this.list_itensToBuy);
            this.tab_buy.Location = new System.Drawing.Point(4, 31);
            this.tab_buy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_buy.Name = "tab_buy";
            this.tab_buy.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_buy.Size = new System.Drawing.Size(1092, 634);
            this.tab_buy.TabIndex = 0;
            this.tab_buy.Text = "Buy";
            this.tab_buy.UseVisualStyleBackColor = true;
            // 
            // list_itensToBuy
            // 
            this.list_itensToBuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_itensToBuy.FormattingEnabled = true;
            this.list_itensToBuy.ItemHeight = 22;
            this.list_itensToBuy.Location = new System.Drawing.Point(8, 8);
            this.list_itensToBuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list_itensToBuy.Name = "list_itensToBuy";
            this.list_itensToBuy.Size = new System.Drawing.Size(1072, 572);
            this.list_itensToBuy.TabIndex = 0;
            // 
            // tab_sell
            // 
            this.tab_sell.Controls.Add(this.list_itensToSell);
            this.tab_sell.Location = new System.Drawing.Point(4, 31);
            this.tab_sell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_sell.Name = "tab_sell";
            this.tab_sell.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_sell.Size = new System.Drawing.Size(1092, 634);
            this.tab_sell.TabIndex = 1;
            this.tab_sell.Text = "Sell";
            this.tab_sell.UseVisualStyleBackColor = true;
            // 
            // list_itensToSell
            // 
            this.list_itensToSell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_itensToSell.FormattingEnabled = true;
            this.list_itensToSell.ItemHeight = 22;
            this.list_itensToSell.Location = new System.Drawing.Point(4, 8);
            this.list_itensToSell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list_itensToSell.Name = "list_itensToSell";
            this.list_itensToSell.Size = new System.Drawing.Size(1072, 572);
            this.list_itensToSell.TabIndex = 1;
            // 
            // txt_shopName
            // 
            this.txt_shopName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_shopName.Location = new System.Drawing.Point(633, 12);
            this.txt_shopName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_shopName.Name = "txt_shopName";
            this.txt_shopName.Size = new System.Drawing.Size(475, 44);
            this.txt_shopName.TabIndex = 1;
            this.txt_shopName.Text = "Shop Name";
            this.txt_shopName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btn_buy
            // 
            this.btn_buy.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.Location = new System.Drawing.Point(1184, 436);
            this.btn_buy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(133, 69);
            this.btn_buy.TabIndex = 2;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.Enabled = false;
            this.btn_sell.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sell.Location = new System.Drawing.Point(1184, 514);
            this.btn_sell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(133, 69);
            this.btn_sell.TabIndex = 3;
            this.btn_sell.Text = "Sell";
            this.btn_sell.UseVisualStyleBackColor = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_leaveShop
            // 
            this.btn_leaveShop.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leaveShop.Location = new System.Drawing.Point(1184, 618);
            this.btn_leaveShop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_leaveShop.Name = "btn_leaveShop";
            this.btn_leaveShop.Size = new System.Drawing.Size(133, 69);
            this.btn_leaveShop.TabIndex = 4;
            this.btn_leaveShop.Text = "Leave";
            this.btn_leaveShop.UseVisualStyleBackColor = true;
            this.btn_leaveShop.Click += new System.EventHandler(this.btn_leaveShop_Click);
            // 
            // ShopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.ClientSize = new System.Drawing.Size(1333, 703);
            this.Controls.Add(this.btn_leaveShop);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.txt_shopName);
            this.Controls.Add(this.tabControl);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ShopView";
            this.Shown += new System.EventHandler(this.ShopView_Shown);
            this.tabControl.ResumeLayout(false);
            this.tab_buy.ResumeLayout(false);
            this.tab_sell.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage tab_buy;
        public System.Windows.Forms.TabPage tab_sell;
        public System.Windows.Forms.ListBox list_itensToBuy;
        public System.Windows.Forms.ListBox list_itensToSell;
        public System.Windows.Forms.Button btn_buy;
        public System.Windows.Forms.Button btn_sell;
        public System.Windows.Forms.Button btn_leaveShop;
        public System.Windows.Forms.Label txt_shopName;
    }
}
