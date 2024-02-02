
using System.Numerics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;


public class Network {

    private Neuron[,] neuronLayers;

    public Network(Neuron[,] neuronLayers) {
        this.neuronLayers = neuronLayers;
    }

    public float computeOuput(List<float> inputs) {

        List<float> outputs = new List<float>();
        for (int i = 0; i > neuronLayers.GetLength(0); i++) {
        }
        return neuronLayers[0,2].computeOuput(inputs);
        
    }
}