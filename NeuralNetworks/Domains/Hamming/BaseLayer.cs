namespace NeuralNetworks.Domains.Hamming;

public class BaseLayer
{
    internal readonly double Epsilon;
    
    protected BaseLayer() { }
    protected BaseLayer(double epsilon)
    {
        Epsilon = epsilon;
    }
}