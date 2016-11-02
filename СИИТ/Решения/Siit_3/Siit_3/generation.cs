using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Siit_3
{
    class generation
    {
        static public int numChromo = 20;
        static public int numGens = 1000;
        List<int[]> gens;
        List<int> fitness { get; }
        List<double> sharedFitness;
        List<float> probability { get; }
        List<int> chromSelect;
        List<int[]> location;
        List<int> arround;
        public int sousage_x1 = 800, sousage_x2 = 800, sousage_x3 = 200, sousage_x4 = 200;
        public int sousage_y1 = 800, sousage_y2 = 200, sousage_y3 = 800, sousage_y4 = 200;
        public double averagefitness = 0f;
        StreamWriter fitOut = new StreamWriter("fitOut.txt");
        StreamWriter sharefitOut = new StreamWriter("sharefitOut.txt");
        StreamWriter arrOut = new StreamWriter("arrOut.txt");

        Random mutat = new Random();
        int rando = 0;

        public generation()
        {
            gens = new List<int[]>();
            fitness = new List<int>();
            probability = new List<float>();
            chromSelect = new List<int>();
            location = new List<int[]>();
            sharedFitness = new List<double>();
            arround = new List<int>();
            
            for (int j = 0; j < numChromo; j++)
            {
                int[] gen = new int[numGens];
                location.Add(new int[] { 500,500});
                gens.Add(gen);
                fitness.Add(0);
                arround.Add(0);
                sharedFitness.Add(0);
                probability.Add(0f);
                chromSelect.Add(0);
            }
        }

        public generation(List<int[]> new_gens)
        {
            gens = new List<int[]>();
            fitness = new List<int>();
            probability = new List<float>();
            chromSelect = new List<int>();
            location = new List<int[]>();
            sharedFitness = new List<double>();
            arround = new List<int>();
            gens = new_gens;
            for (int j = 0; j < numChromo; j++)
            {
                location.Add(new int[] { 500, 500 });
                fitness.Add(0);
                sharedFitness.Add(0);
                arround.Add(0);
                probability.Add(0f);
                chromSelect.Add(0);
            }
        }

        public void randomize()
        {
            Random rand = new Random();
            for (int i = 0; i < numChromo; i++)
            {
                for (int j = 0; j < numGens; j++)
                {

                    gens[i][j] = rand.Next() % 4 + 1;
                }
            }
        }
        public void setFitness()
        {
            for (int i = 0; i < numChromo; i++)
            {
                for (int j = 0; j < numGens; j++)              //1 - up || y++
                {                                           //2 - right || x++
                    if (gens[i][j] == 1)
                    {

                        location[i][1]++;
                        if (location[i][1] == 1000)
                            location[i][1] = 0;
                    }                                    //3 - down || y--
                    else if (gens[i][j] == 2)
                    {

                        location[i][0]++;
                        if (location[i][0] == 1000)
                            location[i][0] = 0;
                    }  //4 - left || x--
                    else if (gens[i][j] == 3)
                    {
                        location[i][1]--;
                        if (location[i][1] == 0)
                            location[i][1] = 1000;
                    }
                    else {
                        location[i][0]--;
                        if (location[i][0] == 0)
                            location[i][0] = 1000;
                            }
                }
                List<int> fit = new List<int>();
                fit.Add( Math.Abs(sousage_x1 - location[i][0]) + Math.Abs(sousage_y1 - location[i][1]));
                fit.Add(Math.Abs(sousage_x2 - location[i][0]) + Math.Abs(sousage_y2 - location[i][1]));
                fit.Add(Math.Abs(sousage_x3 - location[i][0]) + Math.Abs(sousage_y3 - location[i][1]));
                fit.Add(Math.Abs(sousage_x4 - location[i][0]) + Math.Abs(sousage_y4 - location[i][1]));
                fitness[i] = fit.Min();
                fitOut.WriteLine(fitness[i]);
            }
            for(int i = 0; i < numChromo; i++)
            {
                double sum = 0;
                for(int j = 0; j < numChromo; j++)
                {
                    int tmp = Math.Abs(location[i][0] - location[j][0]) + Math.Abs(location[i][1] - location[j][1]);
                    if (tmp < 50)
                    {
                        arround[i]++;
                        sum += (1 - (double)tmp / 50);
                    }
                }
                sharedFitness[i] = (fitness[i])*sum;
                sharefitOut.WriteLine(sharedFitness[i]);
                arrOut.WriteLine(arround[i]);
            }
            fitOut.Close();
            sharefitOut.Close();
            arrOut.Close();
        }
        
        public void setProbability()
        {
            double mass = 0; 
            for (int i = 0; i < numChromo; i++)
            {
                mass += sharedFitness[i];
            }
            averagefitness = mass / numChromo;
            for (int i = 0; i < numChromo; i++)
            {
                probability[i] = (float)fitness[i] / (float)mass;
            }
        }
        public int[] newChild()
        {

            Random rand = new Random(DateTime.Now.TimeOfDay.Milliseconds + rando);
            rando++;
            if (rando == 10000000) rando = 0;
            int rand_num = rand.Next(numChromo/2);
            float sum = 0f;
            int[] chrom_1 = new int[numGens], chrom_2 = new int[numGens];

            //for (int i = 0; i < 100; i++)
            //{
            //    sum += probability[i] * numGens000000;
            //    if (rand_num <= sum)
            //    {
            //        chromSelect[i]++;
            //        chrom_1 = gens[i];
            //        break;
            //    }

            //}
            chrom_1 = gens[rand_num];                     // for truncate
            sum = 0f;
            rand_num = rand.Next(numChromo/2);
            //for (int i = 0; i < 100; i++)
            //{
            //    sum += probability[i] * numGens000000;
            //    if (rand_num <= sum)
            //    {
            //        chromSelect[i]++;
            //        chrom_2 = gens[i];
            //        break;
            //    }
            //}
            chrom_2 = gens[rand_num];                       // for truncate



            int[] new_chrom = new int[numGens];

            //uniform crossover
            for (int i = 0; i < numGens; i++)
            {
                if (rand.Next() % 2 == 1) new_chrom[i] = chrom_1[i];
                else new_chrom[i] = chrom_2[i];
            }

            //one point crossover
            //int point = rand.Next() % numGens;
            //for (int i = 0; i < numGens; i++)
            //{
            //    if (i < point) new_chrom[i] = chrom_1[i];
            //    else new_chrom[i] = chrom_2[i];
            //}
            Mutation(new_chrom);
            return new_chrom;
        }
        public double bestFitness()
        {
            return sharedFitness.Min();
        }

        public void Sort()
        {
            for (int i = 0; i < numChromo - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < numChromo - i - 1; j++)
                {
                    if (sharedFitness[j] > sharedFitness[j + 1])
                    {
                        int[] tmp_gen = gens[j];
                        gens[j] = gens[j + 1];
                        gens[j + 1] = tmp_gen;

                        int tmp_fit = fitness[j];
                        fitness[j] = fitness[j + 1];
                        fitness[j + 1] = tmp_fit;

                        double tmp_shr_fit = sharedFitness[j];
                        sharedFitness[j] = sharedFitness[j + 1];
                        sharedFitness[j + 1] = tmp_fit;
                        swapped = true;
                    }

                }
                if (!swapped) break;
            }
        }
        public double getAverageFit()
        {
            return averagefitness;
        }
        public void WriteTable(StreamWriter file1, StreamWriter file2)
        {
            for (int i = 0; i < numChromo; i++)
            {
                file1.WriteLine(chromSelect[i].ToString());
                file2.WriteLine(i.ToString());
            }
            file1.WriteLine();
            file1.WriteLine();
        }
        public int[] GetMaxChromo()
        {
            return gens[0];
        }
        public int[] GetChromo(int index)
        {
            return gens[index];
        }

        private void Mutation(int[] chromo)
        {
            for(int i = 0;i<numGens;i++)
            {
                if(mutat.Next()%50 == 1)
                {
                    int tmp = mutat.Next() % 4 + 1;
                    if (tmp == chromo[i]) chromo[i] = (tmp + 1) % 4 + 1;
                }
            }
        }
        public int getBestArround()
        {
            return arround.Min();
        }

    }
}
