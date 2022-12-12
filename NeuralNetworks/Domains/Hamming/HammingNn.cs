using System.Collections.Generic;
using NeuralNetworks.Common.Utils;

namespace NeuralNetworks.Domains.Hamming;

public class HammingNn
{
    private readonly LayerA _layerA;
    private readonly LayerY _layerY;
    private readonly LayerZ _layerZ;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="epsilon"></param>
    /// <param name="countOfSignals"></param>
    /// <param name="samples"></param>
    public HammingNn(double epsilon, int countOfSignals, IReadOnlyList<Matrix> samples)
    {
        _layerA = new LayerA(epsilon);
        _layerY = new LayerY();
        _layerZ = new LayerZ(epsilon, countOfSignals, samples);
    }

    public List<int> GetIndexes(Matrix inputSignal)
    {
        var input = new Matrix(inputSignal);
        var zInput =  _layerZ.GetInputSignal(input);

        var indexes = GetMaxIndexes(zInput);
        
        if (indexes.Count > 1)
            return indexes;

        var zOutput = _layerZ.GetOutputSignal(zInput);
        var aInput = new Matrix(zOutput);
        
        indexes = GetMaxIndexes(aInput);
        
        if (indexes.Count == 1)
        {
            return indexes;
        }

        indexes = new List<int>();

        var aOutput = _layerA.GetOutputSignal(zOutput);
        var yOutput = _layerY.GetOutputSignal(aOutput);

        for (var i = 0; i < yOutput.N; i++)
        {
            if (yOutput[0, i] == 1)
            {
                indexes.Add(i);
            }
        }

        return indexes;
    }

    private List<int> GetMaxIndexes(Matrix array)
    {
        var indexes = new List<int>();

        if (array.N <= 0)
        {
            return indexes;
        }
        
        var maxValue = Matrix.FindMax(array);

        for (var i = 0; i < array.N; i++)
        {
            if (maxValue == array[0, i]) 
            {
                indexes.Add(i);
            }
        }

        return indexes;
    }
}