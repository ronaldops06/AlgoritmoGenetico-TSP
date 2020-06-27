using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGeneticoTSP.AGClass
{
    public class Population
    {
        public Individual[] population;     // Grupo de indivíduos

        public Population()
        {
            this.population = new Individual[ConfigurationGA.sizePopulation];
            
            // Insere indivíduos na população
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                this.population[i] = new Individual();
                this.population[i].indexOfVector = i;
            }

            // Avaliar
            calculateFitness();
        }

        public Individual[] getPopulation()
        {
            return this.population;
        }

        public void setIndividuals(int position, Individual individual)
        {
            this.population[position] = individual;
        }

        /*
         * Calcula o fitness da população
         */
        public void calculateFitness()
        {
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].CalcFitness();
            }
        }

        /*
         * Efetua a avaliação da população
         */
        public void Evaluate()
        {
            refreshIndexOfIndividual();
            calculateFitness();
        }

        /*
         * 
         */
        public void refreshIndexOfIndividual()
        {
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].indexOfVector = i;
            }
        }

        /*
         * Retorna a média da população
         */
        public double getAveragePopulation()
        {
            double sum = 0;

            foreach(Individual ind in this.population)
            {
                sum += ind.getFitness();
            }

            return (sum/ConfigurationGA.sizePopulation);
        }

        /*
         * Ordena a população de indivíduos
         */
        public void OrderPopulation()
        {
            
            int inicio = 0;
            int fim = ConfigurationGA.sizePopulation - 1;
            
            // Utilizado o algoritmo Quick Sort por ser mais performarico que um loop comum
            quickSort(population, inicio, fim);
            
            /*
            Individual aux;

            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                for (int j = 0; j < ConfigurationGA.sizePopulation; j++)
                {
                    if (population[i].getFitness() < population[j].getFitness())
                    {
                        aux = population[i];
                        population[i] = population[j];
                        population[j] = aux;
                    }
                }
            }
            */
        }

        /*
         * Método para ordenação baseado no algoritmo Quick Sort.
         */
        private static void quickSort(Individual[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                Individual pivo = vetor[inicio];
                int i = inicio + 1;
                int f = fim;

                while (i <= f)
                {
                    if (vetor[i].getFitness() <= pivo.getFitness())
                    {
                        i++;
                    }
                    else if (pivo.getFitness() < vetor[f].getFitness())
                    {
                        f--;
                    }
                    else
                    {
                        Individual troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = pivo;

                quickSort(vetor, inicio, f - 1);
                quickSort(vetor, f + 1, fim);
            }
        }


        /*
         * Retorna o melhor indivíduo
         */
        public Individual getBest()
        {
            OrderPopulation();
            //twoOptSwap(population[0]);

            return population[0];
        }

        /*
         * Retorna o pior indivíduo
         */
        public Individual getBad()
        {
            OrderPopulation();
            return population[ConfigurationGA.sizePopulation - 1];
        }

        /*
         * Aplica o algoritmo de 2-opt para tentar melhor o resultado, evitando vértices cruzados
         */
        public void twoOptSwap(Individual bestInd)
        {
            double bestFitness = bestInd.getFitness();
            int geneAux;
            Individual newInd = (Individual) bestInd.Clone();
            Individual auxInd = (Individual) newInd.Clone();
            auxInd.CalcFitness();

            for (int i = 0; i < ConfigurationGA.sizeChromosome - 1; i++)
            {
                for(int j = i + 1; j < ConfigurationGA.sizeChromosome; j++)
                {
                    newInd.mutate(i, j);
                    newInd.CalcFitness();

                    if (newInd.getFitness() < auxInd.getFitness())
                    {
                        auxInd = (Individual)newInd.Clone();
                        auxInd.CalcFitness();
                        break;
                    }
                    else
                    {
                        newInd.mutate(i, j);
                        newInd.CalcFitness();
                    }
                }
            }
            population[0] = (Individual) newInd.Clone();
        }

        public override string ToString()
        {
            base.ToString();
            string result = string.Empty;

            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                result += population[i].ToString() + "\n";
            }

            return result;
        }
    }
}
