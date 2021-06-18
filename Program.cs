using System;

namespace Array_OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // declaring and initialising array of 10 integers with array values
            int i; // declaring loop variable

            for(i=0; i<=9;i++) // looping through each array value
            {
                if (i % 2 == 1) // only prints odd numbers
                {
                    Console.WriteLine("odd numbers are " + i);
                }
            }
        }
    }
}
