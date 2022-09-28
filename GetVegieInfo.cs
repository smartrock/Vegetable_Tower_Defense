using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Tower_Defense
{
    class GetVegieInfo
    {
        //Grabbing the vegetables values it will have

        public GetVegieInfo(int type, int health, int speed)
        {
            Type = type;
            Health = health;
            Speed = speed;
        }

        // Variables that will set for each individual vegetable
        public int Type { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
    }
}
