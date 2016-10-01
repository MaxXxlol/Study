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
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Blue;
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
            int maxFit = 0;
            int numGeneration = 0;
            for (int j = 0; j < 1000; numGeneration++)
            {
                numGenFile.WriteLine(numGeneration.ToString());
                Console.WriteLine(old_gens.bestFitness() + " " + old_gens.getAverageFit());
                if (old_gens.bestFitness() == 0) break;
                List<int[]> new_tmp = new List<int[]>();
                old_gens.Sort();                                                    //for truncate
                for (int i = 0; i < 20; i++)
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
            PaintWay(old_gens.GetMaxChromo());
            tablenum.Close();
            tableFile.Close();
            numGenFile.Close();
            avgFitFile.Close();
            maxFitFile.Close();
        }
        private void PaintWay(int[] chromo)
        {
            double location_x = 250, location_y = 250;
            Bitmap bit = new Bitmap(500, 500);
           bit.SetPixel(400, 400, Color.Red);
            foreach (int i in chromo)
            {
                
                
                
                if (i == 1)
                {
                    location_y += 0.5;
                    if (location_y == 1000) location_y = 1;
                    bit.SetPixel((int)location_x,(int) location_y, Color.Green);
                }
                else if (i == 2)
                {
                    location_x += 0.5;
                    if (location_x == 1000) location_x = 1;
                    bit.SetPixel((int)location_x, (int)location_y, Color.Green);
                }
                else if (i == 3)
                {
                    location_y -= 0.5;
                    if (location_y == 0) location_y = 499;
                    bit.SetPixel((int)location_x, (int)location_y, Color.Green);
                }

                else
                {
                    location_x -= 0.5;
                    if (location_x == 0) location_x = 499;
                    bit.SetPixel((int)location_x, (int)location_y, Color.Green);
                }
               
            }
            pictureBox1.Image = bit;
        }
    }
}
