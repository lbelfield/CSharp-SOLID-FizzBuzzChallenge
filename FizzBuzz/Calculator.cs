namespace FizzBuzz
{
    using FizzBuzz.Interfaces;

    public class Calculator : ICalculator
    {
        private readonly IFizzBuzzDictionary _fizzBuzzDictionary;

        public Calculator(IFizzBuzzDictionary fizzBuzzDictionary)
        {
            _fizzBuzzDictionary = fizzBuzzDictionary;
        }

        public string FizzBuzz(int input)
        {
            if (input == 0)
            {
                return "Dividing by zero is undefined";
            }

            // if we want to add new numbers, and the smallest must go first, then we could refactor like below.
            // this would have potential O(n) performance problems however
            // var dictionary = FizzBuzzDictionary().OrderByDescending(x => x.Key);

            var dictionary = _fizzBuzzDictionary.GetDictionary();
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
