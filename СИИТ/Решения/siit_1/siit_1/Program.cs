using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace siit_1
{
    class Program
    {
        static void Main(string[] args)
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
                if (old_gens.bestFitness() == 1000) break;
                List<int[]> new_tmp = new List<int[]>();
                //old_gens.Sort();
                for (int i = 0; i < 100; i++)
                {
                    new_tmp.Add(old_gens.newChild());
                }
                old_gens.WriteTable(tableFile,tablenum);
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
            tablenum.Close();
            tableFile.Close();
            numGenFile.Close();
            avgFitFile.Close();
            maxFitFile.Close();
        }
    }
}
