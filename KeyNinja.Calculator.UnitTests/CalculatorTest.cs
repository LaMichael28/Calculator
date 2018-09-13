using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KeyNinja.Calculator.Logic;

namespace KeyNinja.Calculator.UnitTests
{
    [TestClass]
    public class CalculatorTest
    {
        private static StandardCalculator calculator;

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            calculator = new StandardCalculator();
        }

        [TestMethod]
        public void ValidExpressionShouldReturnTrue()
        {
            // Arrange
            var expression = "9x9+5";
            var newOperand = "%";

            // Act
            bool valid = calculator.ValidateOperation(expression, newOperand);

            // Assert
            Assert.IsTrue(valid, "Validation operation is incorrect!");
        }

        [TestMethod]
        public void InvalidExpressionShouldReturnFalse()
        {
            // Arrange
            var expression = "9x9+5+";
            var newOperand = "+";

            // Act
            bool valid = calculator.ValidateOperation(expression, newOperand);

            // Assert
            Assert.IsFalse(valid, "Validation operation is incorrect!");
        }

        [TestMethod]
        public void ProcessOperationShouldReturnResult()
        {
            // Arrange
            var expression = "9x9+0.01+10%";
            var expectedResult = 81.11;

            // Act
            double result = calculator.ProcessOperation(expression);

            // Assert
            Assert.AreEqual(expectedResult, result, "Process operation is not returning a valid result!");
        }

        [ExpectedException(typeof(DivideByZeroException), "Division by zero is not controlled!")]
        [TestMethod]
        public void DivisionByZeroShouldReturnError()
        {
            // Arrange
            var expression = "9x9/0+10%";

            // Act
            calculator.ProcessOperation(expression);
        }
    }
}
