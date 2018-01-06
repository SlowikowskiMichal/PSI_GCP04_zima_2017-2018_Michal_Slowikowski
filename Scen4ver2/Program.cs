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
            Map m = new Map(0.9, 20, 500);
            m.PrintMap();
            m.Learn();
            m.PrintMap();
            m.Test(DataProvider.testInput);
            Console.ReadLine();
            m.Test(DataProvider.input);
            Console.ReadLine();
        }
    }
}
