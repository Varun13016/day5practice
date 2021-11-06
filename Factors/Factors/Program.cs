using System;

namespace Factors
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());
            int i = 2;
            while (userInput > 1)
            {
                while (userInput % i == 0)
                {
                    Console.WriteLine(i);
                    userInput = userInput / i;
                }

                i++;
            }
        }
    }
}