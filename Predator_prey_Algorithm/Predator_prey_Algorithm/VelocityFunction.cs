using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    class VelocityFunction
    {
        private Prey current;
        private Prey best;

        public VelocityFunction(Prey current, Prey best)
        {
            this.current = current;
            this.best = best;
        }

        public Prey newPostion()
        {

            return best;
        }
    }
}
