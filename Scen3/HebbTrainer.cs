using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen3
{
    class HebbTrainer
    {
        private HebbNeuron[] layer;
        private double learningRate;
        private int Max = 10000;
        private double decay;
        private bool teacherFlag;
        int counter;

        public HebbTrainer(int numberOfNeurons, double learningRate, double decay, bool shouldLearningBeSupervised)
        {
            this.learningRate = learningRate;
            this.decay = decay;
            this.teacherFlag = shouldLearningBeSupervised;
            layer = new HebbNeuron[numberOfNeurons];

            Random r = new Random();
            double[] weights = new double[DataProvider.NumberOfFields];

            for (int i = 0; i < numberOfNeurons; i++)
            {
                for (int j = 0; j < weights.Length; j++)
                {
                    weights[j] = r.NextDouble();
                }
                layer[i] = new HebbNeuron(weights);
            }
        }

        public bool Train()
        {
            this.counter = 0;
            double[] winners = new double [layer.Length];
            if(this.teacherFlag)
            {
                SupervisedLearning();
            }
            else
            {
                UnsupervisedLearning();
            }
            if (counter == Max)
            {
                Console.WriteLine("Nie udało się nauczyć");
                return false;
            }
            Console.WriteLine("Epoki: " + this.counter);
            Console.ReadLine();
            return true;
        }

        public int Act(double[] input)
        {
            int winner = 0;
            double result;
            double winnerResult = layer[0].GetResult(input);
            for (int i = 1; i < layer.Length; i++)
            {
                result = layer[i].GetResult(input);
                if (winnerResult < result)
                {
                    winner = i;
                    winnerResult = result;
                }
            }
            return winner;
        }

        private void SupervisedLearning()
        {
            this.counter = 0;
            double[] input;
            double expected;
            double[] winners = new double[layer.Length];
            do
            {
                for (int i = 0; i < DataProvider.DataExpected.Length; i++)
                {
                    input = DataProvider.GetData(i, DataProvider.Data);
                    for (int j = 0; j < layer.Length; j++)
                    {
                        if (i == j)
                        {
                            expected = 1;
                        }
                        else
                        {
                            expected = 0;
                        }
                        layer[j].Learn(input, expected, this.learningRate, this.decay);
                    }
                    for (int j = 0; j < layer.Length; j++)
                    {
                        input = DataProvider.GetData(j, DataProvider.Data);
                        winners[j] = Act(input);
                    }
                }
                this.counter++;
            } while (this.counter < Max && winners.Distinct().Count() != winners.Length);
        }
        private void UnsupervisedLearning()
        {
            this.counter = 0;
            double[] input;
            double result;
            double[] winners = new double[layer.Length];
            do
            {
                for (int i = 0; i < DataProvider.DataExpected.Length; i++)
                {
                    input = DataProvider.GetData(i, DataProvider.Data);
                    for (int j = 0; j < layer.Length; j++)
                    {
                        result = layer[j].GetResult(input);
                        layer[j].Learn(input, result, this.learningRate, this.decay);
                    }
                    for (int j = 0; j < layer.Length; j++)
                    {
                        input = DataProvider.GetData(j, DataProvider.Data);
                        winners[j] = Act(input);
                    }
                }
                this.counter++;
            } while (this.counter < Max && winners.Distinct().Count() != winners.Length);
            for (int j = 0; j < layer.Length; j++)
            {
                input = DataProvider.GetData(j, DataProvider.Data);
                winners[j] = Act(input);
            }
        }
        
        public void Test(double[,,] dataSet, int lenght)
        {
            double[] input;
            int[] winners = new int[layer.Length];
            int errors = 0;
            String expected, got;
            for (int j = 0; j < layer.Length; j++)
            {
                input = DataProvider.GetData(j, DataProvider.Data);
                winners[j] = Act(input);
            }
            for (int i = 0; i < lenght; i++)
            {
                input = DataProvider.GetData(i, dataSet);
                expected = DataProvider.Emotikony[winners[i % DataProvider.Emotikony.Length]];
                got = DataProvider.Emotikony[Act(input)];
                Console.WriteLine("Emotikona nr " + (i+1) + ". Exp: " + expected
                    + " Got: " + got);
                if(DataProvider.Emotikony[Act(input)] != DataProvider.Emotikony[winners[i % DataProvider.Emotikony.Length]])
                {
                    errors++;
                }
            }
            Console.WriteLine("Errors: " + errors);
        }
        /*

                private int GetLetterSizeFromLayer(double[] input)
                {
                    for (int i = 0; i < results.Length; i++)
                    {
                        results[i] = layer[i].GetResult(input);
                    }

                    if (results[0] >= results[1])
                    {
                        return 0;
                    }

                    return 1;
                }

                private int GetExpected(int expected, int nr)
                {
                    if (nr == 0)
                    {
                        return expected;
                    }
                    else if (expected > 0)
                    {
                        return 0;
                    }

                    return 1;
                }
        */
    }
}
