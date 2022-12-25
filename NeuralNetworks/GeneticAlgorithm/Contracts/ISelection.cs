using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using NeuralNetworks.GeneticAlgorithm.MathParsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.GeneticAlgorithm.Contracts
{
    public interface ISelection
    {
        List<Chromosome> Select(List<Chromosome> population, MathParser parser, int numberSurvived);
    }
}
