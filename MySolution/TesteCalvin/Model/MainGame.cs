using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HavanaRPG.Model
{
    public class MainGame
    {
        public static int GameDateDay = 1;
        public static int GameDateMonth = 1;
        public static int GameDateYear = 411;
        public static decimal CreaturesKilled = 0;
        public static HavanaLib.DayTime TimeofDay = HavanaLib.DayTime.Morning;

        public static void RunGameTime()
        {
            HavanaLib.RunLoopTimer(HavanaLib.AdvanceDayTime, new TimeSpan(600000)); //10 minutos
        }

        public static void SaveGame()
        {

        }

        public static void LoadGame()
        {

        }

        public static void LoadPlayerInfo()
        {

        }

        public static void LoadGameState()
        {

        }
    }
}
