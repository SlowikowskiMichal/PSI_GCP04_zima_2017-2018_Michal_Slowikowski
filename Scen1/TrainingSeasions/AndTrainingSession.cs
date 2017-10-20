using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen1
{
    class AndTrainingSession : TrainingSession
    {
        protected override int[] expectedOutput
        {
            get { return new int[] { 0, 0, 0, 1 }; }
        }
    }
}
