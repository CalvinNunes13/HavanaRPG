﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    class Npc
    {
        public string Name { get; set; }
        public Location Local { get; set; }
        public List<string> QuestionTalks { get; set; }
        public List<string> Greetings { get; set; }
        public List<string> ByeTalk { get; set; }

        public Npc()
        {

        }

        public virtual void OnStartTalk()
        {
            var msg = ReturnGreeting();
        }

        public virtual void OnEndTalk()
        {
            var msg = ReturnByeTalk();
        }

        public virtual string ReturnGreeting()
        {
            var msg = "";
            var rndMsg = new Random();
            var idx = rndMsg.Next(Greetings.Count - 1, 0);
            msg = Greetings[idx];
            return msg;
        }

        public virtual string ReturnByeTalk()
        {
            var msg = "";
            var rndMsg = new Random();
            var idx = rndMsg.Next(ByeTalk.Count - 1, 0);
            msg = ByeTalk[idx];
            return msg;
        }
    }
}