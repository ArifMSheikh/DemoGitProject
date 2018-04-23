using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

class Program
{
    static void Main()
    {

        // Specify the data source.
        int[] scores = new int[] { 200, 250, 150, 97, 92, 81, 60, 50, 10, 5, 0 };

        // Define the query expression.
        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;

        // Execute the query.
        foreach (int i in scoreQuery)
        {
            Console.Write(i + " ");
        }
    }
}