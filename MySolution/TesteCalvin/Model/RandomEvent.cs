using HavanaRPG.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    public class RandomEvent
    {
        public string EventName { get; set; }
        public string Message { get; set; }
        public decimal Probability { get; set; } //0 to 100

        public RandomEvent()
        {
            Message = "";
        }

        public virtual void OnEventCall()
        {
            GameplayLib.ShowLogStatusMsg(Message);
        }
    }
}
