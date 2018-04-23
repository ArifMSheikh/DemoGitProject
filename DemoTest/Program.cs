using System;
using static System.Console;

namespace DemoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter your age:");
            //User input and then parse into integer since ReadLine is string type
            int age = int.Parse(ReadLine());

            //If else statements
            if (age > 15)
            {
                Console.WriteLine($"Your age is {age} so you can drive");
            }
            else
            {
                Console.WriteLine($"Your age is {age} so you cannot drive");
            }
           
        }
    }
}
