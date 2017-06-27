namespace FizzBuzz
{
    using FizzBuzz.Interfaces;

    public class ConsoleOutput : IConsoleOutput
    {
        private readonly ICalculator _calculator;

        public ConsoleOutput(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public string GetConsoleOutput(string inputString)
        {
            var inputNumber = 0;

            if (int.TryParse(inputString, out inputNumber))
            {
                inputNumber = int.Parse(inputString);
                return _calculator.FizzBuzz(inputNumber);
            }

            return "Please enter a valid number";
        }
    }
}
