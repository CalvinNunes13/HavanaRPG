using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    class Location
    {
        public string LocalName { get; set; }
        public string ImgSource { get; set; }
        public string Description { get; set; }
        public List<Location> Places { get; set; }
        public List<Shop> Shops { get; set; }
        public List<Npc> Npcs { get; set; }
    }
}
