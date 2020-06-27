using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritmoGeneticoTSP.AGClass;
using ZedGraph;


namespace AlgoritmoGeneticoTSP
{
    public partial class Form1 : Form
    {
        Graphics g;
        int count = 0;
        int pointCount = 0;
        
        // ZedGraph
        private GraphPane paneMedia;
        private PointPairList mediaPopulacao = new PointPairList();

        Population pop;
        int evolucoes = 0;
        int i = 0;      // Iterações
        int iTemp = 0;
        double bestAux = double.PositiveInfinity;
        double maiorDistancia = 0;

        public Form1()
        {
            InitializeComponent();

            paneMedia = zedMedia.GraphPane;
            paneMedia.Title.Text = "Média da população";
            paneMedia.XAxis.Title.Text = "Evolução";
            paneMedia.YAxis.Title.Text = "Média Fitness";
            zedMedia.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            
            // Criar um lápis
            Pen blackPen = new Pen(Color.Red, 3);
            int x = e.X;
            int y = e.Y;

            TablePoints.addPoint(x, y);

            Rectangle rect = new Rectangle(x - 5, y - 5, 10, 10);
            g.DrawEllipse(blackPen, rect);
            g.DrawString((pointCount + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, x + 3, y);
            g.DrawString("X: " + x.ToString(), new Font("Arial Black", 6), Brushes.Black, x - 20, y - 25);
            g.DrawString("Y: " + y.ToString(), new Font("Arial Black", 6), Brushes.Black, x - 20, y - 18);

            pointCount++;
            lbQtdeCidades.Text = pointCount.ToString();
            lbComplex.Text = Fatorial((ulong)pointCount).ToString();

            if (++count >= 4)
            {
                btnCriarPop.Enabled = true;
            }

            if (++count >= 1)
            {
                btnLimpar.Enabled = true;
            }
            else
            {
                btnLimpar.Enabled = false;
            }

            Console.WriteLine(TablePoints.print());
        }

        public ulong Fatorial(ulong number)
        {
            if (number <= 1)
            {
                return 1;
            } else
            {
                return number * Fatorial(number - 1);
            }
        }

        private void btnCriarPop_Click(object sender, EventArgs e)
        {
            ConfigurationGA.sizePopulation = int.Parse(txtTamPop.Text);
            pop = new Population();
            btnExecutar.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ConfigurationGA.sizePopulation = 0;
            TablePoints.clear();
            pop = null;

            lbQtdeCidades.Text = "--";

            btnCriarPop.Enabled = false;
            btnExecutar.Enabled = false;
            btnLimpar.Enabled = false;

            g.Clear(Color.White);
            count = 0;
            pointCount = 0;
            lbQtdeCidades.Text = pointCount.ToString();
            lbMenorDistancia.Text = "00";
            lbMenorDistancia.Refresh();
            lbMaiorDistancia.Text = "00";
            lbMaiorDistancia.Refresh();

            i = 0;
            iTemp = 0;
            evolucoes = 0;
            lbEvolucoes.Text = "00";

            mediaPopulacao.Clear();
            zedMedia.Refresh();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            btnCriarPop.Enabled = false;

            float taxaMutacao = float.Parse(txtTaxaMutacao.Text);
            float taxaCrossover = float.Parse(txtTaxaCrossover.Text);
            int torneio = int.Parse(txtQtdeTorneio.Text);
            evolucoes += int.Parse(txtEvolucao.Text);

            bestAux = double.PositiveInfinity;

            // Configurar AG
            ConfigurationGA.rateCrossover = taxaCrossover;
            ConfigurationGA.rateMutation = taxaMutacao;
            ConfigurationGA.numbOfCompetitors = torneio;
            ConfigurationGA.Mutation mutacao = ConfigurationGA.Mutation.NewIndividual;

            if (rbNovoIndividuo.Checked)
            {
                mutacao = ConfigurationGA.Mutation.NewIndividual;
            }
            else if (rbPopGeral.Checked)
            {
                mutacao = ConfigurationGA.Mutation.InPopulation;
            }
            else if (rbGenesPop.Checked)
            {
                mutacao = ConfigurationGA.Mutation.InGenesPopulation;
            }

            ConfigurationGA.mutationType = mutacao;

            if (chElitismo.Checked)
            {
                ConfigurationGA.elitism = true;
                ConfigurationGA.sizeElitism = int.Parse(txtQtdeElitismo.Text);
            }
            else
            {
                ConfigurationGA.elitism = false;
                //ConfigurationGA.sizeElitism = 0;
            }

            Console.Write("-----------------------------------------------------------------------------\n");
            Console.Write("TIPO CROSSOVER: " +"PMX"+"\n");
            Console.Write("TIPO MUTAÇÃO: " + ConfigurationGA.mutationType + "\n");
            Console.Write("TIPO SELEÇÃO: " +"Torneio"+ "\n");
            Console.Write("ELITISMO: " + ConfigurationGA.elitism + " - QTDE: "+ ConfigurationGA.sizeElitism + "\n");
            Console.Write("TAXA MUTAÇÃO: " +ConfigurationGA.rateMutation + "\n");
            Console.Write("TAXA CROSSOVER: " + ConfigurationGA.rateCrossover+ "\n");
            Console.Write("EVOLUÇÕES: " + evolucoes.ToString() + "\n");
            Console.Write("-----------------------------------------------------------------------------\n");

            GeneticAlgorithm ag = new GeneticAlgorithm();

            for (int i = iTemp; i < evolucoes; i++)
            {
                iTemp++;
                lbEvolucoes.Text = i.ToString();
                lbEvolucoes.Refresh();
                
                // Execução do algoritmo genético
                pop = ag.executaGA(pop);

                // Limpar o gráfico
                zedMedia.GraphPane.CurveList.Clear();
                zedMedia.GraphPane.GraphObjList.Clear();

                double mediaPop = pop.getAveragePopulation();
                
                mediaPopulacao.Add(i, mediaPop);

                // Busca o Fitness do melhor indivíduo
                double bestFitness = pop.getBest().getFitness();
                lbMenorDistancia.Text = Math.Round(bestFitness, 0).ToString();
                lbMenorDistancia.Refresh();
                testaMaiorDistancia(bestFitness);
                lbMaiorDistancia.Text = Math.Round(maiorDistancia, 2).ToString();
                lbMaiorDistancia.Refresh();

                // Adiciona a média da população no gráfico
                LineItem media = paneMedia.AddCurve("Média", mediaPopulacao, Color.Red, SymbolType.None);

                // Print linhas a cada 6 evoluções
                if(i%6 == 0 && bestFitness < bestAux)
                {
                    bestAux = bestFitness;
                    g.Clear(Color.White);
                    plotLines(pop, Color.Blue);
                    plotPoints();
                }

                zedMedia.AxisChange();
                zedMedia.Invalidate();
                zedMedia.Refresh();
            }

            g.Clear(Color.White);
            // Chama o método para melhorar a população
            pop.twoOptSwap(pop.getBest());
            plotLines(pop, Color.Blue);
            plotPoints();
        }

        private void plotPoints()
        {
            if (TablePoints.pointCount > 0)
            {
                for (int i = 0; i < TablePoints.pointCount; i++)
                {
                    Pen blackPan = new Pen(Color.Red, 3);
                    // Vetor de coordenadas
                    int[] coo = TablePoints.getCoordinates(i);
                    Rectangle rect = new Rectangle(coo[0] - 5, coo[1] - 5, 10, 10);
                    g.DrawEllipse(blackPan, rect);
                    g.DrawString((i + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, coo[0] + 3, coo[1]);
                    g.DrawString("X: " + coo[0].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 25);
                    g.DrawString("Y: " + coo[1].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 18);

                }
            }
        }

        private void plotLines(Population pop, Color color)
        {
            Pen penBest = new Pen(color, 4);
            int genA, genB;

            Individual best = pop.getBest();

            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                if (i < ConfigurationGA.sizeChromosome - 1)
                {
                    genA = best.getGene(i);
                    genB = best.getGene(i + 1);
                }
                else
                {
                    genA = best.getGene(i);
                    genB = best.getGene(0);
                }

                int[] vetA = TablePoints.getCoordinates(genA);
                int[] vetB = TablePoints.getCoordinates(genB);

                g.DrawLine(penBest, vetA[0], vetA[1], vetB[0], vetB[1]);
            }
        }

        private void testaMaiorDistancia(Double distancia)
        {
            if (distancia > maiorDistancia)
            {
                maiorDistancia = distancia;
            }
        }

    }
}
