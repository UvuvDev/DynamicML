
using System.Numerics;
using System.Collections.Generic;
using System.ComponentModel;

public class Network {

    private Neuron[,] neuronLayers;

    public Network(Neuron[,] neuronLayers) {
        this.neuronLayers = neuronLayers;
    }

    public float computeOuput() {
        return neuronLayers[0,2].computeOuput((float) => {return (0,0);}
        );
    }
}