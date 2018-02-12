namespace HavanaRPG.Views
{
    partial class TalkView
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
            this.panel_npcs = new System.Windows.Forms.GroupBox();
            this.list_npcList = new System.Windows.Forms.ListBox();
            this.img_npc = new System.Windows.Forms.PictureBox();
            this.panel_npcTalk = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_Greet = new System.Windows.Forms.TextBox();
            this.txt_talk = new System.Windows.Forms.TextBox();
            this.panel_optionsAnswer = new System.Windows.Forms.FlowLayoutPanel();
            this.list_answers = new System.Windows.Forms.ListBox();
            this.btn_startTalk = new System.Windows.Forms.Button();
            this.btn_exitTalk = new System.Windows.Forms.Button();
            this.txt_nameJob = new System.Windows.Forms.Label();
            this.panel_npcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_npc)).BeginInit();
            this.panel_npcTalk.SuspendLayout();
            this.panel_optionsAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_npcs
            // 
            this.panel_npcs.Controls.Add(this.list_npcList);
            this.panel_npcs.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_npcs.Location = new System.Drawing.Point(934, 0);
            this.panel_npcs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_npcs.Name = "panel_npcs";
            this.panel_npcs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_npcs.Size = new System.Drawing.Size(233, 625);
            this.panel_npcs.TabIndex = 0;
            this.panel_npcs.TabStop = false;
            this.panel_npcs.Text = "NPC\'s";
            // 
            // list_npcList
            // 
            this.list_npcList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_npcList.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_npcList.FormattingEnabled = true;
            this.list_npcList.ItemHeight = 22;
            this.list_npcList.Location = new System.Drawing.Point(8, 25);
            this.list_npcList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list_npcList.Name = "list_npcList";
            this.list_npcList.Size = new System.Drawing.Size(217, 554);
            this.list_npcList.TabIndex = 0;
            this.list_npcList.SelectedIndexChanged += new System.EventHandler(this.list_npcList_SelectedIndexChanged);
            // 
            // img_npc
            // 
            this.img_npc.Location = new System.Drawing.Point(14, 15);
            this.img_npc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.img_npc.Name = "img_npc";
            this.img_npc.Size = new System.Drawing.Size(173, 262);
            this.img_npc.TabIndex = 1;
            this.img_npc.TabStop = false;
            // 
            // panel_npcTalk
            // 
            this.panel_npcTalk.BackColor = System.Drawing.Color.White;
            this.panel_npcTalk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_npcTalk.Controls.Add(this.txt_Greet);
            this.panel_npcTalk.Controls.Add(this.txt_talk);
            this.panel_npcTalk.Location = new System.Drawing.Point(195, 16);
            this.panel_npcTalk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_npcTalk.Name = "panel_npcTalk";
            this.panel_npcTalk.Size = new System.Drawing.Size(731, 260);
            this.panel_npcTalk.TabIndex = 2;
            // 
            // txt_Greet
            // 
            this.txt_Greet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Greet.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Greet.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Greet.Location = new System.Drawing.Point(3, 4);
            this.txt_Greet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Greet.Multiline = true;
            this.txt_Greet.Name = "txt_Greet";
            this.txt_Greet.Size = new System.Drawing.Size(724, 62);
            this.txt_Greet.TabIndex = 0;
            // 
            // txt_talk
            // 
            this.txt_talk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_talk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_talk.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_talk.Location = new System.Drawing.Point(3, 74);
            this.txt_talk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_talk.Multiline = true;
            this.txt_talk.Name = "txt_talk";
            this.txt_talk.Size = new System.Drawing.Size(724, 186);
            this.txt_talk.TabIndex = 1;
            // 
            // panel_optionsAnswer
            // 
            this.panel_optionsAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_optionsAnswer.Controls.Add(this.list_answers);
            this.panel_optionsAnswer.Location = new System.Drawing.Point(195, 284);
            this.panel_optionsAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_optionsAnswer.Name = "panel_optionsAnswer";
            this.panel_optionsAnswer.Size = new System.Drawing.Size(731, 313);
            this.panel_optionsAnswer.TabIndex = 3;
            // 
            // list_answers
            // 
            this.list_answers.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_answers.FormattingEnabled = true;
            this.list_answers.ItemHeight = 18;
            this.list_answers.Location = new System.Drawing.Point(3, 4);
            this.list_answers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.list_answers.Name = "list_answers";
            this.list_answers.Size = new System.Drawing.Size(725, 292);
            this.list_answers.TabIndex = 0;
            // 
            // btn_startTalk
            // 
            this.btn_startTalk.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startTalk.Location = new System.Drawing.Point(14, 463);
            this.btn_startTalk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_startTalk.Name = "btn_startTalk";
            this.btn_startTalk.Size = new System.Drawing.Size(171, 66);
            this.btn_startTalk.TabIndex = 4;
            this.btn_startTalk.Text = "Talk...";
            this.btn_startTalk.UseVisualStyleBackColor = true;
            this.btn_startTalk.Click += new System.EventHandler(this.btn_startTalk_Click);
            // 
            // btn_exitTalk
            // 
            this.btn_exitTalk.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitTalk.Location = new System.Drawing.Point(14, 537);
            this.btn_exitTalk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exitTalk.Name = "btn_exitTalk";
            this.btn_exitTalk.Size = new System.Drawing.Size(171, 66);
            this.btn_exitTalk.TabIndex = 5;
            this.btn_exitTalk.Text = "Leave";
            this.btn_exitTalk.UseVisualStyleBackColor = true;
            this.btn_exitTalk.Click += new System.EventHandler(this.btn_exitTalk_Click);
            // 
            // txt_nameJob
            // 
            this.txt_nameJob.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nameJob.Location = new System.Drawing.Point(14, 284);
            this.txt_nameJob.Name = "txt_nameJob";
            this.txt_nameJob.Size = new System.Drawing.Size(175, 75);
            this.txt_nameJob.TabIndex = 1;
            this.txt_nameJob.Text = "Name and job";
            this.txt_nameJob.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TalkView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1167, 625);
            this.Controls.Add(this.btn_exitTalk);
            this.Controls.Add(this.txt_nameJob);
            this.Controls.Add(this.btn_startTalk);
            this.Controls.Add(this.panel_optionsAnswer);
            this.Controls.Add(this.panel_npcTalk);
            this.Controls.Add(this.img_npc);
            this.Controls.Add(this.panel_npcs);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TalkView";
            this.panel_npcs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_npc)).EndInit();
            this.panel_npcTalk.ResumeLayout(false);
            this.panel_npcTalk.PerformLayout();
            this.panel_optionsAnswer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panel_npcs;
        public System.Windows.Forms.ListBox list_npcList;
        public System.Windows.Forms.PictureBox img_npc;
        public System.Windows.Forms.FlowLayoutPanel panel_npcTalk;
        private System.Windows.Forms.FlowLayoutPanel panel_optionsAnswer;
        public System.Windows.Forms.Button btn_startTalk;
        public System.Windows.Forms.Button btn_exitTalk;
        public System.Windows.Forms.TextBox txt_Greet;
        public System.Windows.Forms.TextBox txt_talk;
        public System.Windows.Forms.ListBox list_answers;
        public System.Windows.Forms.Label txt_nameJob;
    }
}
