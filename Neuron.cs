
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

public class Neuron {
    protected List<float> weights;
    protected List<Neuron> neurons;

    Func<float, float> activationFunction;
    protected float bias;

    public Neuron(ref Random randomGenerator, List<Neuron> connections, float bias = 1) {
        this.weights = new List<float> { (float)randomGenerator.NextDouble(), (float)randomGenerator.NextDouble(), (float)randomGenerator.NextDouble() };
        this.neurons = connections;
        this.activationFunction = ActivationFunction.sigmoid;
    }
    public float computeOutput(List<float> inputs) {
        return activationFunction(summation(inputs)) + bias;
    }

    public void updateWeights(List<float> weights) {
        this.weights = weights;
    }

    public void setActivationFunction(Func<float, float> activationFunction) {
        this.activationFunction = activationFunction;
        
    }

    protected float summation(List<float> inputs) {

        // Misinput Handling
        if (weights.Count < 1) {
            if (inputs.Count < 1) {
                throw new ArgumentException("Neither weights nor inputs are populated.");
            }
            else {
                throw new ArgumentException("Weights are not populated.");
            }
        }
        if (weights.Count != inputs.Count) {
            Console.WriteLine("Weights: " + weights.Count + " Inputs: " + inputs.Count);
            throw new ArgumentException("The number of weights/connections must be equal to the number of inputs.");
        }

        // Actual calculation
        float sum = 0;

        for (int i = 0; i < weights.Count; i++) {
            sum += weights[i] * inputs[i];
        } 
        
        return sum;
    }


}