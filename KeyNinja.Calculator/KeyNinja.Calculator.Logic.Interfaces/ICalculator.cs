using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyNinja.Calculator.Logic.Interfaces
{
    public interface ICalculator
    {
        double Add(double val1, double val2);
        double Substract(double val1, double val2);
        double Divide(double val1, double val2);
        double Multiply(double val1, double val2);
        bool ValidateOperation(string operation, string newOperand);
        double Porcentage(double val);
        double ProcessOperation(string operation);
    }
}
