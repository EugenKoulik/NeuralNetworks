using System;
using System.Collections.Generic;
using System.Linq;
using NeuralNetworks.Domains.Hopfield;

namespace NeuralNetworks.Controllers;
public class HopfieldNnController
{
    private readonly HopfieldNn _network;

    public HopfieldNnController(int size)
    {
        _network = new HopfieldNn(size);
    }

    /// <summary>
    /// Find pattern
    /// </summary>
    /// <param name="defective">Defective vector</param>
    /// <param name="patterns">Standards</param>
    /// <returns>Standard</returns>
    /// <exception cref="ArgumentException">Standard not found</exception>
    public bool[,] Find(bool[,] defective, List<bool[,]> patterns)
    {
        var patternsVector = patterns.Select(ConvertToVector).ToList();
        var defectiveVector = ConvertToVector(defective); 

        _network.BuildMatrixWeights(patternsVector);

        try
        {
            var findPattern = _network.FindSample(defectiveVector);

            return ConvertToGrid(findPattern, defective.GetLength(1));
        }
        catch (ArgumentException e)
        {
            throw new ArgumentException(e.Message);
        }
    }
    
    private double[,] ConvertToVector(bool[,] arr)
    {
        var converted = new double[_network.N, 1];

        var k = 0;

        for (var i = 0; i < arr.GetLength(0); i++)
        {
            for (var j = 0; j < arr.GetLength(1); j++)
            {
                converted[k, 0] = arr[i, j] ? 1 : -1;
                k++;
            }
        }
        return converted;
    } 

    private static bool[,] ConvertToGrid(double[,] vector, int columnNumber)
    {
        var rowNumber = vector.Length / columnNumber;
        var converted = new bool[rowNumber, columnNumber];
        var k = 0;

        for (var i = 0; i < rowNumber; i++)
        {
            for (var j = 0; j < columnNumber; j++)
            {
                converted[i, j] = vector[k, 0] > 0;
                k++;
            }
        }
        return converted;
    }
}