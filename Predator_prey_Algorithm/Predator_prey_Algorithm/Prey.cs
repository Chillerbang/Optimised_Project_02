using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    class Prey:Particle
    {

        public Prey(int width, int height, double score)
        {
            CurrentPostion.x = width;
            CurrentPostion.y = height;
            Pbest.x = width;
            Pbest.y = height;
            Pbest.score = score; 
        }

        public Point CurrentPostion { get; set; }

        public Velocity Velocity { get; set; }

        public BestPostion Pbest { get; }
    }
}
