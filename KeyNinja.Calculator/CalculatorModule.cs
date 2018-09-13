using KeyNinja.Calculator.Logic;
using KeyNinja.Calculator.Logic.Interfaces;
using Ninject.Modules;

namespace KeyNinja.Calculator
{
    public class CalculatorModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICalculator>().To<StandardCalculator>();
        }
    }
}
