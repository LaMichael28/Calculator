using KeyNinja.Calculator.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyNinja.Calculator.Logic
{
    public class StandardCalculator : ICalculator
    {
        public float Add(float val1, float val2)
        {
            return val1 + val2;
        }

        public float Divide(float val1, float val2)
        {
            return val1 / val2;
        }

        public float Multiply(float val1, float val2)
        {
            return val1 * val2;
        }

        public float Substract(float val1, float val2)
        {
            return val1 / val2;
        }

        public string ValidateOperation(string operation, string newOperand)
        {
            throw new NotImplementedException();
        }

        public float ProcessOperation(string operation)
        {
            throw new NotImplementedException();
        }
    }
}
