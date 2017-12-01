﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2ver2
{
    class Trainer
    {
        private Layer[] network;
        private const int Max = 100000;

        public Trainer(int[,] neuralStructure)
        {
            network = new Layer[neuralStructure.GetLength(0)];
            for(int i = 0; i < neuralStructure.GetLength(0); i++)
            {
                network[i] = new Layer(neuralStructure[i, 0], neuralStructure[i, 1]);
            }
        }

        public void PrintNeuralNetwork()
        {
            int i = 1;
            foreach(Layer l in network)
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

        public void Learn(double learningRate)
        {
            double error;
            double totalError;
            int counter = 0;
            double output;
            double expected;
            double pirvE;
            do
            {
                totalError = 0.0;
                for(double x = -2; x <= 2; x+=0.2)
                {
                    for(double y = -2; y <= 2; y+=0.2)
                    {
                        output = 0.0;
                        expected = (RastrignsProvider.CalculateResult(x, y)+50)/100;
                        double[] input = new double[] { x, y };
                        output = GetOutput(input);
                        error = expected - output;
                       // Console.WriteLine("True Expected: " + (expected*80-40) + " Expected: " + expected + " Got: " + output + " Error: " + error);
                        totalError += Math.Pow(error,2)/2;
                        BackPropagation(error, input);
                    }
                }
                counter++;
                pirvE = totalError;
                Console.WriteLine(totalError + "\t" + counter);
              //  Console.WriteLine("-----------------------------------------------------------------------------------------");
            } while (totalError > 0.001 && counter < Max);
            Console.WriteLine(counter);
            Console.ReadLine();
        }

        public void Test()
        {
            double error;
            double totalError;

            double output;
            double expected;

            int c = 0;
            totalError = 0.0;
            for (double x = -2; x <= 2; x += 0.1)
            {
                for (double y = -2; y <= 2; y += 0.1)
                {
                    output = 0.0;
                    expected = (RastrignsProvider.CalculateResult(x, y) + 50) / 100;
                    double[] input = new double[] { x, y };
                    output = GetOutput(input);
                    error = expected - output;
                    Console.WriteLine(x + " " + y);
                    Console.WriteLine("True Expected: " + (expected*100-50) + " Expected: " + expected + 
                        "\nTrue Got: " + (output*100-50) + " Got: " + output + " Error: " + error);
                    totalError += Math.Abs(error);
                    c++;
                }
            }
            Console.WriteLine("Sredni blad: " + totalError/c);
            Console.WriteLine("Total error: " + totalError);
            Console.ReadLine();
        }

        public void BackPropagation(double error, double[] input)
        {
            double[] errorsFromNextLayer = new double[] { error };

            errorsFromNextLayer = network[network.Length - 1].CalculateLastError(errorsFromNextLayer);

            for(int i = network.Length-2; i >= 0; i--)
            {
                errorsFromNextLayer = network[i].CalculateError(errorsFromNextLayer,network[i+1]);
            }

            CalculateNewWeights(input);
        }

        private void CalculateNewWeights(double[] input)
        {
            double[] result = new double[input.Length];
            Array.Copy(input, result, input.Length);
            for(int i = 0; i < network.Length; i++)
            {
                network[i].CalculateNewWeights(result);
                result = network[i].lastOutput;
            }
        }
    }
}
/*              
            do
            {
                error = 0.0;
                for(double x = -2; x <= 2; x+=0.2)
                {
                    for(double y = -2; y <= 2; y+=0.2)
                    {
                        expected = RastrignsProvider.CalculateResult(x, y);
                        double[] input = new double[] { x, y };
                        result = GetOutput(input);
                        foreach(double r in result)
                        {
                            output += r;
                        }
                        Console.WriteLine("Expected: " + expected + " Got: " + output);
                        if(output == 0)
                        {
                            output = 1;
                        }
                        error += Math.Abs((output - expected) / output) / 441;
                        output = 0.0;
                        counter++;
                    }
                }
                Console.WriteLine("C" + counter);
                Console.WriteLine("Error: " + error);
                Console.ReadLine();
            } while (error > 0.001 && counter < Max);
                        */
