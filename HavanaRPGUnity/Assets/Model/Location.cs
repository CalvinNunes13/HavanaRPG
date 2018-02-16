using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace HavanaRPG.Model
{
    public class Location : MonoBehaviour
    {
        public string LocalName { get; set; }
        public Image ImgSource { get; set; }
        public string Description { get; set; }
        public List<Location> Places { get; set; }
        public List<Shop> Shops { get; set; }
        public List<Npc> Npcs { get; set; }
        public List<Location> PossibleDestinations { get; set; }
        public List<RandomEvent> PossibleEvents { get; set; }

        public Location()
        {
            Places = new List<Location>();
            Shops = new List<Shop>();
            Npcs = new List<Npc>();
            PossibleDestinations = new List<Location>();
            PossibleEvents = new List<RandomEvent>();
            LocalName = "Local";
        }
    }
}
