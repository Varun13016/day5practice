using System;

namespace leapyear
{
    class Program
    {  static void Main(string[] args)  
        {
            int year;
            Console.WriteLine("Enter Year : ");  
            int Year = int.Parse(Console.ReadLine());  
            if
                (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("Year is Leap Year");
            else
                Console.WriteLine("Year is not Leap Year");
        }  
    }  
}  