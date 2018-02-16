using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HavanaRPG.Model
{
    public class Quest
    {
        public int QuestId { get; set; }
        public bool MainQuest { get; set; }
        public string QuestName { get; set; }
        public string Description { get; set; }
        public decimal XpRecompense { get; set; }
        public List<Item> ItensRecompense { get; set; }
        public Npc AskedBy { get; set; }

        public Quest()
        {
            ItensRecompense = new List<Item>();
            MainQuest = false;
            QuestName = "Quest";
            Description = "";
            XpRecompense = 0;
        }
    }
}
