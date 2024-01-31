
using System.Numerics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;


public class Network {

    private Neuron[,] neuronLayers;

    public Network(Neuron[,] neuronLayers) {
        this.neuronLayers = neuronLayers;
    }

    public float computeOuput() {

        List<float> inputs = new List<float>();
        return neuronLayers[0,2].computeOuput(inputs);
        
    }
}