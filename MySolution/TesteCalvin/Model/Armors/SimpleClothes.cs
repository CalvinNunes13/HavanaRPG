using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HavanaRPG.Model;

namespace TesteCalvin.Model.Armors
{
    class SimpleClothes : Item
    {
        public SimpleClothes() {
            ItemName = "Simple Clothes";
            Description = "A very simple clothe made with wool.";
            BuyValue = 4;
            ArmorPts = 1;
        }
    }
}
