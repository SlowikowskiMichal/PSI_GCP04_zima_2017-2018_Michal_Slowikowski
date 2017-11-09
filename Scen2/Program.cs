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
            PercetronTrainer trainer = new PercetronTrainer(6, 0.01);
            trainer.Train();
        }
    }
}
