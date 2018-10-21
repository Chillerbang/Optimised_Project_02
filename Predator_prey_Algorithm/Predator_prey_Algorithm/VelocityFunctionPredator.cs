using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    class VelocityFunctionPredator
    {
        private Predator current;
        private Prey best;
        private double clamp;
        private double randomx1;
        private double randomx2;
        private double randomy1;
        private double randomy2;
        private int maxheight;
        private int maxwidth;
        
        public VelocityFunctionPredator(Predator current, Prey best, double clamp, double randomx1, double randomx2, double randomy2, double randomy1, int maxheight, int maxwidth)
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
            current.Velocity.y += clamp * randomy1 * (current.Posbest.y - current.CurrentPostion.y) + clamp * randomy2 * (best.CurrentPostion.y - current.CurrentPostion.y);
            current.Velocity.x += clamp * randomx1 * (current.Posbest.x - current.CurrentPostion.x) + clamp * randomx2 * (best.CurrentPostion.x - current.CurrentPostion.x);

            if (((int)current.Velocity.x + current.CurrentPostion.x) > maxwidth)
            {
                current.CurrentPostion.x = maxwidth;
            }
            else
            {
                current.CurrentPostion.x += (int)current.Velocity.x;
            }

            if (((int)current.Velocity.y + current.CurrentPostion.y) > maxheight){
                current.CurrentPostion.y = maxheight;
            }
            else
            {
                current.CurrentPostion.y += (int)current.Velocity.y;
            }
            
            return current;
        }
    }
}
