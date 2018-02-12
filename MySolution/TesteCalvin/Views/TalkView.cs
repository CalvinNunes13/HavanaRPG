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
    public partial class TalkView : HavanaRPG.Views.Controls.BaseForm
    {
        protected bool isTalking = false;

        public TalkView(Location local)
        {
            InitializeComponent();
            LoadAllNPCs(local);
        }

        private void btn_exitTalk_Click(object sender, EventArgs e)
        {
            if (isTalking)
            {
                this.txt_Greet.Text = "";
                this.txt_talk.Text = "";
                this.txt_nameJob.Text = "";
                this.img_npc.Image = null;
                this.list_npcList.Enabled = true;
                isTalking = false;
            }
            else
            {
                var lastView = ViewsController.LastForm;
                ViewsController.OpenNewCloseCurrent(lastView, true);
            }

        }

        private void btn_startTalk_Click(object sender, EventArgs e)
        {
            isTalking = true;
            this.list_npcList.Enabled = false;
            try
            {
                var selectedNPC = this.list_npcList.SelectedItem;
            }
            catch (Exception ex)
            {
                this.txt_Greet.Text = "";
                this.txt_talk.Text = "";
                this.img_npc.Image = null;
                this.list_npcList.Enabled = true;
                this.txt_nameJob.Text = "";
                isTalking = false;
            }
        }

        private void LoadAllNPCs(Location local)
        {
            var listNPCs = local.Npcs;
            if (listNPCs.Count <= 0)
            {
                var fakeNPC = new Npc();
                fakeNPC.Name = "There's no NPC to talk here.";
                listNPCs.Add(fakeNPC);
                this.list_npcList.Enabled = false;
            }
            this.list_npcList.DataSource = listNPCs;
            this.list_npcList.DisplayMember = "Name";
        }

        private void list_npcList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = this.list_npcList.SelectedItem;
        }
    }
}
