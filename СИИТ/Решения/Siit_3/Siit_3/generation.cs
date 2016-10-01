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
        List<int[]> gens;
        List<int> fitness { get; }
        List<float> probability { get; }
        List<int> chromSelect;
        List<int[]> location;
        public int sousage_x = 800;
        public int sousage_y = 800;
        public float averagefitness = 0f;
        Random mutat = new Random();
        int rando = 0;

        public generation()
        {
            gens = new List<int[]>();
            fitness = new List<int>();
            probability = new List<float>();
            chromSelect = new List<int>();
            location = new List<int[]>();
            
            
            for (int j = 0; j < 20; j++)
            {
                int[] gen = new int[1000];
                location.Add(new int[] { 500,500});
                gens.Add(gen);
                fitness.Add(0);
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
            gens = new_gens;
            for (int j = 0; j < 20; j++)
            {
                location.Add(new int[] { 500, 500 });
                fitness.Add(0);
                probability.Add(0f);
                chromSelect.Add(0);
            }
        }

        public void randomize()
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 1000; j++)
                {

                    gens[i][j] = rand.Next() % 4 + 1;
                }
            }
        }
        public void setFitness()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 1000; j++)              //1 - up || y++
                {                                           //2 - right || x++
                    if (gens[i][j] == 1) location[i][1]++;          //3 - down || y--
                    else if (gens[i][j] == 2) location[i][0]++;  //4 - left || x--
                    else if (gens[i][j] == 3) location[i][1]--;
                    else location[i][0]--;
                }
                fitness[i] = sousage_x - location[i][0] + sousage_y - location[i][1];                                        
            }
        }
        public void setProbability()
        {
            int mass = 0; ;
            for (int i = 0; i < 20; i++)
            {
                mass += fitness[i];
            }
            averagefitness = mass / 20;
            for (int i = 0; i < 20; i++)
            {
                probability[i] = (float)fitness[i] / (float)mass;
            }
        }
        public int[] newChild()
        {

            Random rand = new Random(DateTime.Now.TimeOfDay.Milliseconds + rando);
            rando++;
            if (rando == 10000000) rando = 0;
            int rand_num = rand.Next(10);
            float sum = 0f;
            int[] chrom_1 = new int[1000], chrom_2 = new int[1000];

            //for (int i = 0; i < 20; i++)
            //{
            //    sum += probability[i] * 1000000000;
            //    if (rand_num <= sum)
            //    {
            //        chromSelect[i]++;
            //        chrom_1 = gens[i];
            //        break;
            //    }

            //}
            chrom_1 = gens[rand_num];                     // for truncate
            sum = 0f;
            rand_num = rand.Next(10);
            //for (int i = 0; i < 20; i++)
            //{
            //    sum += probability[i] * 1000000000;
            //    if (rand_num <= sum)
            //    {
            //        chromSelect[i]++;
            //        chrom_2 = gens[i];
            //        break;
            //    }
            //}
            chrom_2 = gens[rand_num];                       // for truncate



            int[] new_chrom = new int[1000];

            //unified crossover
            for (int i = 0; i < 1000; i++)
            {
                if (rand.Next() % 2 == 1) new_chrom[i] = chrom_1[i];
                else new_chrom[i] = chrom_2[i];
            }

            //one point crossover
            //int point = rand.Next() % 1000;
            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i < point) new_chrom[i] = chrom_1[i];
            //    else new_chrom[i] = chrom_2[i];
            //}
            Mutation(new_chrom);
            return new_chrom;
        }
        public int bestFitness()
        {
            return fitness.Min();
        }

        public void Sort()
        {
            for (int i = 0; i < 20 - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < 20 - i - 1; j++)
                {
                    if (fitness[j] > fitness[j + 1])
                    {
                        int[] tmp_gen = gens[j];
                        gens[j] = gens[j + 1];
                        gens[j + 1] = tmp_gen;

                        int tmp_fit = fitness[j];
                        fitness[j] = fitness[j + 1];
                        fitness[j + 1] = tmp_fit;
                        swapped = true;
                    }

                }
                if (!swapped) break;
            }
        }
        public float getAverageFit()
        {
            return averagefitness;
        }
        public void WriteTable(StreamWriter file1, StreamWriter file2)
        {
            for (int i = 0; i < 20; i++)
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

        private void Mutation(int[] chromo)
        {
            for(int i = 0;i<1000;i++)
            {
                if(mutat.Next()%500 == 123)
                {
                    int tmp = mutat.Next() % 4 + 1;
                    if (tmp == chromo[i]) chromo[i] = (tmp + 1) % 4 +1;
                }
            }
        }
    }
}
