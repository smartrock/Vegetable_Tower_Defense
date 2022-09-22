using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Tower_Defense
{
    class GetVegieInfo
    {
        public GetVegieInfo(int type, int health, int speed)
        {
            Type = type;
            Health = health;
            Speed = speed;
        }

        public int Type { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
    }
}
