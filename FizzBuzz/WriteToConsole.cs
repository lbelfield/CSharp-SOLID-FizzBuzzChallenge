namespace FizzBuzz
{
    using System;
    using FizzBuzz.Interfaces;

    public class WriteToConsole
    {
        private readonly IConsoleOutput _consoleOutput;

        public WriteToConsole(IConsoleOutput consoleOutput)
        {
            _consoleOutput = consoleOutput;
        }

        public void Write()
        {
            Console.WriteLine("Please enter a number");
            var inputString = Console.ReadLine();       
            Console.WriteLine(_consoleOutput.GetConsoleOutput(inputString));
            Console.Read();
        }
    }
}
