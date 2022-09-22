using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Tower_Defense
{
    class GetUnitInfo
    {
        public GetUnitInfo(int type, int speed, int range, int damage)
        {
            Type = type;
            Speed = speed;
            Range = range;
            Damage = damage;

        }

        public int Type { get; set; }
        public int Speed { get; set; }
        public int Range { get; set; }
        public int Damage { get; set; }

    }
}
