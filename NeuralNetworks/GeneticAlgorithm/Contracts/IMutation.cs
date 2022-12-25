using NeuralNetworks.GeneticAlgorithm.MainAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.GeneticAlgorithm.Contracts
{
    public interface IMutation
    {
        void Mutate(List<Chromosome> population);
    }
}
