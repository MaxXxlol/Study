﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace siit_4
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
            old_gens.RandomizeStatic();
            old_gens.randomize();
            old_gens.setFitness();
            old_gens.setProbability();
            
            double maxFit = 0;
            int numGeneration = 0;
            for (int j = 0; (j < 1000) && (numGeneration < 200000); numGeneration++)
            {

                numGenFile.WriteLine(numGeneration.ToString());
                Console.WriteLine(old_gens.bestFitness() + " " + old_gens.getAverageFit());
                if (old_gens.bestFitness() == 0) break;
                List<int[]> new_tmp = new List<int[]>();
                old_gens.Sort();                                                    //for truncate
                for (int i = 0; i < generation.numChromo; i++)
                {
                    new_tmp.Add(old_gens.newChild());
                }
                old_gens.WriteTable(tableFile, tablenum);
                generation new_gens = new generation(new_tmp,old_gens.price,old_gens.valume);
                old_gens = new_gens;
                old_gens.setFitness();
                old_gens.setProbability();
                avgFitFile.WriteLine(old_gens.getAverageFit().ToString());
                maxFitFile.WriteLine(old_gens.bestFitness().ToString());
                //Console.ReadKey();
                //if (old_gens.bestFitness() > maxFit)
                //{
                //    maxFit = old_gens.bestFitness();
                //    j = 0;
                //}
                //else j++;

            }
            Console.ReadKey();
            tablenum.Close();
            tableFile.Close();
            numGenFile.Close();
            avgFitFile.Close();
            maxFitFile.Close();
        }
    }
}
