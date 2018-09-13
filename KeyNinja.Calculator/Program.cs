using KeyNinja.Calculator.Logic.Interfaces;
using Ninject;
using System;
using System.Windows.Forms;

namespace KeyNinja.Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IKernel kernel = new StandardKernel(new CalculatorModule());
            ICalculator calculator = kernel.Get<ICalculator>();
            Application.Run(new CalculatorForm(calculator));
        }
    }
}
