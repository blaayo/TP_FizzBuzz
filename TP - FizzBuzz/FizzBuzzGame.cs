using System;
using System.Linq;

namespace TP___FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string play(int number)
        {
            string response = null;
            if (number <= 0 ) throw new ArgumentException();
            if (number % 3 == 0) response += "Fizz";
            if (number % 5 == 0) response += "Buzz";
            return response ?? number.ToString();
        }
    }
}