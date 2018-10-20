using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    class Prey:Particle
    {
        private int _x;
        private int _y;

        public Prey(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void updateVelocity()
        {

        }

        

        public int x { get { return _x; } set { this._x = value; } }
        public int y { get { return _y; } set { this._y = value; } }

    }
}
