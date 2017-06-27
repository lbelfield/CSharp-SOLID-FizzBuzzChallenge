namespace FizzBuzz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var writeToConsole = Bootstrapper.ConfigureContainer();
            writeToConsole.Write();
        }
    }
}
