using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen4ver2
{
    class Neuron
    {
        double[] weights;
        public Neuron(double[] weights)                         //kopiowanie tablicy z wagami
        {
            this.weights = new double[weights.Length];
            Array.Copy(weights, this.weights, weights.Length);
        }

        public double CalculateEuclideanDistance(double[] input)    //obliczanie dystansu
        {
            double sum = 0.0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += Math.Pow((input[i] - weights[i]), 2);
            }
            sum += Math.Pow((1 - weights[input.Length]), 2);
            return Math.Sqrt(sum);
        }

        public void PrintWeights()
        {
            foreach (double w in weights)
            {
                Console.WriteLine(w);
            }
        }

        public double[] GetWeights()
        {
            return weights;
        }

        public void CalculateNewWeights(double[] input, double lr)  //obliczanie nowych wag dla wygrywającego neuronu
        {
            for (int i = 0; i < input.Length; i++)
            {
                weights[i] += lr * (input[i] - weights[i]);
            }

            weights[input.Length] += lr * (1 - weights[input.Length]);
        }

        public void CalculateNewWeights(double[] input, double lr, double theta)    //obliczanie nowych wag dla neuronów znajdujących się w sąsiedztwie
        {
            for (int i = 0; i < input.Length; i++)
            {
                weights[i] += lr * theta * (input[i] - weights[i]);
            }

            weights[input.Length] += lr * theta * (1 - weights[input.Length]);
        }
    }
}
