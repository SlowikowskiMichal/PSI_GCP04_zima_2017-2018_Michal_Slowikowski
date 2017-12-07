using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2ver2
{
    class XORTrainer
    {
        private Layer[] network;
        private const int Max = 100000;
        public double[,] input = { { 0, 0 }, { 0, 1 }, { 1, 0 }, { 1, 1 } };
        public double[] expected = { 0, 1, 1, 0 };

        public XORTrainer(int[,] neuralStructure, double learningRate)
        {
            network = new Layer[neuralStructure.GetLength(0)];
            for (int i = 0; i < neuralStructure.GetLength(0); i++)
            {
                network[i] = new Layer(neuralStructure[i, 0], neuralStructure[i, 1], learningRate);
            }
        }

        public void PrintNeuralNetwork()
        {
            int i = 1;
            foreach (Layer l in network)
            {
                Console.WriteLine("------------------- Warstwa " + i + " -------------------");
                l.PrintLayer();
                i++;
            }
        }

        public double GetOutput(double[] input)
        {
            double[] result = new double[input.Length];
            Array.Copy(input, result, input.Length);
            double output = 0.0;
            for (int i = 0; i < network.Length; i++)
            {
                result = network[i].CalculateOutput(result);
            }
            for (int i = 0; i < result.Length; i++)
                output += result[i];

            return output;
        }

        public void Learn()
        {
            double error;
            double totalError;
            int counter = 0;
            double output;
            double pirvE;
            double[] data = new double[2];
            do
            {
                totalError = 0.0;
                for (int i = 0; i < 4; i++)
                {
                    data[0] = input[i, 0];
                    data[1] = input[i, 1];
                    output = 0.0;
                    //expected = (RastrignsProvider.CalculateResult(x, y) + 50) / 100;
                    output = GetOutput(data);
                    error = expected[i] - output;
                    // Console.WriteLine("True Expected: " + (expected*80-40) + " Expected: " + expected + " Got: " + output + " Error: " + error);
                    totalError += Math.Pow(error, 2) / 2;
                    BackPropagation(error, data);
                }

                counter++;
                pirvE = totalError;
                Console.WriteLine(totalError);
                //  Console.WriteLine("-----------------------------------------------------------------------------------------");
            } while (totalError > 0.001 && counter < Max);
            Console.WriteLine(counter);
            Console.ReadLine();
        }

        public void Test()
        {
            double output;
            double[] data = new double[2];

            for (int i = 0; i < 4; i++)
            {
                data[0] = input[i, 0];
                data[1] = input[i, 1];
                output = GetOutput(data);

                Console.WriteLine(data[0] + " " + data[1] + " " + output);
            }
            Console.ReadLine();
        }

        public void BackPropagation(double error, double[] input)
        {
            double[] errorsFromNextLayer = new double[] { error };

            errorsFromNextLayer = network[network.Length - 1].CalculateLastError(errorsFromNextLayer);

            for (int i = network.Length - 2; i >= 0; i--)
            {
                errorsFromNextLayer = network[i].CalculateError(errorsFromNextLayer, network[i + 1]);
            }

            CalculateNewWeights(input);
        }

        private void CalculateNewWeights(double[] input)
        {
            double[] result = new double[input.Length];
            Array.Copy(input, result, input.Length);
            for (int i = 0; i < network.Length; i++)
            {
                network[i].CalculateNewWeights(result);
                result = network[i].lastOutput;
            }
        }
    }
}
