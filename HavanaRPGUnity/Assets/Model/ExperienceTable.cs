using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HavanaRPG.Model
{
    public class ExperienceTable
    {
        public static decimal ExpLevel1 = 0;
        public static decimal ExpLevel2 = 50;
        public static decimal ExpLevel3 = 75;
        public static decimal ExpLevel4 = 120;
        public static decimal ExpLevel5 = 200;
        public static decimal ExpLevel6 = 240;
        public static decimal ExpLevel7 = 290;
        public static decimal ExpLevel8 = 340;
        public static decimal ExpLevel9 = 400;
        public static decimal ExpLevel10 = 460;
        public static decimal ExpLevel11 = 520;
        public static decimal ExpLevel12 = 585;
        public static decimal ExpLevel13 = 650;
        public static decimal ExpLevel14 = 720;
        public static decimal ExpLevel15 = 800;
        public static decimal ExpLevel16 = 880;
        public static decimal ExpLevel17 = 960;
        public static decimal ExpLevel18 = 1050;
        public static decimal ExpLevel19 = 1175;
        public static decimal ExpLevel20 = 1290;

        public static List<decimal> XpTable = new List<decimal>(new decimal[] {
            ExpLevel1,
            ExpLevel2,
            ExpLevel3,
            ExpLevel4,
            ExpLevel5,
            ExpLevel6,
            ExpLevel7,
            ExpLevel8,
            ExpLevel9,
            ExpLevel10,
            ExpLevel11,
            ExpLevel12,
            ExpLevel13,
            ExpLevel14,
            ExpLevel15,
            ExpLevel16,
            ExpLevel17,
            ExpLevel18,
            ExpLevel19,
            ExpLevel20
        }); 

    }
}
