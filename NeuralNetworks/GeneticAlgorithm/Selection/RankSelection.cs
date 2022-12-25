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
    public class RankSelection : ISelection
    {
        public List<Chromosome> Select(List<Chromosome> population, MathParser parser, int numberSurvived)
        {
            double averageFunctionValue = population.Average(chromosome => parser.Calculate(chromosome.Gens));

            var result = population.Where(chromosome => parser.Calculate(chromosome.Gens) >= averageFunctionValue).ToList();

            return result;
        }
    }
}
