﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2ver2
{
    class Neuron
    {
        private double BIAS = 1;
        private double[] weights;

        public Neuron(double[] weights)
        {
            this.weights = new double[weights.Length];
            Array.Copy(weights, this.weights, weights.Length);
        }

        public double GetResult(double[] input)
        {
            double sum = InputSummary(input);
            return PerceptronActivation(sum);
        }
        public void Learn(double[] input, double error, double lr)
        {
            double div = Derive(InputSummary(input));

            for (int i = 0; i < input.Length; i++)
                weights[i] += error * lr * div * input[i];

            weights[input.Length] = lr * error;
        }
        public double GetWeight(int numberOfInput)
        {
            return weights[numberOfInput];
        }
        public void PrintWeights()
        {
            for (int i = 0; i < weights.Length; i++)
            {
                if (i != weights.Length - 1)
                    Console.Write("Weight " + i);
                else
                    Console.Write("BIAS ");
                Console.WriteLine(" : " + weights[i]);
            }
        }
        public double InputSummary(double[] input)
        {
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += weights[i] * input[i];
            }

            return sum + weights[input.Length] * BIAS;
        }
        protected double PerceptronActivation(double sum)
        {
            return 1 / (1 + Math.Exp(-sum));
        }
        protected double Derive(double x)
        {
            double div = Math.Exp(x) / Math.Pow((Math.Exp(x) + 1), 2);
            return div;
        }
    }
}
