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
        private double neighborRadius;
        private double lambda;
        public Map(double learningRate, int numberOfNeurons, int iter, double neighbor)         //ustawienie wartości
        {
            this.lambda = iter / Math.Log(neighbor);
            this.neighborRadius = neighbor;
            this.Max = iter;
            this.numberOfNeurons = numberOfNeurons;
            lr = learningRate;
            neuronMap = new Neuron[this.numberOfNeurons];
            Random r = new Random();
            double[] weights = new double[DataProvider.input.GetLength(1) + 1];
            int size = (int)Math.Sqrt(numberOfNeurons);
            double x = 0; 
            double y = 0;
            for (int j = 0; j < numberOfNeurons; j++)
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

        public void Learn()             //nauka
        {

            double lenght;
            double min;
            int counter = 0;
            int neuronNumber = 0;
            do
            {
                DataProvider.ShuffleInputData();                                //wymieszaj dane wejściowe
                for (int i = 0; i < DataProvider.input.GetLength(0); i++)
                {
                    double[] input = DataProvider.GetInput(i, DataProvider.input);
                    min = 0.0;
                    for (int j = 0; j < neuronMap.Length; j++)                  //szukanie neuronu najbliższego
                    {
                        lenght = neuronMap[j].CalculateEuclideanDistance(input);
                        if (lenght < min || j == 0)
                        {
                            min = lenght;
                            neuronNumber = j;
                        }
                    }
                    neuronMap[neuronNumber].CalculateNewWeights(input, lr); //obliczanie wag neuronu
                }
                counter++;
                CalculateLearningRate();                    //obliczanie nowego lr
                CalculateNeighborRadius(counter);               //obliczanie nowego promienia
            } while (Max > counter);
            DataProvider.RestoreInputToCorrectOrder();
        }

        private void CalculateNewWeights(int neuronNumber, double[] input)          //obliczanie wag neuronu wygrywającego i sąsiadów
        {
            neuronMap[neuronNumber].CalculateNewWeights(input, lr);     //obliczanie wag zwycięzcy
            for (int j = 0; j < neuronMap.Length; j++)                     //szukanie sąsiadów
            {
                if(j!=neuronNumber)
                {
                    double[] w = new double[70];
                    Array.Copy(neuronMap[neuronNumber].GetWeights(), w, 70);
                    double distance = neuronMap[j].CalculateEuclideanDistance(w);
                    if (distance <= neighborRadius)                                     //gdy znajdzie sąsiada oblicza jego nowe wagi
                    {
                        double theta = CalculateTheta(distance);
                        CalculateNewWeights(neuronNumber, input);
                    }
                }

            }
        }

        private double CalculateTheta(double distance)                      //obliczanie wartości theta (uwzględniana w wagach sąsiada)
        {
            return Math.Exp(-(Math.Pow(distance, 2) / (2 * Math.Pow(neighborRadius, 2))));
        }

        public void Test(double[,] inputArray)                  //testowanie mapy
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
            for (int i = 0; i < responseCounter.Length; i++)
            {
                n = responseCounter[i];
                if (n != 0)
                    Console.WriteLine("Neuron: " + i + " Count: " + n);
            }
        }

        private void CalculateNeighborRadius(int epoch)             //zmiana 
        {
            neighborRadius = neighborRadius * Math.Exp(-epoch / lambda);
        }

        public void PrintMap(double[,] inputArray)                  //wyświetl nową mapę
        {
            int size = inputArray.GetLength(0) / DataProvider.Character.Length;
            int mapS = (int)Math.Sqrt(numberOfNeurons);
            int beg = 0;
            int end = size;
            String[] map = new String[numberOfNeurons];
            for (int i = 0; i < map.Length; i++)
            {
                map[i] = "";
            }

            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                beg = i * size;
                end = beg + size;
                map = calculateMap(map, beg, end, DataProvider.Character[i].ToString(), inputArray);
            }

            for (int i = 0; i < mapS; i++)
            {
                for (int j = 0; j < mapS; j++)
                {
                    int k = i * mapS + j;
                    if (map[k] == "")
                    {
                        Console.Write(".\t");
                    }
                    else
                    {
                        Console.Write(map[k] + "\t");
                    }
                }
                Console.WriteLine();
            }
        }

        private String[] calculateMap(String[] map, int beg, int end, String type, double[,] inputArray)        //metoda do wyświetlania która litera aktywuje który neuron w mapie
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

        private void CalculateLearningRate()            //obliczanie lr
        {
            lr /= 2;
        }

        private int ClassifyInput(double[] input)           //klasyfikacja który neuron zostanie aktywowany dla tego inputu
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
