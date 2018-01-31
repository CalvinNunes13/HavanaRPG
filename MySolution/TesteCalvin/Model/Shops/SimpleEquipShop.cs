using HavanaRPG.Model.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HavanaRPG.Model.Armors;

namespace HavanaRPG.Model.Shops
{
    class SimpleEquipShop : Shop
    {
        public SimpleEquipShop()
        {
            Selling.Add(new Club());
            Selling.Add(new SimpleClothes());            
        }
    }
}
