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
            int[] structure = new int[] { 3, 25, 15, 10, 5, 3, 1 };
            Trainer t = new Trainer(structure, 0.1f, 100000);
            t.Learn();
            t.Test();
            Console.ReadLine();
        }

    }
}
