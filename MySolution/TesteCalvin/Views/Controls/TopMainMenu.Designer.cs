namespace HavanaRPG.Views
{
    partial class TopMainMenu
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

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.Menu_cb_One = new System.Windows.Forms.ToolStripComboBox();
            this.Menu_cb_Two = new System.Windows.Forms.ToolStripComboBox();
            this.Menu_TxtName = new System.Windows.Forms.ToolStripTextBox();
            this.Menu_TxtLevel = new System.Windows.Forms.ToolStripTextBox();
            this.Menu_TxtGold = new System.Windows.Forms.ToolStripTextBox();
            this.Menu_TxtPeriod = new System.Windows.Forms.ToolStripTextBox();
            this.Menu_TxtDate = new System.Windows.Forms.ToolStripTextBox();
            this.topMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.AutoSize = false;
            this.topMenu.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_cb_One,
            this.Menu_cb_Two,
            this.Menu_TxtName,
            this.Menu_TxtLevel,
            this.Menu_TxtGold,
            this.Menu_TxtPeriod,
            this.Menu_TxtDate});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(200, 24);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "MainMenu";
            // 
            // Menu_cb_One
            // 
            this.Menu_cb_One.AutoSize = false;
            this.Menu_cb_One.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_cb_One.Name = "Menu_cb_One";
            this.Menu_cb_One.Size = new System.Drawing.Size(120, 25);
            // 
            // Menu_cb_Two
            // 
            this.Menu_cb_Two.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_cb_Two.Name = "Menu_cb_Two";
            this.Menu_cb_Two.Size = new System.Drawing.Size(120, 20);
            // 
            // Menu_TxtName
            // 
            this.Menu_TxtName.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_TxtName.Name = "Menu_TxtName";
            this.Menu_TxtName.Size = new System.Drawing.Size(120, 20);
            // 
            // Menu_TxtLevel
            // 
            this.Menu_TxtLevel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_TxtLevel.Name = "Menu_TxtLevel";
            this.Menu_TxtLevel.Size = new System.Drawing.Size(120, 20);
            // 
            // Menu_TxtGold
            // 
            this.Menu_TxtGold.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_TxtGold.Name = "Menu_TxtGold";
            this.Menu_TxtGold.Size = new System.Drawing.Size(120, 20);
            // 
            // Menu_TxtPeriod
            // 
            this.Menu_TxtPeriod.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_TxtPeriod.Name = "Menu_TxtPeriod";
            this.Menu_TxtPeriod.Size = new System.Drawing.Size(120, 20);
            // 
            // Menu_TxtDate
            // 
            this.Menu_TxtDate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_TxtDate.Name = "Menu_TxtDate";
            this.Menu_TxtDate.Size = new System.Drawing.Size(120, 20);
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.MenuStrip topMenu;
        public System.Windows.Forms.ToolStripComboBox Menu_cb_One;
        public System.Windows.Forms.ToolStripComboBox Menu_cb_Two;
        public System.Windows.Forms.ToolStripTextBox Menu_TxtName;
        public System.Windows.Forms.ToolStripTextBox Menu_TxtLevel;
        public System.Windows.Forms.ToolStripTextBox Menu_TxtGold;
        public System.Windows.Forms.ToolStripTextBox Menu_TxtPeriod;
        public System.Windows.Forms.ToolStripTextBox Menu_TxtDate;
    }
}
