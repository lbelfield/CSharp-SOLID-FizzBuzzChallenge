namespace FizzBuzz
{
    using FizzBuzz.Interfaces;

    public class ConsoleOutput : IConsoleOutput
    {
        public string GetConsoleOutput(string inputString)
        {
            var inputNumber = 0;

            if (int.TryParse(inputString, out inputNumber))
            {
                inputNumber = int.Parse(inputString);

                var calculator = new Calculator();
                return calculator.FizzBuzz(inputNumber);
            }

            return "Please enter a valid number";
        }
    }
}
