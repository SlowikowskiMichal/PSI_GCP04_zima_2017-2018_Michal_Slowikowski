namespace Scen1
{
    class Perceptron
    {
        private double[] weights;
        private double bias = 1;
        private double treshold = 0;

        public Perceptron(double[] weights)
        {
            this.weights = weights;
        }
        public double[] getWeights()
        {
            return weights;
        }
        public void setWeights(double[] weights)
        {
            this.weights = weights;
        }
        public int getResult(int[] input)
        {
            double sum = inputSummary(input);
            return perceptronActivation(sum);
        }
        public double inputSummary(int[] input)
        {
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += weights[i] * input[i];
            }

            return sum + weights[input.Length] * bias;
        }
        private int perceptronActivation(double sum)
        {
            int active = 1;
            int inactive = 0;

            if (sum >= treshold)
            {
                return active;
            }
            else
            {
                return inactive;
            }
        }
    }
}