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
            Map m = new Map(0.6);
            m.PrintMap();
            m.Learn();
            m.PrintMap();
            m.Test();
            Console.ReadLine();
        }
    }
}
