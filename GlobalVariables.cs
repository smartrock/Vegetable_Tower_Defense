using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Tower_Defense
{
    internal class GlobalVariables
    {
        // Across / inter class variables that will be used by mutliple forms and classes
        private static int V_score, V_money, V_lives, V_waves;
        private static bool V_play, V_space;
        // Lists to store the specific vegetables and units information
        private static List<GetVegieInfo> V_vegieinfo = new List<GetVegieInfo>();
        private static List<GetUnitInfo> U_unitinfo = new List<GetUnitInfo>();
        // Lists for what will be created during the game
        private static List<Vegetables> V_vegetables = new List<Vegetables>();
        private static List<Missile> V_missiles = new List<Missile>();
        private static List<Units> V_units = new List<Units>();

        // Defining and assigining values to the inter game variables
        public static int score
        {
            get { return V_score; }
            set { V_score = value; }
        }

        public static int money
        {
            get { return V_money; }
            set { V_money = value; }
        }

        public static int lives
        {
            get { return V_lives; }
            set { V_lives = value; }
        }

        public static int waves
        {
            get { return V_waves; }
            set { V_waves = value; }
        }
        
        public static bool play
        {
            get { return V_play; }
            set { V_play = value; }
        }
        
        public static bool space
        {
            get { return V_space; }
            set { V_space = value; }
        }

        public static List<GetVegieInfo> vegieInfo
        {
            get { return V_vegieinfo; }
            set { V_vegieinfo = value; }
        }

        public static List<GetUnitInfo> unitInfo
        {
            get { return U_unitinfo; }
            set { U_unitinfo = value; }
        }

        public static List<Vegetables> vegetables
        {
            get { return V_vegetables; }
            set { V_vegetables = value; }
        }

        public static List<Units> units
        {
            get { return V_units; }
            set { V_units = value; }
        }

        public static List<Missile> missiles
        {
            get { return V_missiles; }
            set { V_missiles = value; }
        }
    }
}
