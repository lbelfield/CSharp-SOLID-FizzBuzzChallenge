namespace FizzBuzz
{
    using System;
    using FizzBuzz.Interfaces;

    public class WriteToConsole
    {
        public void Write()
        {
            Console.WriteLine("Please enter a number");
            var inputString = Console.ReadLine();

            var consoleOutput = new ConsoleOutput();
            Console.WriteLine(consoleOutput.GetConsoleOutput(inputString));
            Console.Read();
        }
    }
}
