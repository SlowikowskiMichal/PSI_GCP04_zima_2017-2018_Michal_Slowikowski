using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen4ver2
{
    class Map
    {
        private Neuron[] neuronMap;
        private int numberOfNeurons;
        private double lr;
        private double Max;
        public Map(double learningRate, int numberOfNeurons, int iter)
        {
            this.Max = iter;
            this.numberOfNeurons = numberOfNeurons;
            lr = learningRate;
            neuronMap = new Neuron[this.numberOfNeurons];
            Random r = new Random();
            double[] weights = new double[DataProvider.input.GetLength(1) + 1];
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
            int counter = 0;
            int neuronNumber = 0;
            do
            {
                DataProvider.ShuffleInputData();
                for (int i = 0; i < DataProvider.input.GetLength(0); i++)
                {
                    min = 0.0;
                    for (int j = 0; j < neuronMap.Length; j++)
                    {
                        double[] input = DataProvider.GetInput(i, DataProvider.input);
                        lenght = neuronMap[j].CalculateEuclideanDistance(input);
                        if (lenght < min || j == 0)
                        {
                            min = lenght;
                            neuronNumber = j;
                        }
                        neuronMap[neuronNumber].CalculateNewWeights(input, lr);
                    }
                    counter++;
                }
                CalculateLearningRate();
            } while (Max > counter);
        }

        public void Test(double[,] inputArray)
        {
            int neuronNumber;
            int[] responseCounter = new int[neuronMap.Length];
            responseCounter.Select(i => 0).ToArray();

            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                double[] input = DataProvider.GetInput(i, inputArray);
                neuronNumber = ClassifyInput(input);
                responseCounter[neuronNumber]++;
                Console.WriteLine(DataProvider.Character[i] + " Got: " + neuronNumber);
            }
            int n;
            for(int i = 0; i < responseCounter.Length; i++)
            {
                n = responseCounter[i];
                if(n!=0)
                Console.WriteLine("Neuron: " + i + " Count: " + n);
            }
        }

        private void CalculateLearningRate()
        {
            lr /= 2;
        }

        private int ClassifyInput(double[] input)
        {
            int classification = 0;
            double lenght;
            double min = 0.0;
            for (int j = 0; j < neuronMap.Length; j++)
            {
                lenght = neuronMap[j].CalculateEuclideanDistance(input);
                if (lenght < min || j == 0)
                {
                    min = lenght;
                    classification = j;
                }
            }
            return classification;
        }
    }
}
