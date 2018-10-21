using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    interface Particle
    {
        BestPostion Pbest
        {
            get;
        }

        Point CurrentPostion
        {
            get;
            set;
        }

        Velocity Velocity
        {
            get;
            set;
        }

    }
}
