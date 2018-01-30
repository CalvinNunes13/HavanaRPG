using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model.NPCs
{
    class Damian : Npc
    {
        public Damian()
        {
            Name = "Damian";
            Local = null;
            Greetings.Add("Hello!");
            Greetings.Add("Hey! Wanna Talk?");
            Greetings.Add("Hi " + Player.FormatCall + "!");
            ByeTalk.Add("See you!");
            ByeTalk.Add("Bye.");
            QuestionTalks.Add("Do you need some directions?");
        }
    }
}
