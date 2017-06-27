namespace FizzBuzz.UnitTests
{
    using System.Collections.Generic;
    using FizzBuzz.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Rhino.Mocks;

    [TestClass]
    public class CalculatorUnitTests
    {
        private readonly IFizzBuzzDictionary _mockFizzBuzzDictionary = MockRepository.GenerateStub<IFizzBuzzDictionary>();
        private ICalculator _mockCalculator;

        [TestInitialize]
        public void Initialize()
        {
            this._mockFizzBuzzDictionary.Stub(d => d.GetDictionary()).Return(new Dictionary<int, string>
            {
                {3, "fizz"},
                {5, "buzz"}
            });

            this._mockCalculator = new Calculator(_mockFizzBuzzDictionary);
        }

        [TestMethod]
        public void Calculator_InputEqualsZero_ReturnsDividingByZeroIsUndefined()
        {
            //Act
            var output = this._mockCalculator.FizzBuzz(0);

            //Assert
            Assert.AreEqual(output, "Dividing by zero is undefined");
        }

        [TestMethod]
        public void Calculator_NonMultiplierInput_ReturnsInput()
        {
            //Act
            var output = this._mockCalculator.FizzBuzz(2);

            //Assert
            Assert.AreEqual(output, "2");
        }

        [TestMethod]
        public void Calculator_FizzInput_ReturnsFizz()
        {
            //Act
            var output = this._mockCalculator.FizzBuzz(3);

            //Assert
            Assert.AreEqual(output, "fizz");
        }

        [TestMethod]
        public void Calculator_BuzzInput_ReturnsBuzz()
        {
            //Act
            var output = this._mockCalculator.FizzBuzz(5);

            //Assert
            Assert.AreEqual(output, "buzz");
        }

        [TestMethod]
        public void Calculator_FizzBuzzInput_ReturnsFizzBuzz()
        {
            //Act
            var output = this._mockCalculator.FizzBuzz(30);

            //Assert
            Assert.AreEqual(output, "fizzbuzz");
        }

        [TestMethod]
        public void Calculator_AddNewInputToDictionary_ReturnsMuzzBuzz()
        {
            // Arrange
            var mockExtendedFizzBuzzDictionary = MockRepository.GenerateStub<IFizzBuzzDictionary>();

            mockExtendedFizzBuzzDictionary.Stub(d => d.GetDictionary()).Return(new Dictionary<int, string>
            {
                {3, "fizz"},
                {4, "muzz" },
                {5, "buzz"}
            });

            this._mockCalculator = new Calculator(mockExtendedFizzBuzzDictionary);

            //Act
            var output = this._mockCalculator.FizzBuzz(20);

            //Assert
            Assert.AreEqual(output, "muzzbuzz");
        }
    }
}
