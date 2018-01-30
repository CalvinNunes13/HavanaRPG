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
        new string ItemName = "Simple Clothes";
        new string Description = "A very simple clothe made with wool.";
        new decimal BuyValue = 4;
        new int ArmorPts = 1;
    }
}
