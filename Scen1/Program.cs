using Scen1.TrainingSessions;
using System;
using System.IO;

namespace Scen1
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;

            TrainingSession[] sessions = new TrainingSession[] {
                new AndTrainingSession(),
                new AndTrainingSession00X1(),
                new AndTrainingSession0XX1(),
                new OrTrainingSession(),
                new OrTrainingSession0X11(),
                new OrTrainingSessionX111(),
            };
            foreach (TrainingSession session in sessions)
            {
                try
                {
                    ostrm = new FileStream(session.GetType() + "Log.txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(ostrm);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Cannot open " + session.GetType() + "Log.txt for writing");
                    Console.WriteLine(e.Message);
                    return;
                }
                Console.SetOut(writer);


                for (double i = 0.000001; i <= 1000.0; i *= 10)
                {
                    session.run(i);
  //                  Console.WriteLine("Learning Rate: " + i);
  //                  Console.WriteLine("---------------------------------------------------");
                }

                writer.Close();
                ostrm.Close();
            }
            Console.SetOut(oldOut);

            TrainingSession xor = new XORTrainingSession();
            double xorLearningRate = 0.1;
            try
            {
                ostrm = new FileStream(xor.GetType() + "Log.txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open " + xor.GetType() + "Log.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            xor.run(xorLearningRate);
    //        Console.WriteLine("Learning Rate: " + xorLearningRate);
    //        Console.WriteLine("---------------------------------------------------");
            writer.Close();
            ostrm.Close();
        }
    }
}