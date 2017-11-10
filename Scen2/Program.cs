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
            Console.WriteLine("Number of Width Fields: " + Letters.NumberOfFieldsX + " Number of Height Fields: " + Letters.NumberOfFieldsY);

            Console.WriteLine("-------------------------Perceptron----------------------");
            PercetronTrainer trainer = new PercetronTrainer(Letters.NumberOfFields, 0.1);
            trainer.Train();
            trainer.Test(Letters.LettersData);
            trainer.Test(Letters.CorruptedLettersData);

            Console.WriteLine("-------------------------Adaline----------------------");
            AdalineTrainer trainerA = new AdalineTrainer(Letters.NumberOfFields, 0.1);
            trainerA.Train();
            trainerA.Test(Letters.LettersData);
            trainerA.Test(Letters.CorruptedLettersData);

            Console.ReadLine();
        }
    }
}
