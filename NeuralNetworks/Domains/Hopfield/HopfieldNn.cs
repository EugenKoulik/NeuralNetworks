using System;
using System.Collections.Generic;
using System.Linq;
using NeuralNetworks.Common.Utils;

namespace NeuralNetworks.Domains.Hopfield;
public class HopfieldNn
{
    private List<double[,]> _patterns;
    private int _n;
    private double[,] Weights { get; set; }
    public int N 
    { 
        get => _n;

        private set 
        {
            _n = value;
            Weights = new double[_n, _n];
        } 
    }
    public HopfieldNn(int n) => N = n;
    
    public void BuildMatrixWeights(List<double[,]> patterns)
    {
        _patterns = patterns;

        foreach (var t in patterns)
        {
            Weights = Matrix.Add(Weights
                , Matrix.Multiply(t, Matrix.Transpose(t)));
        }

        for(var i = 0; i < N; i++)
        {
            Weights[i, i] = 0;
        }
    }
    
    public double[,] FindSample(double[,] defective)
    {
        double[,] temp;
        var viewed = new List<double[,]>();

        while (true)
        {
            temp = Sign(Matrix.Multiply(Weights, defective));

            if (_patterns.Any(s => Matrix.Equals(s, temp)))
            {
                return temp;
            }

            if (viewed.Any(v => Matrix.Equals(v, temp)))
            {
                throw new ArgumentException("Couldn't find a sample!");
            }

            defective = temp;

            var t = new double[temp.GetLength(0), temp.GetLength(1)];
            Array.Copy(temp, t, temp.Length);
            viewed.Add(t);
        }
    }
    private double[,] Sign(double[,] matrix)
    {
        var result = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (var i = 0; i < result.GetLength(0); i++)
        {
            for (var j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = matrix[i, j] >= 0 ? 1 : -1;
            }
        }
        return result;
    }
}