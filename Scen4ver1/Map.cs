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
        private int numberOfNeurons;
        private double lr;
        private double Max;
        public Map(double learningRate, int numberOfNeurons, int iter)      //tworzy tablicę neuronów i losuje początkowe wagi
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
                DataProvider.ShuffleInputData();                                //miesza dane wejściowe
                for (int i = 0; i < DataProvider.input.GetLength(0); i++)       //dla każdego rekordu
                {
                    min = 0.0;
                    for (int j = 0; j < neuronMap.Length; j++)                  //szuka najbliższego neuronu
                    {
                        double[] input = DataProvider.GetInput(i, DataProvider.input);
                        lenght = neuronMap[j].CalculateEuclideanDistance(input);
                        if (lenght < min || j == 0)
                        {
                            min = lenght;
                            neuronNumber = j;
                        }
                        neuronMap[neuronNumber].CalculateNewWeights(input, lr); //oblicza nowe wagi dla zwycięzcy
                    }
                }
               // CalculateLearningRate();
                counter++;
            } while (Max > counter);
            DataProvider.RestoreInputToCorrectOrder();
        }
        

        public void Test(double[,] inputArray)                              //testowanie, wypisuje który neuron ile razy został aktywowany
        {
            int neuronNumber;
            int[] responseCounter = new int[neuronMap.Length];
            responseCounter.Select(i => 0).ToArray();
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                double[] input = DataProvider.GetInput(i, inputArray);
                neuronNumber = ClassifyInput(input);
                responseCounter[neuronNumber]++;
            }
            int n;
            for (int i = 0; i < responseCounter.Length; i++)
            {
                n = responseCounter[i];
                if (n != 0)
                    Console.WriteLine("Neuron: " + i + " Count: " + n);
            }
        }

        public void PrintMap(double[,] inputArray)
        {
            int size = inputArray.GetLength(0) / 3;
            int mapS = (int)Math.Sqrt(numberOfNeurons);
            int beg = 0;
            int end = size;
            String[] map = new String[numberOfNeurons];
            for (int i = 0; i < map.Length; i++)
            {
                map[i] = "";
            }

            map = CalculateMap(map, beg, end, "A", inputArray);
            beg += size;
            end += size;
            map = CalculateMap(map, beg, end, "B", inputArray);
            beg += size;
            end += size;
            map = CalculateMap(map, beg, end, "C", inputArray);

            for (int i = 0; i < mapS; i++)
            {
                for (int j = 0; j < mapS; j++)
                {
                    int k = i * mapS + j;
                    if (map[k] == "")
                    {
                        Console.Write(".\t\t");
                    }
                    else
                    {
                        Console.Write(map[k] + "\t\t");
                    }
                }
                Console.WriteLine();
            }
        }

        private String[] CalculateMap(String[] map, int beg, int end, String type, double[,] inputArray) //metoda do jakie dane aktrywuje neuron
        {
            int nn;
            for (int i = beg; i < end; i++)
            {
                double[] input = DataProvider.GetInput(i, inputArray);
                nn = ClassifyInput(input);
                map[nn] += type;
            }
            return map;
        }

        private void CalculateLearningRate()    //oblicza nowy lr
        {
            lr /= 2;
        }

        private int ClassifyInput(double[] input)       //który neuron jest aktywowany dla danego inputu
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
