// See https://aka.ms/new-console-template for more information



Console.WriteLine("\n----------------------------------------------");
Console.WriteLine("\n-                 DynamicML                  -");
Console.WriteLine("\n----------------------------------------------");

Random randomGenerator = new Random();

while (true) {

    float weight1 = randomGenerator.Next(100,101) / 100f;
    float weight2 = randomGenerator.Next(100,101) / 100f;
    float weight3 = randomGenerator.Next(100,101) / 100f;

    //Console.WriteLine(weight1.ToString() + " " + weight2.ToString() + " " + weight3.ToString());
    Neuron neuron = new Neuron(new List<float> { weight1, weight2, weight3 }, .1f);
    neuron.setActivationFunction(ActivationFunction.sigmoid);
    float output = neuron.computeOuput(new List<float> { 1f,1f, 1f });

    Console.WriteLine(output);

}