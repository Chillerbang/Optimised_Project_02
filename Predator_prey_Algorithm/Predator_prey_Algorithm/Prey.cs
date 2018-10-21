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
        private int _velocityx;
        private int _velocityy;

        public Prey(int width, int height)
        {
            _x = width;
            _y = height;
            _velocityy = 0;
            _velocityx = 0;
        }

        public int x { get { return _x; } set { this._x = value; } }
        public int y { get { return _y; } set { this._y = value; } }

        public int velocityx { get { return _velocityx; } set { this._velocityx = value; } }
        public int velocityy { get { return _velocityy; } set { this._velocityy = value; } }

    }
}
