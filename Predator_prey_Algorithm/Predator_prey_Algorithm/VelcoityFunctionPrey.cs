using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    class VelcoityFunctionPrey
    {
        private Prey current;
        private Prey best;
        private Predator[] predators;

        private double clamp;
        private double alphax;
        private double betax;
        private double alphay;
        private double betay;
        private int maxheight;
        private int maxwidth;

        public VelcoityFunctionPrey(Prey current, Prey best, Predator[] predators, double clamp, double alphax, double betax, double betay, double alphay, int maxheight, int maxwidth)
        {
            this.current = current;
            this.best = best;
            this.clamp = clamp;
            this.predators = predators;
            this.alphax = alphax;
            this.betax = betax;
            this.alphay = alphay;
            this.betay = betay;
        }

        public Prey newPrey()
        {
            //update Velocity
            current.Velocity.y += clamp * alphay * (current.Posbest.y - current.CurrentPostion.y) + clamp * betay * (best.CurrentPostion.y - current.CurrentPostion.y);
            current.Velocity.x += clamp * alphax * (current.Posbest.x - current.CurrentPostion.x) + clamp * betax * (best.CurrentPostion.x - current.CurrentPostion.x);

            if (((int)current.Velocity.x + current.CurrentPostion.x) > maxwidth)
            {
                current.CurrentPostion.x = maxwidth;
            }
            else
            {
                current.CurrentPostion.x += (int)current.Velocity.x;
            }

            if (((int)current.Velocity.y + current.CurrentPostion.y) > maxheight)
            {
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
