namespace FizzBuzz.UnitTests
{
    using FizzBuzz.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Rhino.Mocks;

    [TestClass]
    public class ConsoleOutputUnitTests
    {
        private readonly ICalculator _mockCalculator = MockRepository.GenerateStub<ICalculator>();
        private IConsoleOutput _mockConsoleOutput;

        [TestMethod]
        public void GetConsoleOutput_ValidNumber_ReturnsFizzBuzzNumber()
        {
            // Assign
            this._mockCalculator.Stub(c => c.FizzBuzz(5)).Return("buzz");
            this._mockConsoleOutput = new ConsoleOutput(_mockCalculator);

            // Act
            var output = _mockConsoleOutput.GetConsoleOutput("5");

            // Assert
            Assert.AreEqual(output, "buzz");
        }

        [TestMethod]
        public void GetConsoleOutput_NotANumberReturnsFizzBuzzNumber()
        {
            // Assign
            // this._mockICalculator.Stub(c => c.FizzBuzz(Arg<int>.Is.Anything)).Return("buzz");
            this._mockCalculator.Stub(c => c.FizzBuzz(5)).Return("buzz");

            this._mockConsoleOutput = new ConsoleOutput(_mockCalculator);

            // Act
            var output = _mockConsoleOutput.GetConsoleOutput("hello");

            // Assert
            Assert.AreEqual(output, "Please enter a valid number");
        }
    }
}
