using KeyNinja.Calculator.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyNinja.Calculator.Logic;

namespace KeyNinja.Calculator
{
    public partial class CalculatorForm : Form
    {
        private ICalculator calculator = new StandardCalculator();

        public CalculatorForm()
        {
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

        private void Operation_Click(object sender, System.EventArgs e) {

            var control = sender as Button;
            var value = txtResultValue.Text;
            bool clearResult = false, clearLast = false;

            switch (control.Tag.ToString())
            {
                case "NumberType":          
                case "BasicOperationType":  
                case "Point":               
                case "Porcentage":          if (calculator.ValidateOperation(value, control.Text)) {
                                                value += control.Text;
                                            }
                                            break;
                case "Equal":               value = calculator.ProcessOperation(value).ToString();
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
