using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    class GlobalSwitches
    {
        public static List<string> Switches { get; set; } //TODO: alterar para lista de switches quando criar classe

        public GlobalSwitches()
        {
            Switches = new List<string>();
        }
    }
}
