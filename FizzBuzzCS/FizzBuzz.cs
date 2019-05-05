using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzCS
{
    public class FizzBuzz
    {

        public bool IsFizzer(int number)
        {
            return number % 3 == 0;
        }

        public bool IsBuzzer(int number)
        {
            return (number % 5) == 0;
        }

        public string GetNumberText(int number)
        {
            bool isDivisbleByThree = IsFizzer(number);
            bool isDivisibleByFive = IsBuzzer(number);

            if (isDivisibleByFive && isDivisbleByThree)
            {
                return "FIZZBUZZ";
            }
            if (isDivisibleByFive)
            {
                return "BUZZ";
            }
            else if (isDivisbleByThree)
            {
                return "FIZZ";
            }
            return number.ToString();
        }

        public void Process(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(GetNumberText(i));
            }
        }

    }
}
