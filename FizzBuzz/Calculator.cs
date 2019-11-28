namespace FizzBuzz
{
    using FizzBuzz.Interfaces;

    public class Calculator : ICalculator
    {
          public string FizzBuzz(int input)
        {
            if (input == 0)
            {
                return "Dividing by zero is undefined";
            }

            var fizzBuzzDictionary = new FizzBuzzDictionary();

            var dictionary = fizzBuzzDictionary.GetDictionary();
            var output = string.Empty;

            foreach (var item in dictionary)
            {
                if (input % item.Key == 0)
                {
                    output += item.Value;
                }
            }

            return output == string.Empty ? input.ToString() : output;
        }
    }
}
