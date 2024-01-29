
using System.Diagnostics.Metrics;
using System.Numerics;

public class Neuron {
    protected Vector<float> weights;
    protected float bias;

    public Neuron(Vector<float> weights) {
        this.weights = weights;
    }
    public float computeOuput() {

        return 0;
    }

    public void updateWeights(Vector<float> weights) {
        this.weights = weights;
    }

    public float runActivationFunction() {
        return 0;
    }

    public float summation() {
        return 0;
    }


}