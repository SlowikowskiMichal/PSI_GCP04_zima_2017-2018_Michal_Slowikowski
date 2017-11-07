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
            int[] result = Letters.getLetter(1,2);

            Console.WriteLine(result[0] + "|" + result[1] + "|" + result[2] + "\n" + 
                              result[3] + "|" + result[4] + "|" + result[5]);
            Console.ReadLine();
        }
    }
}
