using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyNinja.Calculator.Logic.Interfaces
{
    public interface ICalculator
    {
        float Add(float val1, float val2);
        float Substract(float val1, float val2);
        float Divide(float val1, float val2);
        float Multiply(float val1, float val2);
        bool ValidateOperation(string operation, string newOperand);
        float ProcessOperation(string operation);
    }
}
