using HavanaRPG.Views;

namespace HavanaRPG
{
    partial class MainView : HavanaView
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
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_LoadGame = new System.Windows.Forms.Button();
            this.btn_ExitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_NewGame.Location = new System.Drawing.Point(82, 523);
            this.btn_NewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(170, 71);
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.Btn_NewGameClick);
            // 
            // btn_LoadGame
            // 
            this.btn_LoadGame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_LoadGame.Location = new System.Drawing.Point(82, 604);
            this.btn_LoadGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LoadGame.Name = "btn_LoadGame";
            this.btn_LoadGame.Size = new System.Drawing.Size(170, 71);
            this.btn_LoadGame.TabIndex = 1;
            this.btn_LoadGame.Text = "Load Game";
            this.btn_LoadGame.UseVisualStyleBackColor = true;
            this.btn_LoadGame.Click += new System.EventHandler(this.Btn_LoadGameClick);
            // 
            // btn_ExitGame
            // 
            this.btn_ExitGame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_ExitGame.Location = new System.Drawing.Point(82, 766);
            this.btn_ExitGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ExitGame.Name = "btn_ExitGame";
            this.btn_ExitGame.Size = new System.Drawing.Size(170, 71);
            this.btn_ExitGame.TabIndex = 2;
            this.btn_ExitGame.Text = "Exit Game";
            this.btn_ExitGame.UseVisualStyleBackColor = true;
            this.btn_ExitGame.Click += new System.EventHandler(this.Btn_ExitGameClick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.btn_ExitGame);
            this.Controls.Add(this.btn_LoadGame);
            this.Controls.Add(this.btn_NewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Havana RPG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainView_FormClosed);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_LoadGame;
        private System.Windows.Forms.Button btn_ExitGame;
    }
}

