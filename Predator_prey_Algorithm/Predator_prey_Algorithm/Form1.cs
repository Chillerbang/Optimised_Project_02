using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predator_prey_Algorithm
{
    public partial class Form1 : Form
    {
        private int width;
        private int height;
        Random rnd;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            width = panel1.Width;
            height = panel1.Height;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Generate Graphic
            GenerateGraphic();
        }

        private void GenerateGraphic()
        {
            Bitmap bmp = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    using (Graphics graph = Graphics.FromImage(bmp))
                    {
                        Rectangle ImageSize = new Rectangle(i, j, 1, 1);
                        SolidBrush bs;
                            bs = new SolidBrush(Color.FromArgb(RandomiseAValue(), 0, 0, 0));
                        //blank color
                        //white color
                        
                        graph.FillRectangle(bs, ImageSize);
                    }
                }
            }
            panel1.BackgroundImage = bmp;
        }

        private void Noise(int seed )
        {
            rnd.Next(seed);
        }

        private int RandomiseAValue()
        {
            double mean = 200;
            double stdDev = 10;

            Normal normalDist = new Normal(mean, stdDev);
            double randomGaussianValue = normalDist.Sample();
            return (int)randomGaussianValue;
        }
    }
}
