﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Tower_Defense
{
    internal class GlobalVariables
    {
        private static List<GetVegieInfo> V_vegieinfo = new List<GetVegieInfo>();

        public static List<GetVegieInfo> vegieInfo
        {
            get { return V_vegieinfo; }
            set { V_vegieinfo = value; }
        }

        private static List<GetUnitInfo> U_unitinfo = new List<GetUnitInfo>();

        public static List<GetUnitInfo> unitInfo
        {
            get { return U_unitinfo; }
            set { U_unitinfo = value; }
        }

        private static List<Vegetables> V_vegetables = new List<Vegetables>();

        public static List<Vegetables> vegetables
        {
            get { return V_vegetables; }
            set { V_vegetables = value; }
        }

        private static List<Missile> V_missiles = new List<Missile>();

        public static List<Missile> missiles
        {
            get { return V_missiles; }
            set { V_missiles = value; }
        }
    }
}