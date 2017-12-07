using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] struktura = new int[3, 2] { { 10, 2 }, { 3,10}, { 1, 3 } };
            double learningRate = 1;
            /*Console.WriteLine("Wygląd struktury: ");
            for(int i = 0; i < struktura.GetLength(0); i++)
            {
                Console.WriteLine("Warstwa nr: " + i + " neurony: " + struktura[i, 0] + " input: " + struktura[i, 1]);
            }
            double[] input = new double[2] { 1, 2 };
                 Trainer t = new Trainer(struktura, learningRate);
                 t.PrintNeuralNetwork();
                 t.Learn();
                 t.Test();*/
                 //Test
            int[,] xorStruktura = new int[2, 2] { { 2, 2 }, { 1, 2 }};
            XORTrainer tx = new XORTrainer(xorStruktura, learningRate);
            
            
            tx.Learn();
            tx.Test();

           // Console.WriteLine(t.GetOutput(input));

            Console.ReadLine();
        }
        
    }
}
