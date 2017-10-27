namespace Scen1.TrainingSessions
{
    class TrainingSessionWithIncompleteInput : TrainingSession
    {
        protected virtual int[][] inputDataFull
        {
            get
            {
                return
                    new int[][]{
                    new int[2] { 0, 0 },
                    new int[2] { 0, 1 },
                    new int[2] { 1, 0 },
                    new int[2] { 1, 1 }
                    };
            }
        }
        protected virtual int[] expectedOutputFull
        {
            get { return new int[] { 0, 1, 1, 1 }; }
        }

        protected override bool checkIfPerceptronReturnsExpectedOutput(Perceptron perceptron)
        {
            bool result = true;
            for (int i = 0; i < expectedOutputFull.Length; i++)
            {
                result &= perceptron.getResult(inputDataFull[i]).Equals(expectedOutputFull[i]);
            }
            return result;
        }
    }
}
