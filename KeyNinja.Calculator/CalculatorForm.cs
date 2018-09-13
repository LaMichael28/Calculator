using KeyNinja.Calculator.Logic.Interfaces;
using Ninject;
using System;
using System.Windows.Forms;

namespace KeyNinja.Calculator
{
    public partial class CalculatorForm : Form
    {
        private ICalculator calculator;

        [Inject]
        public CalculatorForm(ICalculator calculator)
        {
            this.calculator = calculator;
            InitializeComponent();
            AddEvents();
        }

        private void AddEvents()
        {
            foreach (var control in this.tblOperationsContainer.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Click += new EventHandler(Operation_Click);
                }
            }
        }

        private void Operation_Click(object sender, System.EventArgs e)
        {

            var control = sender as Button;
            var value = txtResultValue.Text;
            bool clearResult = false, clearLast = false;

            switch (control.Tag.ToString())
            {
                case "NumberType":          
                case "BasicOperationType":  
                case "Point":               
                case "Porcentage":          if (calculator.ValidateOperation(value, control.Text))
                                            {
                                                value += control.Text;
                                            }
                                            break;
                case "Equal":               try
                                            {
                                                value = calculator.ProcessOperation(value).ToString();
                                            }
                                            catch (DivideByZeroException)
                                            {
                                                value = "ERR";
                                            }
                                            break;
                case "Clear":               clearResult = true;
                                            break;
                case "ClearLast":           clearLast = true;
                                            break;
            }

            if (clearResult)
            {
                txtResultValue.Text = string.Empty;
            }
            else
            {
                if (clearLast && value.Length > 0)
                {
                    txtResultValue.Text = value.Substring(0, value.Length - 1);
                }
                else
                {
                    txtResultValue.Text = value;
                }
            }
        }
    }
}
