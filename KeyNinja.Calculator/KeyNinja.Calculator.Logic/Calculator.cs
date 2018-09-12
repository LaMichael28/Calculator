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
        private readonly string[] operators = { "+", "-", "x", "/" };

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

        public bool ValidateOperation(string operation, string newOperand)
        {
            bool valid = true;
            int result = 0;
            var last = String.IsNullOrEmpty(operation) ? "" : operation.Last().ToString();
            
            if (operators.Contains(newOperand) || newOperand == "." || newOperand == "%")
            {
                if (!(Int32.TryParse(last, out result) || (last == "%" && newOperand != "%")))
                {
                    valid = false;
                }
            }
            else
            {
                if (! (Int32.TryParse(newOperand, out result) && (operators.Contains(last) || Int32.TryParse(last, out result) || 
                    last == "." || last == string.Empty)))
                {
                    valid = false;
                }
            }

            return valid;
        }

        public float ProcessOperation(string operation)
        {
            throw new NotImplementedException();
        }
    }
}
