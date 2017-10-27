namespace Scen1.TrainingSessions
{
    class XORTrainingSession : TrainingSession
    {
        protected override int[] expectedOutput
        {
            get { return new int[] { 0, 1, 1, 0 }; }
        }
    }
}

