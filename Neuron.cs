
using System.Diagnostics.Metrics;
using System.Numerics;

public class Neuron {
    protected Vector<float> weights;
    protected float bias;

    public Neuron(Vector<float> weights, float bias = 1) {
        this.weights = weights;
    }
    public float computeOuput(Vector<float> inputs) {

        return 0;
    }

    public void updateWeights(Vector<float> weights) {
        this.weights = weights;
    }

    public float runActivationFunction(Func<float, float> activationFunction) {
        
        float sum = this.summation();
        
        return activationFunction(sum);
    }

    public float summation() {
        return 0;
    }


}