using FizzBuzz.Interfaces;
namespace FizzBuzz
{
    using Microsoft.Practices.Unity;

    public class Bootstrapper
    {
        public static WriteToConsole ConfigureContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IConsoleOutput, ConsoleOutput>();
            container.RegisterType<ICalculator, Calculator>();
            container.RegisterType<IFizzBuzzDictionary, FizzBuzzDictionary>();

            return container.Resolve<WriteToConsole>();
        }
    }
}
