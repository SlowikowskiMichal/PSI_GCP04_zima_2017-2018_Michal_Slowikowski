using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] result = Letters.GetLetter(1,2);

            double[] weights = new double[7];
            Random r = new Random();


            char[] litery = new char[] { 'A', 'C', 'F', 'G', 'I', 'N', 'O', 'R', 'S', 'Z' };
            double wynik;

            Layer single = new Layer(6, 7);
            single.Learn();

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    wynik = single.GetResult(Letters.GetLetter(i, j));
                    if ((wynik == 1 && i < 1) || (wynik == 0 && i == 1))
                    {
                        Console.WriteLine(litery[j] + " Sukces! " + wynik);
                    }
                    else
                    {
                        Console.WriteLine(litery[j] + " Blad! " + wynik);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
