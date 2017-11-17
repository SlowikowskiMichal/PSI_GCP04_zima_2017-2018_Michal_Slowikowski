using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2ver2
{
    class PercetronTrainer
    {
        private Perceptron perceptronToLearn;
        private int biasID;
        private double learningRate;
        private int Max = 100000;

        public PercetronTrainer(int numberOfPerceptrons, double learningRate)
        {
            this.learningRate = learningRate;

            biasID = Letters.NumberOfFields;
            Random r = new Random();
            double[] weights = new double[Letters.NumberOfFields + 1];

            for (int i = 0; i < numberOfPerceptrons; i++)
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
            double rate;
            do
            {
                rate = 20;
                error = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        letterID = i * 10 + j;
                        letter = Letters.GetLetter(i, j, Letters.LettersData);
                        output[letterID] = perceptronToLearn.GetResult(letter);
                        perceptronToLearn.Learn(letter, Letters.Expected[letterID], learningRate);
                        error += Math.Abs(Letters.Expected[letterID] - output[letterID]);
                        if (Letters.Expected[letterID] != output[letterID])
                            rate--;
                    }
                }
                counter++;
                Console.WriteLine("Error: " + error / Letters.NumberOfFields);
            } while (error > 0.01 && counter < Max);
            Console.WriteLine("Lerned after: " + counter);
        }

        private int[] GetLetter(int i, int j)
        {
            int[] letter = new int[Letters.NumberOfFields];
            for (int y = 0; y < Letters.NumberOfFieldsY; y++)
                for (int x = 0; x < Letters.NumberOfFieldsX; x++)
                    letter[y * Letters.NumberOfFieldsX + x] = Letters.LettersData[i, j, y, x];
            return letter;
        }


        public void Test(int[,,,] data)
        {
            Console.WriteLine("------------------------Test-------------------------");
            int[] output = new int[Letters.Expected.Length];
            int letterID;
            int[] letter = new int[Letters.NumberOfFields];
            double rate = 20;
            Console.WriteLine("Expected\tGot ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    letterID = i * 10 + j;
                    letter = Letters.GetLetter(i, j, data);
                    output[letterID] = perceptronToLearn.GetResult(letter);
                    Console.WriteLine(Letters.Expected[letterID] + "\t" + output[letterID]);
                    if (Letters.Expected[letterID] != output[letterID])
                        rate--;
                }
            }
            Console.WriteLine(rate / 20 * 100 + "% success rate");
        }
    }
}
