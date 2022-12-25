using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.GeneticAlgorithm.Contracts
{
    public interface ICrossing
    {
        List<Chromosome> Cross(Chromosome parent1, Chromosome parent2);
    }
}
