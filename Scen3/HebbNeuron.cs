using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen3
{
    class HebbNeuron
    {
        protected double[] weights;
        protected double bias = 0.5;
        protected double treshold = 0;

        public HebbNeuron(double[] weights)
        {
            this.weights = new double[weights.Length];
            Array.Copy(weights, this.weights, weights.Length);
        }
        public double GetResult(double[] input)
        {
            double sum = InputSummary(input);
            return PerceptronActivation(sum);
        }
        public void Learn(double[] input, double output, double lr, double decay)
        {
            for (int i = 0; i < input.Length; i++)
            {
                weights[i] += ((1 - decay) * weights[i] + lr * output * input[i]);
                
            }
            bias += ((1 - decay) * bias + lr * output) ;
            Normalize();
        }
        public void PrintWeights()
        {
            for (int i = 0; i < DataProvider.NumberOfFields; i++)
            {
                Console.WriteLine("Weight " + i + " : " + weights[i]);
            }
            Console.WriteLine("BIAS: " + bias);
            Console.ReadLine();
        }

        protected double InputSummary(double[] input)
        {
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += weights[i] * input[i];
            }

            return sum + bias;
        }

        protected double PerceptronActivation(double sum)
        {
            return 1 / (1 + Math.Exp(-sum));
        }

        protected void Normalize()
        {
            double dl = 0.0;
            for (int i = 0; i < weights.Length; i++)
                dl += Math.Pow(weights[i], 2);

            dl = Math.Sqrt(dl);

            for (int i = 0; i < weights.Length; i++)
                if (weights[i] > 0 && dl != 0)
                    weights[i] = weights[i] / dl;
            if (dl != 0)
                bias = bias / dl;
        }
    }
}
