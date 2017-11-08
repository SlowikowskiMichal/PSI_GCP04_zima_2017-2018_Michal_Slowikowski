using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2
{
    class Perceptron
    {
        private double[] weights;
        private double bias = 1;
        private double treshold = 0;

        public Perceptron(double[] weights)
        {
            this.weights = weights;
        }

        public int GetResult(int[] input)
        {
            double sum = InputSummary(input);
            return PerceptronActivation(sum);
        }

        private double InputSummary(int[] input)
        {
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += weights[i] * input[i];
            }

            return sum + weights[input.Length] * bias;
        }

        private int PerceptronActivation(double sum)
        {
            int active = 1;
            int inactive = 0;

            if (sum >= treshold)
            {
                return active;
            }
            else
            {
                return inactive;
            }
        }

        public void Learn(int[] input, double expected, double lr)
        {
            double result = GetResult(input);

            for (int i = 0; i < input.Length; i++)
                weights[i] += (expected - result) * lr * input[i];

            weights[6] += lr * (expected - result);
        }
    }
}
