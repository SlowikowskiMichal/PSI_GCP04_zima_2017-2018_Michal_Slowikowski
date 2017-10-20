using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen1
{
    class TrainingSession
    {
        protected virtual int[][] inputData
        {
            get
            {
                return
                  new int[][]{
                        new int[2] { 0, 0 },
                        new int[2] { 0, 1 },
                        new int[2] { 1, 0 },
                        new int[2] { 1, 1 }
                  };
            }
        }
        protected virtual int[] expectedOutput
        {
            get { return new int[] { 0, 0, 0, 0 }; }
        }

        public Perceptron run(double learningRate)
        {
            Random r = new Random();
            int weightCountWithBias = inputData[0].Length + 1;
            double[] weights = new double[weightCountWithBias];

            for (int i = 0; i <= inputData[0].Length; i++)
            {
                weights[i] = r.NextDouble();
            }

            Perceptron perceptron = new Perceptron(weights);
            Trainer trainerAnd = new Trainer(inputData, expectedOutput, learningRate);

            printResult(trainerAnd.train(ref perceptron),weights);

            return perceptron;
        }

        private void printResult(bool trainingStatus, double[] weights)
        {
            Console.WriteLine("Perceptron passed training: " + trainingStatus + "\nWeights: ");
            for(int i = 0; i < weights.Length; i++)
            {
                Console.WriteLine("W" + i + ": " + weights[i]);
            }
            Console.WriteLine("---------------------------------------------------");
        }
    }
}
