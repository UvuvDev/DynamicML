// See https://aka.ms/new-console-template for more information


float relu(float input) {
    return Math.Max(0, input);
}

Console.WriteLine("\n----------------------------------------------");
Console.WriteLine("\n-                 DynamicML                  -");
Console.WriteLine("\n----------------------------------------------");


Random randomGenerator = new Random();
while (true) {

    float weight1 = randomGenerator.Next(0,101) / 100f;
    float weight2 = randomGenerator.Next(0,101) / 100f;
    float weight3 = randomGenerator.Next(0,10) / 100f;

    //Console.WriteLine(weight1.ToString() + " " + weight2.ToString() + " " + weight3.ToString());
    Neuron neuron = new Neuron(new List<float> { weight1, weight2, weight3 }, .1f);
    neuron.setActivationFunction(relu);
    float output = neuron.computeOuput(new List<float> { .1f,.2f, 4f });

    Console.WriteLine(output);

}