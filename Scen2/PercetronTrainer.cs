using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2
{
    class PercetronTrainer
    {
        private Perceptron[] layer;
        private int biasID;
        private double learningRate;

        public PercetronTrainer(int numberOfPerceptrons, double learningRate)
        {
            layer = new Perceptron[numberOfPerceptrons];
            biasID = Letters.NumberOfFields;
            Random r = new Random();
            double[] weights = new double[Letters.NumberOfFields + 1];
            for(int i = 0; i < weights.Length; i++)
            {
                weights[i] = r.NextDouble();
            }

            for(int i = 0; i < numberOfPerceptrons; i++)
            {
                layer[i] = new Perceptron(weights);
            }
        }

        public void Train()
        {
            int[] output = new int[Letters.Expected.Length];

            while(!output.SequenceEqual(Letters.Expected))
            {
                for(int i = 0; i < 2; i++)
                {
                    for(int j = 0; j < 10; j++)
                    {
                        //TODO
                    }

                }
            }
        }

    }
}
