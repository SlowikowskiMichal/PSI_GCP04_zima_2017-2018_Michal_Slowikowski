using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen4ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Map m = new Map(0.01, 9, 1000, 2);
            m.Learn();
  //          m.Test(DataProvider.input);
  //          m.PrintMap(DataProvider.input);
            m.Test(DataProvider.testInput);
            m.PrintMap(DataProvider.testInput);
            Console.ReadLine();
        }
    }
}
