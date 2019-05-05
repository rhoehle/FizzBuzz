using System;

namespace FizzBuzzCS
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz game = new FizzBuzz();
            Console.WriteLine("A quick 1 - 30 FizzBuzz demo. Press any key.");
            Console.ReadLine();

            int number = 0;
            int finish = 30;

            while (number < finish)
            {
                number++;             
                {
                    System.Console.WriteLine(game.GetNumberText(number));
                }
            }
        }
    }
}
