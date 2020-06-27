using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGeneticoTSP.AGClass
{
    public static class ConfigurationGA
    {
        public static int sizeChromosome = 0;   // Tamanho do cromossomo
        public static int sizePopulation = 100; // Tamanho da população
        public static Random random = new Random((int)DateTime.Now.Ticks);
        public static bool elitism = false;     // Define se irá usar elitismo
        public static int sizeElitism = 3;      // Quantidade de ind. para elitismo
        public static double rateCrossover = 0.8;   // Taxa de crossover (Cruzamento)
        public static double rateMutation = 0.01;   // Taxa de mutação
        public static int numbOfCompetitors = 3;    // Número de competidores para torneio
        public static Mutation mutationType = Mutation.NewIndividual;

        public enum Mutation
        {
            NewIndividual,
            InPopulation,
            InGenesPopulation
        }

    }
}
