using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen4ver1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine("START");
            Map m = new Map(0.1, 4, 1000);      //stworzenie mapy (learning rate, liczba neuronów, liczba cykli)
            m.Learn();                          //nauczanie
            m.Test(DataProvider.testInput);     //testowanie
            m.PrintMap(DataProvider.testInput); //wyświetlanie mapy dając dane testowe
            Console.ReadLine();
        }
    }
}
