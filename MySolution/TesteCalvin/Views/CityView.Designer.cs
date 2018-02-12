namespace HavanaRPG.Views
{
    partial class CityView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_city = new System.Windows.Forms.PictureBox();
            this.txt_cityName = new System.Windows.Forms.Label();
            this.btn_shops = new System.Windows.Forms.Button();
            this.btn_places = new System.Windows.Forms.Button();
            this.box_shops = new System.Windows.Forms.GroupBox();
            this.list_shops = new System.Windows.Forms.ListBox();
            this.box_places = new System.Windows.Forms.GroupBox();
            this.list_places = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_city)).BeginInit();
            this.box_shops.SuspendLayout();
            this.box_places.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.img_city);
            this.panel1.Controls.Add(this.txt_cityName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 492);
            this.panel1.TabIndex = 0;
            // 
            // img_city
            // 
            this.img_city.Location = new System.Drawing.Point(0, 40);
            this.img_city.Name = "img_city";
            this.img_city.Size = new System.Drawing.Size(629, 452);
            this.img_city.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_city.TabIndex = 2;
            this.img_city.TabStop = false;
            // 
            // txt_cityName
            // 
            this.txt_cityName.BackColor = System.Drawing.Color.Transparent;
            this.txt_cityName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_cityName.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cityName.Location = new System.Drawing.Point(0, 0);
            this.txt_cityName.Name = "txt_cityName";
            this.txt_cityName.Size = new System.Drawing.Size(632, 37);
            this.txt_cityName.TabIndex = 1;
            this.txt_cityName.Text = "City name";
            this.txt_cityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_shops
            // 
            this.btn_shops.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shops.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shops.Location = new System.Drawing.Point(860, 226);
            this.btn_shops.Name = "btn_shops";
            this.btn_shops.Size = new System.Drawing.Size(128, 43);
            this.btn_shops.TabIndex = 1;
            this.btn_shops.Text = "Enter Shop";
            this.btn_shops.UseVisualStyleBackColor = true;
            this.btn_shops.Click += new System.EventHandler(this.btn_shops_Click);
            // 
            // btn_places
            // 
            this.btn_places.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_places.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_places.Location = new System.Drawing.Point(860, 461);
            this.btn_places.Name = "btn_places";
            this.btn_places.Size = new System.Drawing.Size(128, 43);
            this.btn_places.TabIndex = 2;
            this.btn_places.Text = "Visit Place";
            this.btn_places.UseVisualStyleBackColor = true;
            this.btn_places.Click += new System.EventHandler(this.btn_places_Click);
            // 
            // box_shops
            // 
            this.box_shops.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.box_shops.Controls.Add(this.list_shops);
            this.box_shops.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_shops.Location = new System.Drawing.Point(651, 52);
            this.box_shops.Name = "box_shops";
            this.box_shops.Size = new System.Drawing.Size(337, 165);
            this.box_shops.TabIndex = 3;
            this.box_shops.TabStop = false;
            this.box_shops.Text = "Shops";
            // 
            // list_shops
            // 
            this.list_shops.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_shops.FormattingEnabled = true;
            this.list_shops.ItemHeight = 20;
            this.list_shops.Location = new System.Drawing.Point(7, 25);
            this.list_shops.Name = "list_shops";
            this.list_shops.Size = new System.Drawing.Size(324, 124);
            this.list_shops.TabIndex = 0;
            // 
            // box_places
            // 
            this.box_places.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.box_places.Controls.Add(this.list_places);
            this.box_places.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_places.Location = new System.Drawing.Point(651, 290);
            this.box_places.Name = "box_places";
            this.box_places.Size = new System.Drawing.Size(337, 165);
            this.box_places.TabIndex = 4;
            this.box_places.TabStop = false;
            this.box_places.Text = "Places";
            // 
            // list_places
            // 
            this.list_places.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_places.FormattingEnabled = true;
            this.list_places.ItemHeight = 20;
            this.list_places.Location = new System.Drawing.Point(7, 24);
            this.list_places.Name = "list_places";
            this.list_places.Size = new System.Drawing.Size(324, 124);
            this.list_places.TabIndex = 1;
            // 
            // CityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 508);
            this.Controls.Add(this.box_places);
            this.Controls.Add(this.box_shops);
            this.Controls.Add(this.btn_places);
            this.Controls.Add(this.btn_shops);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CityView";
            this.Load += new System.EventHandler(this.CityView_Load);
            this.Shown += new System.EventHandler(this.CityView_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_city)).EndInit();
            this.box_shops.ResumeLayout(false);
            this.box_places.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox img_city;
        public System.Windows.Forms.GroupBox box_shops;
        public System.Windows.Forms.ListBox list_shops;
        public System.Windows.Forms.GroupBox box_places;
        public System.Windows.Forms.ListBox list_places;
        public System.Windows.Forms.Button btn_shops;
        public System.Windows.Forms.Button btn_places;
        public System.Windows.Forms.Label txt_cityName;
    }
}
