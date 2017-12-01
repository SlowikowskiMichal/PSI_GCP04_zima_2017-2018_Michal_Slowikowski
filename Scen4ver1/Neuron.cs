using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen4ver1
{
    class Neuron
    {
        double[] weights;
        public Neuron(double[] weights)
        {
            this.weights = new double[weights.Length];
            Array.Copy(weights, this.weights, weights.Length);
        }

        public double CalculateEuclideanDistance(double[] input)
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

        public void CalculateNewWeights(double[] input, double lr)
        {
            for(int i = 0; i < input.Length; i++)
            {
                weights[i] += lr * (input[i] - weights[i]);
            }

            weights[input.Length] += lr * (1 - weights[input.Length]);
        }
    }
}
