using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2ver2
{
    class NeuralNetwork
    {
        Layer[] layers;
        float learningRate;

        public NeuralNetwork(int[] layer, float learningRate)
        {
            this.learningRate = learningRate;

            layers = new Layer[layer.Length - 1];

            for (int i = 0; i < layers.Length; i++)
            {
                layers[i] = new Layer(layer[i], layer[i + 1]);
            }
        }

        public float[] FeedForward(float[] inputs)
        {
            layers[0].FeedForward(inputs);
            for (int i = 1; i < layers.Length; i++)
            {
                layers[i].FeedForward(layers[i - 1].outputs);
            }

            return layers[layers.Length - 1].outputs;
        }

        public void BackProp(float[] expected)
        {
            for (int i = layers.Length - 1; i >= 0; i--)
            {
                if (i == layers.Length - 1)
                {
                    layers[i].BackPropOutput(expected);
                }
                else
                {
                    layers[i].BackPropHidden(layers[i + 1].gamma, layers[i + 1].weights);
                }
            }

            for (int i = 0; i < layers.Length; i++)
            {
                layers[i].UpdateWeights(learningRate);
            }
        }

        public void Print()
        {
            int i = 1;
            foreach (Layer l in layers)
            {
                Console.WriteLine("------------------- Warstwa " + i + " -------------------");
                l.PrintLayer();
                i++;
            }
        }
    }
}
