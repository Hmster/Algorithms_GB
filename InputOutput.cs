using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_GB
{
    internal class InputOutput
    {
        /// <summary>
        /// Lesson1_1
        /// </summary>
        internal static void Lesson1_1()
        {
            long number = 4;
            ArePrimeOutput(number);
            number = 11;
            ArePrimeOutput(number);
        }

        /// <summary>
        /// Lesson1_2
        /// </summary>
        internal static void Lesson1_2()
        {
            Console.WriteLine("\nAlgorithm complexity of this sample code is O(N^3)");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
                int sum = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    for (int j = 0; j < inputArray.Length; j++) 
                    { 
                        for (int k = 0; k < inputArray.Length; k++) 
                        { 
                            int y = 0; 
                            if (j != 0)
                                y = k / j;
                            sum += inputArray[i] + i + k + j + y;
                        } 
                    }
                }
                return sum");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Lesson1_3
        /// </summary>
        internal static void Lesson1_3()
        {
            Console.Write("Enter number: ");
            if (long.TryParse(Console.ReadLine(), out long n))
            {
                Console.WriteLine($"\nNOT recursively");
                Console.WriteLine($"Fibonacci number for {n} is: {Algorithms.GetFibNumber(n)}");
                Console.WriteLine("\n!!!Note:This may take mutch time!!!\nRecursively");
                Console.WriteLine($"Fibonacci number for {n} is: {Algorithms.GetFibNumberRecurs(n)}");
            }
            else
                Console.WriteLine("Incorrect input. Try again.");
        }

        /// <summary>
        /// Console output for ArePrime
        /// </summary>
        /// <param name="number">Number to check for prime</param>
        internal static void ArePrimeOutput(long number)
        {
            if (Algorithms.ArePrime(number))
                Console.WriteLine($"Number {number} is prime");
            else
                Console.WriteLine($"Number {number} is not prime");
        }
    }
}
