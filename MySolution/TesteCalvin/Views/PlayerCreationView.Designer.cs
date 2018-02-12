namespace HavanaRPG.Views
{
    partial class PlayerCreationView
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.txt_classInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_gender = new System.Windows.Forms.ComboBox();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.img_charRace = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_charRace)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.txt_classInfo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_gender);
            this.panel1.Controls.Add(this.cbx_class);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.img_charRace);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 483);
            this.panel1.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(855, 428);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 50);
            this.btn_start.TabIndex = 11;
            this.btn_start.Text = "Start Game!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(13, 428);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(100, 50);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "< Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txt_classInfo
            // 
            this.txt_classInfo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_classInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_classInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_classInfo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_classInfo.Location = new System.Drawing.Point(369, 44);
            this.txt_classInfo.Multiline = true;
            this.txt_classInfo.Name = "txt_classInfo";
            this.txt_classInfo.ReadOnly = true;
            this.txt_classInfo.Size = new System.Drawing.Size(272, 378);
            this.txt_classInfo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(975, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Character Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cbx_gender
            // 
            this.cbx_gender.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_gender.FormattingEnabled = true;
            this.cbx_gender.ItemHeight = 26;
            this.cbx_gender.Location = new System.Drawing.Point(107, 195);
            this.cbx_gender.MinimumSize = new System.Drawing.Size(150, 0);
            this.cbx_gender.Name = "cbx_gender";
            this.cbx_gender.Size = new System.Drawing.Size(250, 34);
            this.cbx_gender.TabIndex = 4;
            this.cbx_gender.SelectedIndexChanged += new System.EventHandler(this.cbx_gender_SelectedIndexChanged);
            // 
            // cbx_class
            // 
            this.cbx_class.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.ItemHeight = 26;
            this.cbx_class.Location = new System.Drawing.Point(107, 132);
            this.cbx_class.MinimumSize = new System.Drawing.Size(150, 0);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(250, 34);
            this.cbx_class.TabIndex = 3;
            this.cbx_class.SelectedIndexChanged += new System.EventHandler(this.cbx_class_SelectedIndexChanged);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(107, 71);
            this.txt_name.MaxLength = 20;
            this.txt_name.MinimumSize = new System.Drawing.Size(250, 34);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(250, 33);
            this.txt_name.TabIndex = 2;
            // 
            // img_charRace
            // 
            this.img_charRace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_charRace.InitialImage = global::HavanaRPG.Properties.Resources.humano;
            this.img_charRace.Location = new System.Drawing.Point(647, 44);
            this.img_charRace.Name = "img_charRace";
            this.img_charRace.Size = new System.Drawing.Size(308, 378);
            this.img_charRace.TabIndex = 0;
            this.img_charRace.TabStop = false;
            // 
            // PlayerCreationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1000, 508);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "PlayerCreationView";
            this.Shown += new System.EventHandler(this.PlayerCreationView_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_charRace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox cbx_gender;
        protected System.Windows.Forms.ComboBox cbx_class;
        protected System.Windows.Forms.TextBox txt_name;
        protected System.Windows.Forms.TextBox txt_classInfo;
        protected System.Windows.Forms.PictureBox img_charRace;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_back;
    }
}
