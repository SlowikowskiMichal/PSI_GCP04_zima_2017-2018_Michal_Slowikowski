using Scen1.TrainingSeasions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen1
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("./log.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open log.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }

            Console.SetOut(writer);
            TrainingSession[] sessions = new TrainingSession[] {
                new AndTrainingSession(),
                new AndTrainingSession00X1(),
                new AndTrainingSession0XX1(),
                new OrTrainingSession(),
                new OrTrainingSession0X11(),
                new OrTrainingSessionX111(),
                new XORTrainingSession()
            };
            foreach (TrainingSession session in sessions)
            {
                Console.WriteLine("New session: " + session.GetType());
                for (double i = 0.000001; i < 10000.0; i *= 10)
                {
                    session.run(i);
                }
            }
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
        }
    }
}