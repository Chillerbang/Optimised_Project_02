﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    class VelocityFunctionPredator
    {
        private Predator current;
        private Prey best;
        private Bitmap bmp;

        private static double predatorPenalty = 0.5;
        private double huntBest = 1;
        private static double fogetPast = 1;
        private double clamp;
        private int past = 0;
        private double alphax;
        private double betax;
        private double alphay;
        private double betay;
        private int maxheight;
        private int maxwidth;
        private double tired;

        public VelocityFunctionPredator(Predator current, Prey best, double clamp, double alphax, double betax, double alphay, double betay, Bitmap bmp, double tired)
        {
            this.current = current;
            this.best = best;
            this.clamp = clamp;
            this.alphax = alphax + huntBest;
            this.betax = betax* fogetPast;
            this.alphay = alphay + huntBest;
            this.betay = betay* fogetPast;
            this.bmp = bmp;
            this.maxheight = bmp.Height - 1;
            this.maxwidth = bmp.Width - 1;
            this.tired = tired;
        }

        public Predator newPredator()
        {
            //update Velocity
            current.Velocity.y += ((clamp * alphay * (current.Posbest.y - current.CurrentPostion.y)*past + clamp * (betay * (best.CurrentPostion.y - current.CurrentPostion.y))) )* tired* predatorPenalty;
            current.Velocity.x += ((clamp * alphax * (current.Posbest.x - current.CurrentPostion.x) * past + clamp * (betax * (best.CurrentPostion.x - current.CurrentPostion.x))) )* tired* predatorPenalty;

            if ((current.CurrentPostion.x == best.CurrentPostion.x) && (current.CurrentPostion.y == best.CurrentPostion.y))
            {
                // dont touch it
            }
            else
            {
                if (((int)current.Velocity.x + current.CurrentPostion.x) > maxwidth)
                {
                    current.CurrentPostion.x = maxwidth;
                    current.Velocity.x = 0;
                }
                else
                {
                    current.CurrentPostion.x += (int)current.Velocity.x;
                }

                if (((int)current.Velocity.x + current.CurrentPostion.x) < 0)
                {
                    current.CurrentPostion.x = 0;
                }

                if (((int)current.Velocity.y + current.CurrentPostion.y) > maxheight)
                {
                    current.CurrentPostion.y = maxheight;
                    current.Velocity.y = 0;
                }
                else
                {
                    current.CurrentPostion.y += (int)current.Velocity.y;
                }
                if (((int)current.Velocity.y + current.CurrentPostion.y) < 0)
                {
                    current.CurrentPostion.y = 0;
                }

                current.CurrentPostion.score = bmp.GetPixel(current.CurrentPostion.x, current.CurrentPostion.y).B;
            }
                return current;
        }
    }
}
