
public class ActivationFunction {
    public static float sigmoid (float input) {
        return (float)(1 / ( 1 + Math.Pow(Math.E, -input) ));
    }

    public static float relu(float input) {
        return Math.Max(0, input);
    }
}