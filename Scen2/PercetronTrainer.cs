using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2
{
    class PercetronTrainer
    {
        private Perceptron perceptronToLearn;
        private int biasID;
        private double learningRate;
        private int MAX = 100000;

        public PercetronTrainer(int numberOfPerceptrons, double learningRate)
        {
            this.learningRate = learningRate;

            biasID = Letters.NumberOfFields;
            Random r = new Random();
            double[] weights = new double[Letters.NumberOfFields + 1];

            for(int i = 0; i < numberOfPerceptrons; i++)
            {
                for (int j = 0; j < weights.Length; j++)
                {
                    weights[i] = r.NextDouble();
                }
                perceptronToLearn = new Perceptron(weights);
            }
        }

        public void Train()
        {
            int[] output = new int[Letters.Expected.Length];
            int letterID;
            int[] letter = new int[Letters.NumberOfFields];
            int counter = 0;
            double error;
            int[] expected = Letters.Expected;
            do
            {
                error = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        letterID = i * 10 + j;
                        letter = Letters.GetLetter(i, j);
                        output[letterID] = perceptronToLearn.GetResult(letter);
                        perceptronToLearn.Learn(letter, Letters.Expected[letterID], learningRate);
                        Console.WriteLine("Expected: " + Letters.Expected[letterID] + " Got: " + output[letterID]);
                        error += Math.Pow((expected[letterID] - output[letterID]), 2);
                    }
                }

                error /= 2.0;
                Console.WriteLine("Error: " + error);
                Console.WriteLine("-----------------------");
                Console.ReadLine();
                counter++;
            } while (error > 0.0001);
        }

        private int[] GetLetter(int i, int j)
        {
            int[] letter = new int[Letters.NumberOfFields];
            for (int y = 0; y < Letters.NumberOfFieldsY; y++)
                for (int x = 0; x < Letters.NumberOfFieldsX; x++)
                    letter[y * Letters.NumberOfFieldsX + x] = Letters.LettersData[i, j, y, x];
            return letter;
        }

    }
}
