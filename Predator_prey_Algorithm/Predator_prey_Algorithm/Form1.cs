using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        private int gridSize = 1;
        private int seed = 10;
        private int numPrey = 50;
        private int numPredators = 1;
        private int maxIterations = 500;
        private int BestValue;
        double tired = 0.1;
        double clamp    =    0.1;
        double alphax   =    2;
        double betax    =    2;
        double alphay   =    2;
        double betay    =    2;

        Random rnd;
        private Bitmap savedImg = null;
        private Bitmap TempImg = null;
        private List<Particle> particlesList;

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
            gridSize = (int)nudSize.Value;
            seed = (int)nudSeed.Value;
            CreateBitmapAtRuntime();
        }

        private int GetInt(TextBox textBox)
        {
            int i = 0;
            return int.TryParse(textBox.Text, out i) ? i : 0;
        }

        public void CreateBitmapAtRuntime()
        {
            BestValue = 0;
            Bitmap flag = new Bitmap(width, height, PixelFormat.Format32bppRgb);
            Rectangle flagRect = new Rectangle(0, 0, width, height);
            Graphics flagGraphics = Graphics.FromImage(flag);

            System.Drawing.Imaging.BitmapData flagData = flag.LockBits(flagRect, ImageLockMode.ReadWrite, flag.PixelFormat);
            int imageByteSize = flagData.Stride * flagData.Height;
            byte[] destinationData = new byte[imageByteSize];
            int bitsPerPixelElement = 32 / 8;
            
            Simplex.Seed = seed;

            float[,] values = Simplex.Calc2D(width, height, 0.01f);
            for (int x = 0; x < width; x += gridSize)
            {
                for (int y = 0; y < height; y += gridSize)
                {
                    for (int i = 0; i < gridSize; i++)
                    {
                        if ((x + i) >= width) break;
                        for (int j = 0; j < gridSize; j++)
                        {
                            if ((y + j) >= height) break;
                            destinationData[(y + j) * flagData.Stride + (x + i) * bitsPerPixelElement + 2] = (byte)(values[x, y] * 0.6);
                            destinationData[(y + j) * flagData.Stride + (x + i) * bitsPerPixelElement + 1] = (byte)(values[x, y] * 0.6);
                            destinationData[(y + j) * flagData.Stride + (x + i) * bitsPerPixelElement] = (byte)values[x, y];

                            //get largest values
                            if (BestValue < (byte)values[x, y])
                            {
                                BestValue = (byte)values[x, y];
                            }
                        }
                    }
                }
            }
            System.Diagnostics.Debug.WriteLine(" Best Value " + BestValue);
            System.Runtime.InteropServices.Marshal.Copy(destinationData, 0, flagData.Scan0, destinationData.Length);
            flag.UnlockBits(flagData);
            panel1.BackgroundImage = flag;
            savedImg = flag;
            panel1.Invalidate();
        }

        private void runPreditor(object sender, EventArgs e)
        {
            numPredators = (int)numpreditors.Value;
            TempImg = savedImg.Clone(new Rectangle(0, 0, savedImg.Width, savedImg.Height), savedImg.PixelFormat);
            particlesList = new List<Particle>();
            //create prey
            int x;
            int y;
            Prey Best = new Prey(0,0,0);
            
            for (int i = 0; i < numPrey; i++)
            {
                x = rnd.Next(width);
                y = rnd.Next(height);
                particlesList.Add(new Prey(x, y, savedImg.GetPixel(x, y).B));
                if (Best.CurrentPostion.score < savedImg.GetPixel(x, y).B)
                {
                    Best.CurrentPostion.x = x;
                    Best.CurrentPostion.y = y;
                    Best.CurrentPostion.score = savedImg.GetPixel(x, y).B;
                    Best.Posbest.y = y;
                    Best.Posbest.x = x;
                    Best.Posbest.score = savedImg.GetPixel(x, y).B;
                    System.Diagnostics.Debug.WriteLine(" I found " + savedImg.GetPixel(x, y).B);
                }
            }
            for (int i = 0; i < numPredators; i++)
            {
                x = rnd.Next(width);
                y = rnd.Next(height);

                particlesList.Add(new Predator(x, y, savedImg.GetPixel(x, y).B));
            }
            
            DrawAllOfIt(TempImg,particlesList);
            int currentScoreMax = 0;
            int countGameIteration = 0;
            // now run algorithm
            while (true)
            {
                TempImg = savedImg.Clone(new Rectangle(0, 0, savedImg.Width, savedImg.Height), savedImg.PixelFormat);
                int countParticle = 0;
                Particle[] particlesArray = particlesList.ToArray();
                for (int i = 0; i < particlesArray.Length; i++)
                {
                    if (particlesArray[i] is Prey)
                    {
                        VelcoityFunctionPrey vfp = new VelcoityFunctionPrey((Prey)particlesArray[i], Best, clamp, alphax, betax, alphay, betay, TempImg,tired);
                        particlesArray[countParticle] = vfp.newPrey();
                        if (Best.CurrentPostion.score < particlesArray[countParticle].CurrentPostion.score )
                        {
                            Best.CurrentPostion.score = ((Prey)particlesArray[countParticle]).CurrentPostion.score;
                            Best.CurrentPostion.x = ((Prey)particlesArray[countParticle]).CurrentPostion.x;
                            Best.CurrentPostion.y = ((Prey)particlesArray[countParticle]).CurrentPostion.y;
                            Best.Posbest.score = ((Prey)particlesArray[countParticle]).Posbest.score;
                            Best.Posbest.x = ((Prey)particlesArray[countParticle]).Posbest.x;
                            Best.Posbest.y = ((Prey)particlesArray[countParticle]).Posbest.y;
                            Best.Velocity.x= ((Prey)particlesArray[countParticle]).Velocity.x;
                            Best.Velocity.y = ((Prey)particlesArray[countParticle]).Velocity.y;
                            
                        }
                        // update max score :) and we gucchi
                    }
                    else
                    {


                    }
                }
                //clamp =clamp* 0.1;
                particlesList = particlesArray.ToList();
                DrawAllOfIt(TempImg, particlesList);

                if (EndCondition(currentScoreMax))
                {
                    break;
                }

                countGameIteration++;

                if (!maxIteration(countGameIteration))
                {
                    //countGameIteration = 0;
                    //// restart
                    //particlesList = new List<Particle>();
                    ////create prey
                    //for (int i = 0; i < numPrey; i++)
                    //{
                    //    x = rnd.Next(width);
                    //    y = rnd.Next(height);
                    //    particlesList.Add(new Prey(x, y, savedImg.GetPixel(x, y).B));
                    //}
                    //for (int i = 0; i < numPredators; i++)
                    //{
                    //    x = rnd.Next(width);
                    //    y = rnd.Next(height);

                    //    particlesList.Add(new Predator(x, y, savedImg.GetPixel(x, y).B));
                    //}

                    break;
                }
                
            }
        }

        private void DrawAllOfIt(Bitmap image,List<Particle> state)
        {
            Graphics g = panel1.CreateGraphics();

            foreach (Particle p in state)
            {
                if (p is Predator)
                {
                    try
                    {
                    image.SetPixel(p.CurrentPostion.x, p.CurrentPostion.y, Color.Red);

                        image.SetPixel(p.CurrentPostion.x - 1, p.CurrentPostion.y - 1, Color.DarkRed);
                        image.SetPixel(p.CurrentPostion.x - 1, p.CurrentPostion.y, Color.DarkRed);
                        image.SetPixel(p.CurrentPostion.x - 1, p.CurrentPostion.y + 1, Color.DarkRed);
                        image.SetPixel(p.CurrentPostion.x, p.CurrentPostion.y + 1, Color.DarkRed);
                        image.SetPixel(p.CurrentPostion.x, p.CurrentPostion.y - 1, Color.DarkRed);
                        image.SetPixel(p.CurrentPostion.x + 1, p.CurrentPostion.y - 1, Color.DarkRed);
                        image.SetPixel(p.CurrentPostion.x + 1, p.CurrentPostion.y, Color.DarkRed);
                        image.SetPixel(p.CurrentPostion.x + 1, p.CurrentPostion.y + 1, Color.DarkRed);
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    try
                    {
                        image.SetPixel(p.CurrentPostion.x, p.CurrentPostion.y, Color.Yellow);
                        if ((p.CurrentPostion.x > 1) && (p.CurrentPostion.x < image.Width-1) && (p.CurrentPostion.y > 1) && (p.CurrentPostion.y < image.Height-1))
                        {
                            image.SetPixel(p.CurrentPostion.x - 1, p.CurrentPostion.y - 1, Color.GreenYellow);
                            image.SetPixel(p.CurrentPostion.x - 1, p.CurrentPostion.y, Color.GreenYellow);
                            image.SetPixel(p.CurrentPostion.x - 1, p.CurrentPostion.y + 1, Color.GreenYellow);
                            image.SetPixel(p.CurrentPostion.x, p.CurrentPostion.y + 1, Color.GreenYellow);
                            image.SetPixel(p.CurrentPostion.x, p.CurrentPostion.y - 1, Color.GreenYellow);
                            image.SetPixel(p.CurrentPostion.x + 1, p.CurrentPostion.y - 1, Color.GreenYellow);
                            image.SetPixel(p.CurrentPostion.x + 1, p.CurrentPostion.y, Color.GreenYellow);
                            image.SetPixel(p.CurrentPostion.x + 1, p.CurrentPostion.y + 1, Color.GreenYellow);
                        }
                        
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            Image i = (Image)image;
            g.DrawImage(i, new PointF(0,0));
            //panel1.BackgroundImage = image;
            //panel1.Invalidate();
        }

        private void localBestPSO()
        {

        }

        private void GlobalBestPSO()
        {

        }

        private bool maxIteration(int currentIteration)
        {
            if (currentIteration > maxIterations)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool EndCondition(int CurrentScore)
        {
            //set iterations
            if (CurrentScore == BestValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
