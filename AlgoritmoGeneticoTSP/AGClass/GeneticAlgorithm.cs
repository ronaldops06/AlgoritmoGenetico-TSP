using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGeneticoTSP.AGClass
{
    public class GeneticAlgorithm
    {
        private double rateCrossover;       // Taxa de cruzamento
        private double rateMutation;          // Taxa de Mutação

        public delegate Individual[] Crossover(Individual father1, Individual father2);
        public Crossover crossover;

        public delegate Individual Selection(Population pop);
        public Selection selection;

        public GeneticAlgorithm()
        {
            this.crossover = CrossoverPMX;
            this.selection = Tournament;

            this.rateCrossover = ConfigurationGA.rateCrossover;
            this.rateMutation = ConfigurationGA.rateMutation;

        }

        /*
         * Execução do algoritmo genético.
         * Sempre que passa por este método é efetuada uma evolução na população.
         */
        public Population executaGA(Population pop)
        {
            // # Criar a população: vem por parâmetro

            // # Avalia a população: Ao criar a população esta já vem avaliada

            Population newPopulation = new Population();
            List<Individual> popTemp = new List<Individual>();

            // Atribui indivíduos a população temporária
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                popTemp.Add(pop.getPopulation()[i]);
            }

            // # Elitismo
            Individual[] indElit = new Individual[ConfigurationGA.sizeElitism];

            if (ConfigurationGA.elitism)
            {
                // Ordenar a população
                pop.OrderPopulation();

                // Pega os melhores indivíduos da população e atribui no vetor de elit
                for(int i = 0; i < ConfigurationGA.sizeElitism; i++)
                {
                    indElit[i] = pop.getPopulation()[i];
                }
            }
            
            // # Seleção dos pais
            for (int i = 0; i < (ConfigurationGA.sizePopulation / 2); i++)
            {
                // Neste passo irá acontecer o torneio e os vencedores serão atribuidos às variáveis abaixo
                Individual father1 = selection(pop);
                Individual father2 = selection(pop);

                // # Cruzamento dos pais

                double sourtCrossNum = ConfigurationGA.random.NextDouble();
                if (sourtCrossNum < rateCrossover)
                {
                    Individual[] children = crossover(father1, father2);

                    // # Mutação
                    if(ConfigurationGA.mutationType == ConfigurationGA.Mutation.NewIndividual)
                    {
                        children[0] = Mutation(children[0]);
                        children[1] = Mutation(children[1]);
                    }
                    
                    // Rearranjar os filhos novetor(o Filho substitue a posição do pai)
                    children[0].indexOfVector = father1.indexOfVector;
                    children[1].indexOfVector = father2.indexOfVector;

                    popTemp[father1.indexOfVector] = children[0];
                    popTemp[father2.indexOfVector] = children[1];
                }
                else
                {
                    popTemp[father1.indexOfVector] = father1;
                    popTemp[father2.indexOfVector] = father2;
                }
            }
            
            // # Apagar os velhos e inserir os novos
            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                newPopulation.setIndividuals(i, popTemp[i]);
            }
            
            popTemp = null;

            // # Aplicação de mutação na nova população
            if(ConfigurationGA.mutationType == ConfigurationGA.Mutation.InPopulation)
            {
                newPopulation = MutationThePopulation(newPopulation);
            }
            
            // # Inserir nova população
            // # Inserir os indivíduos do elitismo na nova população
            if (ConfigurationGA.elitism)
            {
                // Avaliar a população
                newPopulation.Evaluate();

                // Ordenar a população
                newPopulation.OrderPopulation();

                int initPoint = ConfigurationGA.sizePopulation - ConfigurationGA.sizeElitism;
                int count = 0;
                for(int i = initPoint; i < ConfigurationGA.sizePopulation; i++)
                {
                    //newPopulation.setIndividuals(i, indElit[count]);
                    newPopulation.getPopulation()[i] = indElit[count];
                    count++;
                }
            }

            // # Avaliação
            newPopulation.Evaluate();
            
            return newPopulation;
        }

        /*
         * Efetua o cruzamento
         */
        public Individual[] CrossoverPMX(Individual father1, Individual father2)
        {
            Individual[] newInd = new Individual[2];

            int[] parent1 = new int[ConfigurationGA.sizeChromosome];
            int[] parent2 = new int[ConfigurationGA.sizeChromosome];

            int[] offSpring1Vector = new int[ConfigurationGA.sizeChromosome];
            int[] offSpring2Vector = new int[ConfigurationGA.sizeChromosome];

            int[] replacement1 = new int[ConfigurationGA.sizeChromosome];
            int[] replacement2 = new int[ConfigurationGA.sizeChromosome];

            // Seleção dos pontos para cruzamento
            int firstPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);
            int secondPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);

            /*if (firstPoint == secondPoint)
            {
                secondPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);
            }*/

            if (secondPoint < firstPoint)
            {
                int tmp = secondPoint;
                secondPoint = firstPoint;
                firstPoint = tmp;
            }
            else if(firstPoint == secondPoint)
            {
                secondPoint++;
            }

            newInd[0] = new Individual();
            newInd[1] = new Individual();

            // Transferir os genes para um parent
            for(int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                parent1[i] = offSpring1Vector[i] = father1.getGene(i);
                parent2[i] = offSpring2Vector[i] = father2.getGene(i);
            }

            // Popular o replacement em valores menores que 0
            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                replacement1[i] = replacement2[i] = -1;
            }

            for(int i = firstPoint; i <= secondPoint; i++)
            {
                offSpring1Vector[i] = parent2[i];
                offSpring2Vector[i] = parent1[i];

                replacement1[parent2[i]] = parent1[i];
                replacement2[parent1[i]] = parent2[i];
            }

            // Troca de genes repetidos
            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                if((i >= firstPoint) && (i <= secondPoint))
                {
                    continue;
                }

                int n1 = parent1[i];
                int m1 = replacement1[n1];

                int n2 = parent2[i];
                int m2 = replacement2[n2];

                while(m1 != -1)
                {
                    n1 = m1;
                    m1 = replacement1[m1];
                }

                while (m2 != -1)
                {
                    n2 = m2;
                    m2 = replacement2[m2];
                }

                offSpring1Vector[i] = n1;
                offSpring2Vector[i] = n2;
            }

            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                newInd[0].setGene(i, offSpring1Vector[i]);
                newInd[1].setGene(i, offSpring2Vector[i]);
            }

            newInd[0].CalcFitness();
            newInd[1].CalcFitness();

            return newInd;
        }

        /*
         * Efetua a mutação
         */
        public Individual Mutation(Individual ind)
        {
            // Verifica se vai mutar
            if(ConfigurationGA.random.NextDouble() <= rateMutation)
            {
                // Escolher os pontos de mutação
                int genePosition1 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome -1);
                int genePosition2 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome -1);

                if(genePosition1 == genePosition2)
                {
                    if(genePosition2 < ConfigurationGA.sizeChromosome - 2)
                    {
                        genePosition2++;
                    }
                }

                ind.mutate(genePosition1, genePosition2);
                return ind;
            }

            return ind;
        }

        /*
         * Realiza a mutação em todos os individuos da população
         */
        public Population MutationThePopulation(Population pop)
        {
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                // Verifica se vai mutar
                if (ConfigurationGA.random.NextDouble() <= rateMutation)
                {
                    // Escolher os pontos de mutação
                    int genePosition1 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);
                    int genePosition2 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);

                    if (genePosition1 == genePosition2)
                    {
                        if (genePosition2 < ConfigurationGA.sizeChromosome - 2)
                        {
                            genePosition2++;
                        }
                        else
                        {
                            genePosition2 -= 2;
                        }
                    }

                    pop.getPopulation()[i].mutate(genePosition1, genePosition2);
                }
            }

            return pop;
        }

        /*
         * Efetua a mutação nos genes de todos os indivíduos da população
         */
        public Population MutationGenesOfPopulation(Population pop)
        {
            return null;
        }

        /*
         * Realiza a seleção por torneio
         */
        public Individual Tournament(Population pop)
        {
            // Gera um vetor de competidores
            Individual[] competitors = new Individual[ConfigurationGA.numbOfCompetitors];
            Individual aux = new Individual();
         
            aux.setFitness(float.PositiveInfinity);
            
            // Seleção de competidores aleatóriamente dentro da população
            for (int i = 0; i < ConfigurationGA.numbOfCompetitors; i++)
            {
                competitors[i] = new Individual();
                competitors[i] = pop.getPopulation()[ConfigurationGA.random.Next(0, ConfigurationGA.sizePopulation - 1)];
            }
            
            // Determinar o vencedor
            for (int i = 0; i < ConfigurationGA.numbOfCompetitors; i++)
            {
                if(competitors[i].getFitness() < aux.getFitness())
                {
                    aux = competitors[i];
                    aux.CalcFitness();
                }
            }
            
            return aux;
        }
    }
}
