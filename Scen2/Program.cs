using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2
{
    class Program
    {
        static void Main(string[] args)
        {
            double learningRate = 0.01;


            Console.WriteLine("Number of Width Fields: " + Letters.NumberOfFieldsX + " Number of Height Fields: " + Letters.NumberOfFieldsY);

            Console.WriteLine("-------------------------Perceptron----------------------");
 /*           PercetronTrainer trainer = new PercetronTrainer(2, learningRate);
            trainer.Train();
            Console.WriteLine("Testowanie nauki na danych poprawnych");
            trainer.Test(Letters.LettersData);
            Console.WriteLine("Testowanie nauki na danych zaszumionych");
            trainer.Test(Letters.CorruptedLettersData);
            Console.ReadLine();
            */
            AdalineTrainer aTrainer = new AdalineTrainer(learningRate);
            aTrainer.Train();
            aTrainer.Test(Letters.LettersData);
            aTrainer.Test(Letters.CorruptedLettersData);
            Console.ReadLine();
        }
    }
}
