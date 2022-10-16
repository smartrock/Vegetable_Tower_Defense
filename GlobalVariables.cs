using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Tower_Defense
{
    internal class GlobalVariables
    {
        private static int score, money, lives;
        private static List<GetVegieInfo> V_vegieinfo = new List<GetVegieInfo>();
        private static List<GetUnitInfo> U_unitinfo = new List<GetUnitInfo>();
        private static List<Vegetables> V_vegetables = new List<Vegetables>();
        private static List<Missile> V_missiles = new List<Missile>();
        private static List<Units> V_units = new List<Units>();

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
