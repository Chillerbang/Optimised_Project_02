using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_Algorithm
{
    class Predator : Particle
    {


        public Predator(int width, int height, double score)
        {
            CurrentPostion = new Point();
            Velocity = new Velocity();
            Posbest = new BestPostion();
            CurrentPostion.x = width;
            CurrentPostion.y = height;
            Posbest.x = width;
            Posbest.y = height;
            Posbest.score = score;
        }

        public Point CurrentPostion { get; set; }

        public Velocity Velocity { get; set; }

        public BestPostion Posbest { get; }
    }
}
