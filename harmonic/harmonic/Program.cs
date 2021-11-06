using System;

namespace harmonic
{
    class Program
    {
        public static void Main (string [] args )
        {
            Console.WriteLine("enter the number");
            double num = int.Parse(Console.ReadLine());
            double harmonicNum = 0;

            for (double i = 1; i <= num; i++)
            {
                harmonicNum += (1 / i);
                Console.WriteLine("1/" + i + "=" + (1 / i));
            }
            Console.WriteLine(" The " + num + " harmonic number is=" + harmonicNum);
        }
    }
}
