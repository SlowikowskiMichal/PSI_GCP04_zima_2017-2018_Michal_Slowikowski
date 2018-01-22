using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2ver2
{
    class XORTrainer
    {
        private NeuralNetwork network;
        private int Max;
        public float[,] input = { { 0, 0 }, { 0, 1 }, { 1, 0 }, { 1, 1 } };
        public float[] expected = { 0, 1, 1, 0 };

        public XORTrainer(int[] neuralStructure, float learningRate, int max)
        {
            network = new NeuralNetwork(neuralStructure, learningRate);
            Max = max;
        }

        public void PrintNeuralNetwork()
        {
            network.Print();
        }

        public void Learn()
        {
            int counter = 0;
            double totalError = 0.0f;
            do
            {
                totalError = 0.0f;
                for (int i = 0; i < input.GetLength(0); i++)
                {
                    float x = input[i, 0];
                    float y = input[i, 1];
                    totalError += Math.Pow(network.FeedForward(new float[] { x, y, 1 })[0] - expected[i], 2);
                    network.BackProp(new float[] { expected[i] });
                }

                counter++;

                if (counter % (Max / 10) == 0)
                {
                    Console.WriteLine("Error: " + totalError);
                    Test();
                }

            } while (counter < Max && totalError > 0.0001);
            Console.WriteLine("Error: " + totalError + " Counter: " + counter);
        }

        public void Test()
        {
            for (float x = -1; x <= 1; x += 1f)
            {
                for (float y = -1; y <= 1; y += 1f)
                {
                   
                }
            }
            for (int i = 0; i < input.GetLength(0); i++)
            {
                float x = input[i, 0];
                float y = input[i, 1];
                Console.WriteLine(x + " " + y + " Got: " + (network.FeedForward(new float[] { x, y, 1 })[0]) + " Expected: " + expected[i]);
            }

        }
    }
}
