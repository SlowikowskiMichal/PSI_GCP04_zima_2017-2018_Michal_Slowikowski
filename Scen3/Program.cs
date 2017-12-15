using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool supervisedLearning = true;
            double learningRate = 0.1;
            double decay = 0.5;
            int numberOfNeurons = 4;
            HebbTrainer trainer = new HebbTrainer(numberOfNeurons, learningRate, decay, supervisedLearning);
            if (trainer.Train())
            {
                Console.WriteLine("Testowanie nauki na danych do nauki");
                trainer.Test(DataProvider.Data, 4);
                Console.WriteLine("Testowanie nauki na danych zaszumionych");
                trainer.Test(DataProvider.TestData, 12);
            }

            Console.ReadLine();
        }
    }
}
