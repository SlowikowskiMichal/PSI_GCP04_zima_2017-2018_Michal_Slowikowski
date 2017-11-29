using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2
{
    class Adaline
    {
        protected double[] weights;
        protected double bias = 1;
        protected double treshold = 0;

        public Adaline(double[] weights)
        {
            this.weights = new double [weights.Length];
            Array.Copy(weights, this.weights, weights.Length);
        }

        public double GetResult(int[] input)
        {
            return InputSummary(input);
        }

        protected double InputSummary(int[] input)
        {
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += weights[i] * input[i];
            }

            return sum + weights[input.Length] * bias;
        }

        protected double PerceptronActivation(double sum)
        {
            return 1 / (1 + Math.Exp(sum));
        }

        public void Learn(int[] input, double expected, double lr)
        {
            double result = GetResult(input);

            for (int i = 0; i < input.Length; i++)
                weights[i] += (expected - result) * lr * input[i];

            weights[Letters.NumberOfFields] += lr * (expected - result);
        }

        public double Test(int[] input)
        {
            double sum = InputSummary(input);
            return PerceptronActivation(sum);
        }

        public void PrintWeights()
        {
            for (int i = 0; i < Letters.NumberOfFields; i++)
            {
                Console.WriteLine("Weight " + i + " : " + weights[i]);
            }

            Console.WriteLine("BIAS: " + bias + " WEIGHT: " + weights[Letters.NumberOfFields]);
            Console.ReadLine();
        }
    }
}
