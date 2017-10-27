using System;

namespace Scen1.TrainingSessions
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
            Trainer trainer = new Trainer(inputData, expectedOutput, learningRate);
            trainer.train(ref perceptron);
          //  printResult(, checkIfPerceptronReturnsExpectedOutput(perceptron), weights);

            return perceptron;
        }

        private void printResult(bool trainingStatus, bool testResult, double[] weights)
        {
            Console.WriteLine("Perceptron passed training: " + trainingStatus);
            Console.WriteLine("Perceptron test result: " + testResult);
            Console.WriteLine("Weights:");
            for (int i = 0; i < weights.Length; i++)
            {
                Console.WriteLine("W" + i + ": " + weights[i]);
            }
        }

        protected virtual bool checkIfPerceptronReturnsExpectedOutput(Perceptron perceptron)
        {
            bool result = true;
            for (int i = 0; i < expectedOutput.Length; i++)
            {
                result &= perceptron.getResult(inputData[i]).Equals(expectedOutput[i]);
            }
            return result;
        }
    }
}
