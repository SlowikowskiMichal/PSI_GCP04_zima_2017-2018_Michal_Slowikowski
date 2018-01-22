using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2ver2
{
    public class Layer
    {
        int numberOfInputs;
        int numberOfOuputs;


        public float[] outputs;
        public float[] inputs;
        public float[,] weights;
        public float[,] weightsDelta;
        public float[] gamma;
        public float[] error;

        public static Random random = new Random();

        public Layer(int numberOfInputs, int numberOfOuputs)
        {
            this.numberOfInputs = numberOfInputs;
            this.numberOfOuputs = numberOfOuputs;

            outputs = new float[numberOfOuputs];
            inputs = new float[numberOfInputs];
            weights = new float[numberOfOuputs, numberOfInputs];
            weightsDelta = new float[numberOfOuputs, numberOfInputs];
            gamma = new float[numberOfOuputs];
            error = new float[numberOfOuputs];

            InitilizeWeights();
        }

        public void InitilizeWeights()
        {
            for (int i = 0; i < numberOfOuputs; i++)
            {
                for (int j = 0; j < numberOfInputs; j++)
                {
                    weights[i, j] = (float)random.NextDouble() - 0.5f;
                }
            }
        }

        public float[] FeedForward(float[] inputs)
        {
            this.inputs = inputs;

            for (int i = 0; i < numberOfOuputs; i++)
            {
                outputs[i] = 0;
                for (int j = 0; j < numberOfInputs; j++)
                {
                    outputs[i] += inputs[j] * weights[i, j];
                }

                outputs[i] = (float)Math.Tanh(outputs[i]);
            }

            return outputs;
        }

        public float TanHDer(float value)
        {
            return 1 - (value * value);
        }

        public void BackPropOutput(float[] expected)
        {
            for (int i = 0; i < numberOfOuputs; i++)
                error[i] = outputs[i] - expected[i];

            for (int i = 0; i < numberOfOuputs; i++)
                gamma[i] = error[i] * TanHDer(outputs[i]);

            for (int i = 0; i < numberOfOuputs; i++)
            {
                for (int j = 0; j < numberOfInputs; j++)
                {
                    weightsDelta[i, j] = gamma[i] * inputs[j];
                }
            }
        }

        public void BackPropHidden(float[] gammaForward, float[,] weightsFoward)
        {
            for (int i = 0; i < numberOfOuputs; i++)
            {
                gamma[i] = 0;

                for (int j = 0; j < gammaForward.Length; j++)
                {
                    gamma[i] += gammaForward[j] * weightsFoward[j, i];
                }

                gamma[i] *= TanHDer(outputs[i]);
            }

            for (int i = 0; i < numberOfOuputs; i++)
            {
                for (int j = 0; j < numberOfInputs; j++)
                {
                    weightsDelta[i, j] = gamma[i] * inputs[j];
                }
            }
        }

        public void UpdateWeights(float learningRate)
        {
            for (int i = 0; i < numberOfOuputs; i++)
            {
                for (int j = 0; j < numberOfInputs; j++)
                {
                    weights[i, j] -= weightsDelta[i, j] * learningRate;
                }
            }
        }

        public void PrintLayer()
        {
            for(int i = 0; i < numberOfInputs; i ++)
            {
                for(int j = 0; j < numberOfOuputs; j++)
                {
                    Console.WriteLine(weights[i, j]);
                }
            }
        }
    }
}
