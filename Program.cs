// See https://aka.ms/new-console-template for more information



Console.WriteLine("\n----------------------------------------------");
Console.WriteLine("\n-                 DynamicML                  -");
Console.WriteLine("\n----------------------------------------------");

Random randomGenerator = new Random();

while (true) {

    List<List<float>> weights = new List<List<float>> { new List<float> { (float)randomGenerator.NextDouble(), (float)randomGenerator.NextDouble(), (float)randomGenerator.NextDouble() },
                          new List<float> { (float)randomGenerator.NextDouble(), (float)randomGenerator.NextDouble(), (float)randomGenerator.NextDouble() },
                          new List<float> { (float)randomGenerator.NextDouble(), (float)randomGenerator.NextDouble(), (float)randomGenerator.NextDouble() },
                          new List<float> { (float)randomGenerator.NextDouble(), (float)randomGenerator.NextDouble(), (float)randomGenerator.NextDouble() } };
                          

    List<List<Neuron>> neurons = new List<List<Neuron>> { };
    
    Console.WriteLine("Weight Length " + weights.Count);
    
    for (int i = 0; i < weights.Count; i++) {
        neurons.Add(new List<Neuron> { });
        Console.WriteLine("Creating layer... I: " + i);
        for (int j = 0; j < weights[i].Count; j++) {
            Console.WriteLine("Creating neuron... I: " + i + " J: " + j);
            neurons[i].Add(new Neuron(ref randomGenerator, new List<Neuron>(), 1f));
            neurons[i][j].setActivationFunction(ActivationFunction.sigmoid);
        }
    }
    
    Network network = new Network(neurons);
    Console.WriteLine("Network created ", network);
    List<float> inputs = new List<float> { 1f, 0f, .5f };

    float output = network.computeOuput(inputs);

    Console.WriteLine(output);

    SpinWait.SpinUntil(() => false, 1000);
}