using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    class Predator : Particle
    {
        private int _x;
        private int _y;

        public Predator(int x, int y)
        {
            _x = x;
            _y = y;
        }


        public int x { get { return _x; } set { this._x = value; } }
        public int y { get { return _y; } set { this._y = value; } }

        public void updateVelocity()
        {
            throw new NotImplementedException();
        }
    }
}
