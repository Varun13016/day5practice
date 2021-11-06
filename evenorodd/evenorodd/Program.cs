using System;

namespace evenorodd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the Number :");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("{0} is Even Number", num);
            else
                Console.WriteLine("{0} is Odd Number", num);
        }
    }
}