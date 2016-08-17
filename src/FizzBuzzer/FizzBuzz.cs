using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzer
{
    public interface IFizzBuzzer
    {
        IEnumerable<string> ShakeIt();
        string FizzOrBuzz(int number);
    }

    public class FizzBuzzer : IFizzBuzzer
    {
        public FizzBuzzer()
        {
            MaxValue = 100;
            MinValue = 1;
        }

        public int MaxValue { get; set; }
        public int MinValue { get; set; }

        public IEnumerable<string> ShakeIt()
        {
            return Enumerable.Range(MinValue, MaxValue - MinValue + 1).Select(FizzOrBuzz);
        }

        public string FizzOrBuzz(int number)
        {
            if (number%3 == 0 && number%5 == 0)
            {
                return "FizzBuzz";
            }

            if (number%5 == 0)
            {
                return "Buzz";
            }

            if (number%3 == 0)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}
