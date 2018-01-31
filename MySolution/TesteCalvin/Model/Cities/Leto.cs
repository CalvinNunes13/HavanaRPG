using HavanaRPG.Model.NPCs;
using HavanaRPG.Model.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model.Cities
{
    class Leto : Location
    {
        public Leto()
        {
            LocalName = "Leto";
            Description = "";
            var npcDamian = new Damian();
            npcDamian.Local = this;
            Npcs.Add(npcDamian);
            Shops.Add(new SimpleEquipShop());
        }
    }
}
