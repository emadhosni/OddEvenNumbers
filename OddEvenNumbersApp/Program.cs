using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OddEvenNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintNumbers("Numbers", numbers);
            PrintNumbers("Even Numbers", numbers.Where(x=>IsEven(x)));
            PrintNumbers("Odd Numbers", numbers.Where(x=>IsOdd(x)));

            Console.ReadKey();
        }

        static void PrintNumbers(string title, IEnumerable<int> numbers)
        {
            Console.WriteLine();

            Console.WriteLine($"{title}: [");
            foreach (var n in numbers)
            {
                Console.WriteLine($" {n}");
            }
            Console.WriteLine($" ]");
            Console.WriteLine();
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        static bool IsOdd(int number)
        {
            if (number % 2 != 0)
                return true;
            else
                return false;
        }
    }
}
