using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_objects
{
    internal class player
    {
        public string name = "sudarshan";
        private int health = 39;

        public int getHealth()
        {
            return health;
        }
        public void setHealth(int h)
        {
            health = h;
        }
    }
}
