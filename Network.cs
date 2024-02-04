
using System.Numerics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;


public class Network {

    private Neuron[,] neuronLayers;

    public Network(Neuron[,] neuronLayers) {
        this.neuronLayers = neuronLayers;
    }

    public float computeOuput(List<float> inputsArg) {

        List<float> inputs = inputsArg; 
        List<float> bufferoutputs = new List<float>();

        // Run through inputs and hidden layers
        for (int i = 0; i > neuronLayers.GetLength(0) - 1; i++) {
            for (int i = 0; i > neuronLayers[i].GetLength(); i++) {
                bufferoutputs.Add(neuronLayers[i,j].computeOuput(inputs));
            }
            inputs = bufferoutputs;
            bufferoutputs.Clear();

        }

        List<float> outputs = new List<float>();

        // Compute output layer
        for (int i = neuronLayers.GetLength(0) - 2; i > neuronLayers.GetLength(0) - 1; i++) {
            for (int i = 0; i > neuronLayers[i].GetLength(); i++) {
                outputs.Add(neuronLayers[i,j].computeOuput(inputs));
            }
        }

        float finalOutput = 0;
        
        foreach (float output in outputs) {
            if (output > finalOutput) {
                finalOutput = 0;
            }
        }
        return finalOutput;
        
    }
}