using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen1
{
    class Trainer
    {

        private int[][] inputDataSets;
        private int[] expectedOutputs;
        private double learningRate;
        private const double maxNumberOfSeasions = 1000000;

        public Trainer(int[][] inputDataSets, int[] expectedOutputs, double learningRate)
        {
            this.inputDataSets = inputDataSets;
            this.expectedOutputs = expectedOutputs;
            this.learningRate = learningRate;
        }

        public bool train(ref Perceptron perceptronToTrain)
        {
            bool passed = false;
            int tryNumber = 0;

            do
            {
                if(perceptronRule(ref perceptronToTrain) == 0)
                {
                    passed = true;
                }

                tryNumber++;

            } while (!passed && tryNumber < maxNumberOfSeasions);
            Console.WriteLine("After: " + tryNumber + " generations");
            return passed;
        }

        private double perceptronRule(ref Perceptron perceptron)
        {
            int error;
            int biasID = inputDataSets[0].Length;
            double weightModyfier = 0.0;
            double totalError = 0;
            double[] weights = perceptron.getWeights();

            for (int i = 0; i < expectedOutputs.Length; i++)
            {
                error = expectedOutputs[i] - perceptron.getResult(inputDataSets[i]);
                for (int j = 0; j < inputDataSets[0].Length; j++)
                {
                    weightModyfier = learningRate * error * inputDataSets[i][j];
                    weights[j] += weightModyfier;
                    totalError += Math.Abs(weightModyfier);
                }
                weightModyfier = learningRate * error;
                weights[biasID] += weightModyfier;
                totalError += Math.Abs(weightModyfier);
            }

            perceptron.setWeights(weights);

            return totalError;
        }
    }
}
