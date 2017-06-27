namespace FizzBuzz
{
    using System.Collections.Generic;
    using FizzBuzz.Interfaces;

    public class FizzBuzzDictionary : IFizzBuzzDictionary
    {
        public Dictionary<int, string> GetDictionary()
        {
            // Add a new item here if needed - Open Closed Principle
            return new Dictionary<int, string>
            {
                {3, "fizz"},
                {5, "buzz"}
            };
        }
    }
}
