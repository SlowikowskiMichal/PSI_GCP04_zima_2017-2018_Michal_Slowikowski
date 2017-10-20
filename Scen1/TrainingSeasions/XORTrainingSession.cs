using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen1.TrainingSeasions
{
    class XORTrainingSession : TrainingSession
    {
        protected override int[] expectedOutput
        {
            get { return new int[] { 0, 1, 1, 0 }; }
        }
    }
}
