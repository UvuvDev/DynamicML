
using System.Numerics;

public class Network<N> where N : struct {

    protected Vector<Vector<N>> neuronLayers;

    public Network(Vector<Vector<N>> neuronLayers) {
        this.neuronLayers = neuronLayers;
    }
}