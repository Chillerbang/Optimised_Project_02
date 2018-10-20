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
            PerlinNoise perlinNoise = new PerlinNoise(1);
            Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
            double widthDivisor = 1 / (double)panel1.Width;
            double heightDivisor = 1 / (double)panel1.Height;
            Point point = new Point();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    double v = (perlinNoise.Noise(2 * point.X * widthDivisor, 2 * point.Y * heightDivisor, -0.5) + 1) / 2 * 0.7 +
                        (perlinNoise.Noise(4 * point.X * widthDivisor, 4 * point.Y * heightDivisor, 0) + 1) / 2 * 0.2 +
                            (perlinNoise.Noise(8 * point.X * widthDivisor, 8 * point.Y * heightDivisor, +0.5) + 1) / 2 * 0.1;
                    v = Math.Min(1, Math.Max(0, v));
                    byte b = (byte)(v * 255);
                    bitmap.SetPixel(i, j, Color.FromArgb(b, b, b));
                }
            }
            panel1.BackgroundImage = bitmap;

        }
        }
}
