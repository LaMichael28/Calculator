using KeyNinja.Calculator.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyNinja.Calculator.Logic
{
    public class StandardCalculator : ICalculator
    {
        private readonly string[] operators = { "+", "-", "x", "/" };

        public double Add(double val1, double val2)
        {
            return val1 + val2;
        }

        public double Divide(double val1, double val2)
        {
            if (val2 == 0)
            {
                throw new DivideByZeroException();
            }

            return val1 / val2;
        }

        public double Multiply(double val1, double val2)
        {
            return val1 * val2;
        }

        public double Substract(double val1, double val2)
        {
            return val1 - val2;
        }

        public double Porcentage(double val)
        {
            return val / 100;
        }

        public bool ValidateOperation(string operation, string newOperand)
        {
            bool valid = true;
            var last = String.IsNullOrEmpty(operation) ? string.Empty : operation.Last().ToString();

            if (IsOperator(newOperand) || newOperand == "." || newOperand == "%")
            {
                if (!(IsNumeric(last) || (last == "%" && newOperand != "%" && newOperand != ".")))
                {
                    valid = false;
                }
            }
            else
            {
                if (!(IsNumeric(newOperand) && (IsOperator(last) || IsNumeric(last) || last == "." || last == string.Empty)))
                {
                    valid = false;
                }
            }

            return valid;
        }

        public double ProcessOperation(string operation)
        {
            double result = 0;
            string operand = string.Empty;
            var op = operation;
            LinkedList<string> operators = new LinkedList<string>();
            LinkedList<double> operands = new LinkedList<double>();
            var last = String.IsNullOrEmpty(operation) ? "" : operation.Last().ToString();

            if (IsOperator(last) || last == "%" || last == ".")
            {
                op = operation.Substring(0, operation.Length - 1);
            }

            for (var i = 0; i < op.Length; i++)
            {
                var value = op[i];
                string val = value.ToString();

                if (IsNumeric(val) || val == ".")
                {
                    operand += val;
                }

                if (val == "%")
                {
                    operand = Porcentage(double.Parse(operand)).ToString();
                }

                if (IsOperator(val))
                {
                    operators.AddLast(val);
                    operands.AddLast(double.Parse(operand));
                    operand = string.Empty;
                }

                if (i == operation.Length - 1)
                {
                    operands.AddLast(double.Parse(operand));
                }
            }

            result = PerformOperation(operands, operators);
            return result;
        }

        private double PerformOperation(LinkedList<double> operands, LinkedList<string> operators)
        {
            double resTmp = 0;
            double operand1, operand2;

            while (operators.Count > 0)
            {
                var operation = operators.First();
                operators.RemoveFirst();
                operand1 = operands.First();
                operands.RemoveFirst();
                operand2 = operands.First();
                operands.RemoveFirst();

                switch (operation)
                {
                    case "+": resTmp = this.Add(operand1, operand2);
                              operands.AddFirst(resTmp);
                              break;
                    case "-": resTmp = this.Substract(operand1, operand2);
                              operands.AddFirst(resTmp);
                              break;
                    case "x": resTmp = this.Multiply(operand1, operand2);
                              operands.AddFirst(resTmp);
                              break;
                    case "/": resTmp = this.Divide(operand1, operand2);
                              operands.AddFirst(resTmp);
                              break;
                }
            }

            return operands.First();
        } 

        private bool IsNumeric(string val)
        {
            int result = 0;
            return Int32.TryParse(val, out result);
        }

        private bool IsOperator(string val)
        {
            return operators.Contains(val);
        }

    }
}
