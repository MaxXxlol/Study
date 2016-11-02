using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Siit_3
{
    public partial class Form1 : Form
    {
        Bitmap bit = new Bitmap(1000, 1000);
        public Form1()
        {
            InitializeComponent();
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter avgFitFile = new StreamWriter("averageFit.txt");
            StreamWriter maxFitFile = new StreamWriter("maxFit.txt");
            StreamWriter numGenFile = new StreamWriter("numGen.txt");
            StreamWriter tableFile = new StreamWriter("Table.txt");
            StreamWriter tablenum = new StreamWriter("Num.txt");
            generation old_gens = new generation();
            old_gens.randomize();
            old_gens.setFitness();
            old_gens.setProbability();
            double maxFit = 0;
            int numGeneration = 0;
            for (int j = 0; (j < 1000) && (numGeneration<250); numGeneration++)
            {
                bit = new Bitmap(1000, 1000);
                for (int i = 0; i < generation.numChromo; i++)
                {
                    PaintWay(old_gens.GetChromo(i));
                }
                this.Refresh();
                if(numGeneration==0 || numGeneration==50 || numGeneration==125 || numGeneration==200 || numGeneration ==249)
                MessageBox.Show("gav gav!");
                numGenFile.WriteLine(numGeneration.ToString());
                Console.WriteLine(old_gens.bestFitness() + " " + old_gens.getAverageFit() + " " + old_gens.getBestArround());
                //if (old_gens.bestFitness() == 0) break;
                List<int[]> new_tmp = new List<int[]>();
                old_gens.Sort();                                                    //for truncate
                for (int i = 0; i < generation.numChromo; i++)
                {
                    new_tmp.Add(old_gens.newChild());
                }
                old_gens.WriteTable(tableFile, tablenum);
                generation new_gens = new generation(new_tmp);
                old_gens = new_gens;
                old_gens.setFitness();
                old_gens.setProbability();
                avgFitFile.WriteLine(old_gens.getAverageFit().ToString());
                maxFitFile.WriteLine(old_gens.bestFitness().ToString());
                if (old_gens.bestFitness() > maxFit)
                {
                    maxFit = old_gens.bestFitness();
                    j = 0;
                }
                else j++;

            }
            for (int i = 0; i < generation.numChromo; i++)
            {
                PaintWay(old_gens.GetChromo(i));
            }
            tablenum.Close();
            tableFile.Close();
            numGenFile.Close();
            avgFitFile.Close();
            maxFitFile.Close();
        }
        private void PaintWay(int[] chromo)
        {
            double location_x = 500, location_y = 500;
            
           bit.SetPixel(200, 200, Color.Red);
            bit.SetPixel(200, 800, Color.Red);
            bit.SetPixel(800, 200, Color.Red);
            bit.SetPixel(800, 800, Color.Red);
            Graphics graph = Graphics.FromImage(bit);
            Pen my_pen = new Pen(Color.Green);
            my_pen.Width = 10;
            graph.DrawEllipse(my_pen, 800 - 2, 800 - 2, 4, 4);
            graph.DrawEllipse(my_pen, 800 - 2, 200 - 2, 4, 4);
            graph.DrawEllipse(my_pen, 200 - 2, 800 - 2, 4, 4);
            graph.DrawEllipse(my_pen, 200 - 2, 200 - 2, 4, 4);
            foreach (int i in chromo)
            {
                if (i == 1)
                {
                    location_y += 1;
                    if (location_y == 1000) location_y = 1;
                    bit.SetPixel((int)location_x,(int) location_y, Color.Red);
                }
                else if (i == 2)
                {
                    location_x += 1;
                    if (location_x == 1000) location_x = 1;
                    bit.SetPixel((int)location_x, (int)location_y, Color.Red);
                }
                else if (i == 3)
                {
                    location_y -= 1;
                    if (location_y == 0) location_y = 999;
                    bit.SetPixel((int)location_x, (int)location_y, Color.Red);
                }

                else
                {
                    location_x -= 1;
                    if (location_x == 0) location_x = 999;
                    bit.SetPixel((int)location_x, (int)location_y, Color.Red);
                }
               
            }
            pictureBox1.Image = bit;
        }
    }
}
