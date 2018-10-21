﻿using System;
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
        private double alphax;
        private double betax;
        private double alphay;
        private double betay;
        private int maxheight;
        private int maxwidth;

        public VelocityFunctionPredator(Predator current, Prey best, double clamp, double alphax, double betax, double alphay, double betay, int maxheight, int maxwidth)
        {
            this.current = current;
            this.best = best;
            this.clamp = clamp;
            this.alphax = alphax;
            this.betax = betax;
            this.alphay = alphay;
            this.betay = betay;
        }

        public Predator newPredator()
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