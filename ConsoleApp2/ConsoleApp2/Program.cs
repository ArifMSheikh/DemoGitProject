using System;
using static System.Console;
using System.Text.RegularExpressions;
using System.Collections;


namespace Assignment3
{
    class Program1
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5] { 51, 6, 0, 1, 10 };
            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (int item in numbers)
            {
                WriteLine(item);
            }
                        
        }
    }

   
}

