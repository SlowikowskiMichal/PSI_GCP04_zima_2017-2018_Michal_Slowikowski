﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2
{
    class PercetronTrainer
    {
        private Perceptron[] layer;
        private double[] results;
        private int biasID;
        private double learningRate;
        private int Max = 100000000;

        public PercetronTrainer(int numberOfPerceptrons, double learningRate)
        {
            this.learningRate = learningRate;
            biasID = Letters.NumberOfFields;
            layer = new Perceptron[numberOfPerceptrons];
            results = new double[numberOfPerceptrons];

            Random r = new Random();
            double[] weights = new double[Letters.NumberOfFields + 1];

            for(int i = 0; i < numberOfPerceptrons; i++)
            {
                for (int j = 0; j < weights.Length; j++)
                {
                    weights[j] = r.NextDouble();
                }
                layer[i] = new Perceptron(weights);
            }
        }

        public void Train()
        {
            int counter = 0;
            int[] input;
            int expected;
            double result;
            double mseError;
            do
            {
                mseError = 0.0;
                for (int i = 0; i < Letters.Expected.Length; i++)
                {
                    for(int j = 0; j < 2; j++)
                    {
                        input = Letters.GetLetter(i, Letters.LettersData);
                        expected = GetExpected(Letters.Expected[i], j);
                        layer[j].Learn(input, expected,learningRate);
                        result = layer[j].GetResult(input);
                        mseError += Math.Pow((expected - result), 2.0);
                    }
                }
                Console.WriteLine(mseError);
                counter++;
            } while (counter < Max && mseError > 0.001);
        }

        public void Test(int[,,] dataSet)
        {
            double rate = Letters.Expected.Length;
            int[] input;
            int expected;
            for(int i = 0; i < Letters.Expected.Length; i++)
            {
                input = Letters.GetLetter(i, dataSet);
                expected = Letters.Expected[i];

                if (Act(input) != expected)
                    rate--;

                if(Act(input) == 1)
                {
                    Console.WriteLine("Duża");
                }
                else
                {
                    Console.WriteLine("Mała");
                }
            }
            Console.WriteLine("Poprawne odpowiedzi: " + rate/20 * 100 + "%");
        }
        
        private int GetLetterSizeFromLayer(int[] input)
        {
            for(int i = 0; i < results.Length; i++)
            {
                results[i] = layer[i].GetResult(input);
            }

            if(results[0] >= results[1])
            {
                return 0;
            }

            return 1;
        }

        private int GetExpected(int expected, int nr)
        {
            if(nr == 0)
            {
                return expected;
            }
            else if(expected > 0)
            {
                return 0;
            }

            return 1;
        }

        public int Act(int[] input)
        {
            if(layer[0].GetResult(input) > layer[1].GetResult(input))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
