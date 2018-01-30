using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    public class Shop
    {
        public string ShopName { get; set; }
        public Location Local { get; set; }
        public Npc OwnedBy { get; set; }
        public List<Item> Selling { get; set; }
        public List<Item> Buying { get; set; }
        public string ImgSource { get; set; }

        public Shop()
        {

        }
    }
}
