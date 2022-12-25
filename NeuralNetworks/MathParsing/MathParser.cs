using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.GeneticAlgorithm.MathParsing
{
    public class MathParser
    {
        private Function _func = new("");

        public int ArgumentsNumber => _func.getArgumentsNumber();

        public void InitializeExpression(string expression)
        {
            _func = new Function(expression);
        }
           

        public double Calculate(params double[] parametres)
        {
            if (parametres.Length != _func.getArgumentsNumber())
            {
                throw new ArgumentException("Number of parameters does not match");
            }

            double result = _func.calculate(parametres);

            if (Double.IsNaN(result))
            {
                throw new ArgumentException("Invalid function");
            }

            return result;
        }

        public string ArgumentName(int index) => _func.getParameterName(index);
    }
}
