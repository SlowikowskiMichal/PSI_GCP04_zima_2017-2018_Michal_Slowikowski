using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2ver2
{
    class Trainer
    {
        private NeuralNetwork network;
        private int Max;

        public Trainer(int[] neuralStructure, float learningRate, int max)
        {
            network = new NeuralNetwork(neuralStructure,learningRate);
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
                for (float x = -2; x <= 2; x += 0.5f)
                {
                    for (float y = -2; y <= 2; y += 0.5f)
                    {
                        float expected = (float)((RastrignsProvider.CalculateResult(x, y) + 50) / 100);
                        float output = network.FeedForward(new float[] { x, y, 1 })[0];
                        totalError += Math.Pow(output - expected,2);
                        network.BackProp(new float[] { expected });
                    }
                }
                counter++;
                if (counter % (Max / 10) == 0)
                {
                    Console.WriteLine("Error: " + totalError);
                    Test();
                }
            } while (counter < Max && totalError > 0.000001);
            Console.WriteLine("Error: " + totalError + " Counter: " + counter);
        }

        public void Test()
        {
            float error = 0.0f;
            int iterator = 0;
            for (float x = -2; x <= 2; x += 1f)
            {
                for (float y = -2; y <= 2; y += 1f)
                {
                    float result = network.FeedForward(new float[] { x, y, 1 })[0];
                    float expected = (float)((RastrignsProvider.CalculateResult(x, y)));
                    Console.WriteLine(x + " " + y + " Got: " + (result * 100 - 50) + " Expected: " + expected);
                    iterator++;
                    error += Math.Abs((result * 100 - 50) - expected);
                }
            }
            Console.WriteLine("Prawdziwy blad sredni: " + (error / (float)iterator));
        }
    }
}