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
    public class BreedingSelection : ISelection
    {
        private BreedingType _breedingType;
        public BreedingSelection(BreedingType breedingType)
        {
            _breedingType = breedingType;
        }

        public List<Chromosome> Select(List<Chromosome> population, MathParser parser, int numberSurvived)
        {
            Random random = new Random();

            population = population.OrderBy(chromosome => parser.Calculate(chromosome.Gens)).ToList();

            Chromosome averageChromosome = population[population.Count / 2];

            List<Chromosome> result = new List<Chromosome>();

            switch (_breedingType)
            {
                case BreedingType.Inbreeding:
                    result = population
                        .OrderBy(chromosome => HammingDistance(chromosome, averageChromosome))
                        .ToList();
                    break;
                case BreedingType.Outbreeding:
                    result = population
                        .OrderByDescending
                        (chromosome => HammingDistance(chromosome, averageChromosome))
                        .ToList();
                    break;
                default:
                    break;
            }

            return result.Take(numberSurvived).ToList();
        }
        private int HammingDistance(Chromosome chromosome1, Chromosome chromosome2)
        {
            int result = 0;

            var chromosome1Bits = chromosome1.ToBits();

            var chromosome2Bits = chromosome2.ToBits();

            for (int i = 0; i < chromosome1Bits.Length; i++)
            {
                result += chromosome1Bits[i] ^ chromosome2Bits[i] ? 1 : 0;
            }

            return result;
        }
    }

    public enum BreedingType
    {
        Inbreeding,
        Outbreeding
    }
}
