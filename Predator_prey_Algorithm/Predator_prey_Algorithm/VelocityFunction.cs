using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    class VelocityFunction
    {
        private Predator current;
        private Predator best;
        private double clamp;
        private double randomx1;
        private double randomx2;
        private double randomy1;
        private double randomy2;
        private int learningFactor;
        
        public VelocityFunction(Predator current, Predator best, double clamp, double randomx1, double randomx2, double randomy2, double randomy1, int learningFactor)
        {
            this.current = current;
            this.best = best;
            this.clamp = clamp;
            this.randomx1 = randomx1;
            this.randomx2 = randomx2;
            this.randomy1 = randomy1;
            this.randomy2 = randomy2;
        }

        public Predator newPredator()
        {
            //update Velocity
            current.velocityy = learningFactor * current.velocityy + clamp * randomx1 * (best.velocityy - current.velocityy) + learningFactor * randomx2 *  
            return current;
        }
    }
}
