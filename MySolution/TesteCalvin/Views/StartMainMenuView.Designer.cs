namespace HavanaRPG.Views
{
    partial class StartMainMenuView
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
            this.btn_newGame = new System.Windows.Forms.Button();
            this.btn_loadGame = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newGame
            // 
            this.btn_newGame.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newGame.Location = new System.Drawing.Point(12, 368);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(100, 50);
            this.btn_newGame.TabIndex = 0;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = true;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // btn_loadGame
            // 
            this.btn_loadGame.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadGame.Location = new System.Drawing.Point(12, 446);
            this.btn_loadGame.Name = "btn_loadGame";
            this.btn_loadGame.Size = new System.Drawing.Size(100, 50);
            this.btn_loadGame.TabIndex = 1;
            this.btn_loadGame.Text = "Load Game";
            this.btn_loadGame.UseVisualStyleBackColor = true;
            this.btn_loadGame.Click += new System.EventHandler(this.btn_loadGame_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(888, 446);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 50);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // StartMainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = global::HavanaRPG.Properties.Resources.Map;
            this.ClientSize = new System.Drawing.Size(1000, 508);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_loadGame);
            this.Controls.Add(this.btn_newGame);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "StartMainMenuView";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btn_newGame;
        protected System.Windows.Forms.Button btn_loadGame;
        protected System.Windows.Forms.Button btn_exit;
    }
}
