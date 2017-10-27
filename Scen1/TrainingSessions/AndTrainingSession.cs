namespace Scen1.TrainingSessions
{
    class AndTrainingSession : TrainingSession
    {
        protected override int[] expectedOutput
        {
            get { return new int[] { 0, 0, 0, 1 }; }
        }
    }
}
