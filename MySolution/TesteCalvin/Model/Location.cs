using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavanaRPG.Model
{
    public class Location
    {
        public string LocalName { get; set; }
        public string ImgSource { get; set; }
        public string Description { get; set; }
        public Form SpecificView { get; set; }
        public List<Location> Places { get; set; }
        public List<Shop> Shops { get; set; }
        public List<Npc> Npcs { get; set; }
        public List<Location> PossibleDestinations { get; set; }
        public List<RandomEvent> PossibleEvents { get; set; }

        public Location()
        {
            LocalName = "Local";
            SpecificView = new LocationsView();
        }
    }
}
