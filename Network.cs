
using System.Numerics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;


public class Network {

    protected List<List<Neuron>> neuronLayers;

    public Network(List<List<Neuron>> neuronLayers) {
        this.neuronLayers = neuronLayers;
    }

    public float computeOuput(List<float> inputsArg) {

        List<float> inputs = inputsArg.ToList(); 
        Console.WriteLine("Inputs RAH: ");
        List<float> bufferoutputs = new List<float>();

        foreach (float input in inputs) {
            Console.WriteLine(input);
        }
        
        for (int i = 0; i < neuronLayers.Count; i++) {

            bufferoutputs.Clear();
            
            for (int j = 0; j < neuronLayers[i].Count; j++) {
                float neuronOutput = neuronLayers[i][j].computeOutput(inputs);
                Console.WriteLine("Neuron Output: " + neuronOutput, "Inputs Count: " + inputs.Count);
                bufferoutputs.Add(neuronOutput);
            }
            
            inputs = bufferoutputs;
            
        }

        return inputs.Max();
        
    }
}