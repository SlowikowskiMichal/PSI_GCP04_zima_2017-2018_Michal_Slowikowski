namespace Scen1.TrainingSessions
{
    class OrTrainingSession : TrainingSession
    {
        protected override int[] expectedOutput
        {
            get { return new int[] { 0, 1, 1, 1 }; }
        }
    }
}
