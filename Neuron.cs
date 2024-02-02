
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

public class Neuron {
    protected List<float> weights;

    Func<float, float> activationFunction;
    protected float bias;

    public Neuron(List<float> weights, float bias = 1) {
        this.weights = weights;
        this.activationFunction = ActivationFunction.sigmoid;
    }
    public float computeOuput(List<float> inputs) {
        return activationFunction(summation(inputs));
    }

    public void updateWeights(List<float> weights) {
        this.weights = weights;
    }

    public void setActivationFunction(Func<float, float> activationFunction) {
        this.activationFunction = activationFunction;
        
    }

    protected float summation(List<float> inputs) {

        if (weights.Count < 1) {
            throw new ArgumentException("The number of weights must not be less than 1.");
        }
        if (weights.Count != inputs.Count) {
            throw new ArgumentException("The number of weights must be equal to the number of inputs.");
        }

        float sum = 0;

        for (int i = 0; i < weights.Count; i++) {
            sum += weights[i] * inputs[i];
        }

        sum += bias;

        //Console.WriteLine(sum.ToString());

        return sum;
    }


}