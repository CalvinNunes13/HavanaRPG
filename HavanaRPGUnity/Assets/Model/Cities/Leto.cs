using HavanaRPG.Model.NPCs;
using HavanaRPG.Model.Shops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HavanaRPG.Model.Cities
{
    public class Leto : Location
    {
        public Leto()
        {
            LocalName = "Leto";
            Description = "";
            var npcDamian = new Damian
            {
                Local = this
            };
            Npcs.Add(npcDamian);
            Shops.Add(new SimpleEquipShop());
        }
    }
}
