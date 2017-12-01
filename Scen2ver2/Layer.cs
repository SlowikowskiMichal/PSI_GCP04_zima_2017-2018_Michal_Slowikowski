using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2ver2
{
    class Layer
    {
        private Neuron[] neurons;
        private double[] errors;
        private double learningRate;
        public double[] lastOutput;
        public Layer(int numberOfNeurons, int numberOfInputs, double learningRate)
        {
            this.learningRate = learningRate;
            lastOutput = new double[numberOfNeurons];
            neurons = new Neuron[numberOfNeurons];
            errors = new double[numberOfNeurons];
            for(int i = 0; i < numberOfNeurons; i++)
            {
                errors[i] = 0.0;
            }
            Random r = new Random();
            double[] weights = new double[numberOfInputs + 1];

            for (int i = 0; i < numberOfNeurons; i++)
            {
                for (int j = 0; j < weights.Length; j++)
                {
                    weights[j] = r.NextDouble();
                }
                neurons[i] = new Neuron(weights);
            }
        }

        public void PrintLayer()
        {
            for(int i = 0; i < neurons.Length; i++)
            {
                Console.WriteLine("Neuron " + i);
                neurons[i].PrintWeights();
            }
        }

        public double[] CalculateLastError(double[] outputError)
        {
            for (int i = 0; i < errors.Length; i++)
            {
                errors[i] = lastOutput[i]*(1-lastOutput[i])*outputError[i];
            }
            return errors;
        }
        public double[] CalculateError(double[] errorsFromNexLayer, Layer nextLayer)
        {
            for(int i = 0; i < errors.Length; i++)
            {
                errors[i] = 0.0;
                for(int j = 0; j < errorsFromNexLayer.Length; j++)
                {
                    errors[i] = errorsFromNexLayer[j] * nextLayer.GetWeights(i)[j];
                }

                errors[i] *= lastOutput[i]*(1-lastOutput[i]);
            }
            return errors;
        }
        public double[] CalculateOutput(double[] input)
        {
            double[] result = new double[neurons.Length];
            for(int i = 0; i < neurons.Length; i++)
            {
                result[i] = neurons[i].GetResult(input);
            }
            Array.Copy(result, lastOutput, lastOutput.Length);
            return result;
        }

        public double[] GetWeights(int neuronNumber)
        {
            double[] weights = new double[neurons.Length];
            for(int i = 0; i < weights.Length; i++)
            {
                weights[i] = neurons[i].GetWeight(neuronNumber);
            }

            return weights;
        }
        public void CalculateNewWeights(double[] input)
        {
            for(int i = 0; i < neurons.Length; i++)
            {
                neurons[i].Learn(input, errors[i], learningRate);
            }
            input = lastOutput;
        }
    }
}
