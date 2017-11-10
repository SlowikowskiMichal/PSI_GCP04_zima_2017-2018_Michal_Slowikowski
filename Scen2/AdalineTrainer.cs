﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2
{
    class AdalineTrainer
    {
        private Adaline adalineToLearn;
        private int biasID;
        private double learningRate;
        private int Max = 100000;

        public AdalineTrainer(int numberOfPerceptrons, double learningRate)
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
                adalineToLearn = new Adaline(weights);
            }
        }

        public void Train()
        {
            double[] output = new double[Letters.Expected.Length];
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
                        output[letterID] = adalineToLearn.GetResult(letter);
                        adalineToLearn.Learn(letter, Letters.Expected[letterID], learningRate);
                        //                       Console.WriteLine("Expected: " + Letters.Expected[letterID] + " Got: " + output[letterID]);
                        error += Math.Pow((Letters.Expected[letterID] - output[letterID]), 2);
                        if (Letters.Expected[letterID] != adalineToLearn.Test(letter))
                            rate--;
                    }
                }

                error /= 2.0;
                //                Console.WriteLine("Error: " + error);
                //                Console.WriteLine("-----------------------");
                counter++;
                Console.WriteLine(rate / 20 * 100 + "% success rate");
                //                adalineToLearn.PrintWeights();
            } while (error > 0.0001 && counter < Max);
            Console.WriteLine("Error: " + error);
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
            Console.WriteLine("Expected\tGot\tAfter Activation");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    letterID = i * 10 + j;
                    letter = Letters.GetLetter(i, j, data);
                    output[letterID] = adalineToLearn.Test(letter);
                    Console.WriteLine(Letters.Expected[letterID] + "\t" + adalineToLearn.GetResult(letter) + "\t" + output[letterID]);
                    if (Letters.Expected[letterID] != output[letterID])
                        rate--;
                }
            }
            Console.WriteLine(rate / 20 * 100 + "% success rate");
        }
    }
}
