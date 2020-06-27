using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGeneticoTSP.AGClass
{
    public class Individual : ICloneable
    {
        private int[] chromosome;       // Cromossomo de inteiros - Cada gene representa uma cidade
        private double fitness;          // Valor de aptidão do indivído
        public int indexOfVector = 0;   // Posição dos indivíduos

        public Individual()
        {
            this.chromosome = new int[ConfigurationGA.sizeChromosome];
            List<int> genes = Utils.RandomNumbers(0, ConfigurationGA.sizeChromosome);

            for(int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                this.chromosome[i] = genes[i];
            }

            // Cálculo do fitness
            CalcFitness();
        }

        public int[] getChromossome()
        {
            return this.chromosome;
        }

        public void setGene(int position, int gene)
        {
            this.chromosome[position] = gene;
        }

        public int getGene(int position)
        {
            return this.chromosome[position];
        }

        public void setFitness(double fitness)
        {
            this.fitness = fitness;
        }

        public double getFitness()
        {
            return this.fitness;
        }

        public void Evaluate()
        {
            CalcFitness();
        }

        public void CalcFitness()
        {
            double totalDist = 0.0;

            for(int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                if(i < (ConfigurationGA.sizeChromosome - 1))
                {
                    totalDist += TablePoints.getDist(getGene(i), getGene(i + 1));
                }
                else
                {
                    totalDist += TablePoints.getDist(getGene(i), getGene(0));
                }
            }

            setFitness(totalDist);
        }

        public void mutate(int pointOne, int pointTwo)
        {
            if(pointOne < ConfigurationGA.sizeChromosome
                && pointTwo < ConfigurationGA.sizeChromosome
                && pointOne != pointTwo)
            {
                int temp = chromosome[pointOne];
                chromosome[pointOne] = chromosome[pointTwo];
                chromosome[pointTwo] = temp;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            base.ToString();

            string result = string.Empty;

            result += "Rota:    ";

            for(int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                result += (getGene(i) + 1).ToString() + " -> ";
            }

            result += "Distância: " + getFitness();

            return result;
        }
    }
}
