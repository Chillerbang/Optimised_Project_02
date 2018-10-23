using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    class VelcoityFunctionPrey
    {
        private Prey current;
        private Prey best;
        private Predator Scary;
        private List<Predator> predatorsBeforeMoveList;
        private Bitmap bmp;
        private Random rnd;
        private double clamp;
        private double alphax;
        private double betax;
        private double alphay;
        private double betay;
        private int maxheight;
        private int maxwidth;
        private double tired;
        private bool predatorConsider;
        private double fearRadius;
        private double fearReaction;

        public VelcoityFunctionPrey(Prey current, List<Predator> predatorsBeforeMoveList, Prey best,  double clamp, double alphax, double betax, double alphay, double betay,Bitmap bmp, double tired, bool predatorConsider, double fearRadius, double fearReaction)
        {
            rnd = new Random();
            this.current = current;
            this.best = best;
            this.clamp = clamp;
            //this.predators = predators;
            this.alphax = alphax ;
            this.betax = betax;
            this.alphay = alphay;
            this.betay = betay;
            this.bmp = bmp;
            this.predatorsBeforeMoveList = predatorsBeforeMoveList;
            this.maxheight = bmp.Height-1;
            this.maxwidth = bmp.Width-1;
            this.tired = tired;
            this.predatorConsider = predatorConsider;
            this.fearReaction = fearReaction;
            this.fearRadius = fearRadius;
        }

        public Prey newPrey()
        {
            //update Velocity
            current.Velocity.y += (clamp * alphay * (current.Posbest.y - current.CurrentPostion.y) + clamp * betay * (best.CurrentPostion.y - current.CurrentPostion.y))* tired;
            current.Velocity.x += (clamp * alphax * (current.Posbest.x - current.CurrentPostion.x) + clamp * betax * (best.CurrentPostion.x - current.CurrentPostion.x))*tired;
            // Add fear of predator
            int newx = ((int)current.Velocity.x + current.CurrentPostion.x);
            int newy = ((int)current.Velocity.y + current.CurrentPostion.y);
            bool changeDir = false;
            if (predatorConsider)
            {
                // we will look around the destimation point if there is predator
                //alter x or y velocity
                foreach (Predator p in predatorsBeforeMoveList)
                {
                    if (Math.Abs(newx - p.CurrentPostion.x) < fearRadius && Math.Abs(newy - p.CurrentPostion.y) < fearRadius)
                    {
                        changeDir = true;
                        Scary = p;

                        break;
                    }
                }
                if (changeDir)
                {
                    
                    switch (rnd.Next(3))
                    {
                        case 0:
                            current.Velocity.y = -current.Velocity.y;
                            break;
                        case 1:
                            current.Velocity.y = -current.Velocity.y;
                            current.Velocity.x = -current.Velocity.x;
                            break;
                        case 2:
                            current.Velocity.x = -current.Velocity.x;
                            break;
                    }
                }
            }
            newx = ((int)current.Velocity.x + current.CurrentPostion.x);
            newy = ((int)current.Velocity.y + current.CurrentPostion.y);

            if ((current.CurrentPostion.x == best.CurrentPostion.x) && (current.CurrentPostion.y == best.CurrentPostion.y))
            {
                // dont touch it
                if (changeDir)
                {
                    //***********************************************************************
                    newx = ((int)Scary.Velocity.x + Scary.CurrentPostion.x);
                    newy = ((int)Scary.Velocity.y + Scary.CurrentPostion.y);
                    if (newx > maxwidth)
                    {
                        newx = maxwidth;
                        current.Velocity.x = 0;
                    }
                    

                    if (newx < 0)
                    {
                        newx = 0;
                    }

                    if (newy > maxheight)
                    {
                        newy = maxheight;
                        current.Velocity.y = 0;
                    }

                    if (newy < 0)
                    {
                        newy = 0;
                    }

                    current.CurrentPostion.x = newx;
                    current.CurrentPostion.y = newy;
                    current.CurrentPostion.score = bmp.GetPixel(newx, newy).B;
                    //**********************************************************************
                }
                else
                {
                    current.Velocity.x = 0;
                    current.Velocity.y = 0;
                }
            }
            else
            {
                if (newx > maxwidth)
                {
                    newx = maxwidth;
                    current.Velocity.x = 0;
                }


                if (newx < 0)
                {
                    newx = 0;
                }

                if (newy > maxheight)
                {
                    newy = maxheight;
                    current.Velocity.y = 0;
                }

                if (newy < 0)
                {
                    newy = 0;
                }

                current.CurrentPostion.score = bmp.GetPixel(newx, newy).B;
                current.CurrentPostion.x = newx;
                current.CurrentPostion.y = newy;

            }

            return current;
        }
    }
}
