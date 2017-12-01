using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen4ver1
{
    class Map
    {
        private Neuron[] neuronMap;
        private double lr;
        public Map(double learningRate)
        {
            lr = learningRate;
            neuronMap = new Neuron[DataProvider.eSize];
            Random r = new Random();
            double[] weights = new double[DataProvider.iSize + 1];
            for (int j = 0; j < neuronMap.Length; j++)
            {
                for (int i = 0; i < weights.Length; i++)
                {
                    weights[i] = r.NextDouble();
                }

                neuronMap[j] = new Neuron(weights);
            }
        }

        public void PrintMap()
        {
            for (int i = 0; i < neuronMap.Length; i++)
            {
                Console.WriteLine("Neuron : " + i);
                neuronMap[i].PrintWeights();
            }
        }

        public void Learn()
        {
            
            double lenght;
            double min;
            int neuronNumber = 0;
            do
            {
                for (int i = 0; i < DataProvider.input.GetLength(0); i++)
                {
                    min = 0.0;
                    for (int j = 0; j < neuronMap.Length; j++)
                    {
                        double[] input = DataProvider.GetInput(i,DataProvider.input);
                        lenght = neuronMap[j].CalculateEuclideanDistance(input);
                        if (lenght < min || j == 0)
                        {
                            min = lenght;
                            neuronNumber = j;
                        }
                        neuronMap[neuronNumber].CalculateNewWeights(input, lr);
                    }

                }
                CalculateLearningRate();
            } while (lr > 0.000000001);
        }

        public void Test()
        {
            double lenght;
            double min;
            int neuronNumber = 0;
            double expected;
            double rate = DataProvider.testInput.GetLength(0);
            for (int i = 0; i < DataProvider.testInput.GetLength(0); i++)
            {
                min = 0.0;
                for (int j = 0; j < neuronMap.Length; j++)
                {
                    double[] input = DataProvider.GetInput(i, DataProvider.testInput);
                    lenght = neuronMap[j].CalculateEuclideanDistance(input);
                    if (lenght < min || j == 0)
                    {
                        min = lenght;
                        neuronNumber = j;
                    }
                }
                expected = DataProvider.GetExpected(i, DataProvider.testExpected);
                Console.Write("exp: " + expected + " got: " + neuronNumber);
                if (expected != neuronNumber)
                {
                    Console.WriteLine(" WRONG");
                    rate--;
                }
                else
                    Console.WriteLine("GUT");
            }
            Console.WriteLine((rate / DataProvider.testInput.GetLength(0)));
        }

        private void CalculateLearningRate()
        {
            lr /= 2;
        }
    }
}
