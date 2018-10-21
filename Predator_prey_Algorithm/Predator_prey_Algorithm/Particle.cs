using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    interface Particle
    {
        int velocity
        {
            get;
            set;
        }

        int x
        {
            get;
            set;
        }
        int y
        {
            get;
            set;
        }

        void updateVelocity();

    }
}
