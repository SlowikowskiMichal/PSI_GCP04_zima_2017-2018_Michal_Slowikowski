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
            int[,] struktura = new int[2, 2] { { 2, 2 }, { 1, 2 }};

            /*Console.WriteLine("Wygląd struktury: ");
            for(int i = 0; i < struktura.GetLength(0); i++)
            {
                Console.WriteLine("Warstwa nr: " + i + " neurony: " + struktura[i, 0] + " input: " + struktura[i, 1]);
            }*/
            double[] input = new double[2] { 1, 1 };
            Trainer t = new Trainer(struktura);
           // t.PrintNeuralNetwork();
            t.Learn(0.1);
            t.Test();

            Console.ReadLine();
        }
    }
}
