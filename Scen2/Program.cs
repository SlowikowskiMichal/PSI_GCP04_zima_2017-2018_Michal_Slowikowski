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
            double learningRate = 0.001;

            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;

            try
            {
                ostrm = new FileStream("X" + Letters.NumberOfFieldsX +"Y" + Letters.NumberOfFieldsY + "_" + learningRate + "Log.txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open " + Letters.NumberOfFieldsX + Letters.NumberOfFieldsY + "_" + learningRate + "Log.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            Console.WriteLine("Number of Width Fields: " + Letters.NumberOfFieldsX + " Number of Height Fields: " + Letters.NumberOfFieldsY);

            Console.WriteLine("-------------------------Perceptron----------------------");
            PercetronTrainer trainer = new PercetronTrainer(Letters.NumberOfFields, learningRate);
            trainer.Train();
            trainer.Test(Letters.LettersData);
            trainer.Test(Letters.CorruptedLettersData);

            Console.WriteLine("-------------------------Adaline----------------------");
            AdalineTrainer trainerA = new AdalineTrainer(Letters.NumberOfFields, learningRate);
            trainerA.Train();
            trainerA.Test(Letters.LettersData);
            trainerA.Test(Letters.CorruptedLettersData);

            writer.Close();
            ostrm.Close();
        }
    }
}
