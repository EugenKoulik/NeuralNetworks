using NeuralNetworks.GeneticAlgorithm.Contracts;
using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using NeuralNetworks.GeneticAlgorithm.MathParsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.GeneticAlgorithm.Selection
{
    public class SimpleSelection : ISelection
    {
        public List<Chromosome> Select(List<Chromosome> population, MathParser parser, int numberSurvived) => population
                .OrderBy(chromosome => parser.Calculate(chromosome.Gens))
                .Take(numberSurvived)
                .ToList();
    }
}
