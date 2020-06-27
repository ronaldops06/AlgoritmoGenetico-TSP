using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AlgoritmoGeneticoTSP.AGClass
{
    public static class TablePoints
    {
        private static ArrayList X = new ArrayList(); // Array de valores de X
        private static ArrayList Y = new ArrayList(); // Array de valores de y
        private static double[,] tableDist;           // Table com distnâncias entre pontos
        public static int pointCount = 0;              // Quantidade de pontos na tabela

        /*
         * Adiciona um novo ponto a tabela
         */
        public static void addPoint(int x, int y)
        {
            X.Add(x);
            Y.Add(y);
            pointCount++;
            generateTable();
        }

        /*
         * Gerar a tabela com os valores de distância entre dois pontos
         */
        public static void generateTable()
        {
            tableDist = new double[pointCount, pointCount];

            for(int i = 0; i < pointCount; i++) //Para X
            {
                for(int j = 0; j < pointCount; j++) //Para Y
                {
                    // Cálculo de distância entre dois pontos
                    tableDist[i, j] = Math.Sqrt(    Math.Pow(   int.Parse(X[i].ToString()) 
                                                              - int.Parse(X[j].ToString()), 2)
                                                  + Math.Pow(   int.Parse(Y[i].ToString())
                                                              - int.Parse(Y[j].ToString()), 2));
                }
            }

            // Atualiza o tamanho do cromossomo
            ConfigurationGA.sizeChromosome = pointCount;
        }

        /*
         * Retornar a tabela de distâncias
         */
        public static double[,] getTableDit()
        {
            return tableDist;
        }

        /*
         * Retornar a distância entre dois pontos
         */
        public static double getDist(int pointOne, int pointTwo)
        {
            return tableDist[pointOne, pointTwo];
        }

        /*
         * Retorna a quantida de pontos dentro da classe
         */
        public static int Count()
        {
            return pointCount;
        }

        /*
         * Irá retornar os valores da tabela
         */
        public static string print()
        {
            string data = string.Empty;
            
            for(int i = 0; i < pointCount; i++)
            {
                for (int j = 0; j < pointCount; j++)
                {
                    data += string.Format("{0:0.#}", double.Parse(tableDist[i, j].ToString())) + "    ";
                }

                data += Environment.NewLine;
            }

            data += Environment.NewLine + "---------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

            return data;
        }

        /*
         * Retorna a coordenada de um ponto, [x,y]
         */
        public static int[] getCoordinates(int point)
        {
            int[] arrayCoordinates = new int[2];
            arrayCoordinates[0] = int.Parse(X[point].ToString());
            arrayCoordinates[1] = int.Parse(Y[point].ToString());

            return arrayCoordinates;
        }

        /*
         * Limpar dados da tabela
         */
        public static void clear()
        {
            X.Clear();
            Y.Clear();
            pointCount = 0;
            tableDist = null;
        }
    }
}
