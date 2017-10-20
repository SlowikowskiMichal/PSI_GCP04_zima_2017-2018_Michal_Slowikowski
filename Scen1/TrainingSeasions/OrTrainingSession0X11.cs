using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen1.TrainingSeasions
{
    class OrTrainingSession0X11 : TrainingSession
    {
        protected override int[][] inputData
        {
            get
            {
                return
                  new int[][]{
                        new int[2] { 0, 0 },
                        new int[2] { 1, 0 },
                        new int[2] { 1, 1 }
                  };
            }
        }
        protected override int[] expectedOutput
        {
            get { return new int[] { 0, 1, 1 }; }
        }
    }
}
