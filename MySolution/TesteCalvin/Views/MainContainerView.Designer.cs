namespace HavanaRPG.Views
{
    partial class MainContainerView
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cb_Main = new System.Windows.Forms.ToolStripComboBox();
            this.cb_two = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_PlayerName = new System.Windows.Forms.ToolStripLabel();
            this.pb_ExpBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_Level = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_Gold = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_PlayerHp = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_PlayerEp = new System.Windows.Forms.ToolStripLabel();
            this.StatusLogBox = new System.Windows.Forms.TextBox();
            this.panelBoxBottom = new System.Windows.Forms.Panel();
            this.img_MapButton = new System.Windows.Forms.PictureBox();
            this.txt_PlayerLocation = new System.Windows.Forms.Label();
            this.txt_dateTime = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelBoxBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_MapButton)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cb_Main,
            this.cb_two,
            this.toolStripSeparator1,
            this.txt_PlayerName,
            this.pb_ExpBar,
            this.toolStripSeparator2,
            this.txt_Level,
            this.toolStripSeparator5,
            this.txt_Gold,
            this.toolStripSeparator4,
            this.txt_PlayerHp,
            this.toolStripSeparator6,
            this.txt_PlayerEp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1022, 75);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // cb_Main
            // 
            this.cb_Main.AutoSize = false;
            this.cb_Main.Items.AddRange(new object[] {
            "Save Game",
            "Load Game",
            "Exit Game",
            ""});
            this.cb_Main.Name = "cb_Main";
            this.cb_Main.Size = new System.Drawing.Size(150, 23);
            // 
            // cb_two
            // 
            this.cb_two.AutoSize = false;
            this.cb_two.Items.AddRange(new object[] {
            "Backpack",
            "Equipments",
            "Map",
            "Status"});
            this.cb_two.Name = "cb_two";
            this.cb_two.Size = new System.Drawing.Size(150, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 75);
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.AutoSize = false;
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.Size = new System.Drawing.Size(110, 75);
            this.txt_PlayerName.Text = "Name";
            // 
            // pb_ExpBar
            // 
            this.pb_ExpBar.AutoSize = false;
            this.pb_ExpBar.ForeColor = System.Drawing.Color.ForestGreen;
            this.pb_ExpBar.Name = "pb_ExpBar";
            this.pb_ExpBar.Size = new System.Drawing.Size(180, 30);
            this.pb_ExpBar.Step = 1;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 75);
            // 
            // txt_Level
            // 
            this.txt_Level.AutoSize = false;
            this.txt_Level.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Level.Name = "txt_Level";
            this.txt_Level.Size = new System.Drawing.Size(50, 72);
            this.txt_Level.Text = "0";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 75);
            // 
            // txt_Gold
            // 
            this.txt_Gold.AutoSize = false;
            this.txt_Gold.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gold.ForeColor = System.Drawing.Color.Goldenrod;
            this.txt_Gold.Name = "txt_Gold";
            this.txt_Gold.Size = new System.Drawing.Size(80, 72);
            this.txt_Gold.Text = "000";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 75);
            // 
            // txt_PlayerHp
            // 
            this.txt_PlayerHp.AutoSize = false;
            this.txt_PlayerHp.ForeColor = System.Drawing.Color.Red;
            this.txt_PlayerHp.Name = "txt_PlayerHp";
            this.txt_PlayerHp.Size = new System.Drawing.Size(95, 75);
            this.txt_PlayerHp.Text = "0 / 0";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 75);
            // 
            // txt_PlayerEp
            // 
            this.txt_PlayerEp.AutoSize = false;
            this.txt_PlayerEp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_PlayerEp.Name = "txt_PlayerEp";
            this.txt_PlayerEp.Size = new System.Drawing.Size(95, 75);
            this.txt_PlayerEp.Text = "0 / 0";
            // 
            // StatusLogBox
            // 
            this.StatusLogBox.AcceptsReturn = true;
            this.StatusLogBox.AcceptsTab = true;
            this.StatusLogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLogBox.Enabled = false;
            this.StatusLogBox.Location = new System.Drawing.Point(507, 0);
            this.StatusLogBox.MaxLength = 999999;
            this.StatusLogBox.MinimumSize = new System.Drawing.Size(512, 150);
            this.StatusLogBox.Multiline = true;
            this.StatusLogBox.Name = "StatusLogBox";
            this.StatusLogBox.ReadOnly = true;
            this.StatusLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatusLogBox.Size = new System.Drawing.Size(512, 150);
            this.StatusLogBox.TabIndex = 1;
            // 
            // panelBoxBottom
            // 
            this.panelBoxBottom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBoxBottom.Controls.Add(this.img_MapButton);
            this.panelBoxBottom.Controls.Add(this.StatusLogBox);
            this.panelBoxBottom.Controls.Add(this.txt_PlayerLocation);
            this.panelBoxBottom.Controls.Add(this.txt_dateTime);
            this.panelBoxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBoxBottom.Location = new System.Drawing.Point(0, 616);
            this.panelBoxBottom.Name = "panelBoxBottom";
            this.panelBoxBottom.Size = new System.Drawing.Size(1022, 150);
            this.panelBoxBottom.TabIndex = 2;
            this.panelBoxBottom.Visible = false;
            // 
            // img_MapButton
            // 
            this.img_MapButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_MapButton.Image = global::HavanaRPG.Properties.Resources.menu_map_image;
            this.img_MapButton.InitialImage = global::HavanaRPG.Properties.Resources.menu_map_image;
            this.img_MapButton.Location = new System.Drawing.Point(278, 11);
            this.img_MapButton.MinimumSize = new System.Drawing.Size(212, 127);
            this.img_MapButton.Name = "img_MapButton";
            this.img_MapButton.Size = new System.Drawing.Size(212, 127);
            this.img_MapButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_MapButton.TabIndex = 2;
            this.img_MapButton.TabStop = false;
            this.img_MapButton.Click += new System.EventHandler(this.img_MapButton_Click);
            // 
            // txt_PlayerLocation
            // 
            this.txt_PlayerLocation.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PlayerLocation.Location = new System.Drawing.Point(-4, 103);
            this.txt_PlayerLocation.MinimumSize = new System.Drawing.Size(160, 30);
            this.txt_PlayerLocation.Name = "txt_PlayerLocation";
            this.txt_PlayerLocation.Size = new System.Drawing.Size(250, 35);
            this.txt_PlayerLocation.TabIndex = 1;
            this.txt_PlayerLocation.Text = "Monxevis";
            this.txt_PlayerLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_dateTime
            // 
            this.txt_dateTime.Location = new System.Drawing.Point(-3, 11);
            this.txt_dateTime.MinimumSize = new System.Drawing.Size(140, 30);
            this.txt_dateTime.Name = "txt_dateTime";
            this.txt_dateTime.Size = new System.Drawing.Size(250, 35);
            this.txt_dateTime.TabIndex = 0;
            this.txt_dateTime.Text = "Morning - 01/01/431";
            this.txt_dateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainContainerView
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1022, 766);
            this.ControlBox = false;
            this.Controls.Add(this.panelBoxBottom);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainContainerView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HavanaView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelBoxBottom.ResumeLayout(false);
            this.panelBoxBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_MapButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripComboBox cb_Main;
        public System.Windows.Forms.ToolStripComboBox cb_two;
        public System.Windows.Forms.ToolStripProgressBar pb_ExpBar;
        public System.Windows.Forms.ToolStripLabel txt_PlayerName;
        public System.Windows.Forms.ToolStripLabel txt_Level;
        public System.Windows.Forms.ToolStripLabel txt_Gold;
        public System.Windows.Forms.TextBox StatusLogBox;
        public System.Windows.Forms.Panel panelBoxBottom;
        public System.Windows.Forms.Label txt_PlayerLocation;
        public System.Windows.Forms.Label txt_dateTime;
        public System.Windows.Forms.PictureBox img_MapButton;
        public System.Windows.Forms.ToolStripLabel txt_PlayerHp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        public System.Windows.Forms.ToolStripLabel txt_PlayerEp;
        public System.Windows.Forms.ToolStrip toolStrip1;
    }
}
