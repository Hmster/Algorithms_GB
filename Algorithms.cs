using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_GB
{
    internal class Algorithms
    {
        /// <summary>
        /// Check number for prime
        /// </summary>
        /// <param name="number">Number to check for prime</param>
        /// <returns>True/False(prime/not)</returns>
        internal static bool ArePrime(long number)
        {
            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                    i++;
                }
                else
                    i++;
            }
            if (d == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Get Fibonacci number
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>Result</returns>
        internal static long GetFibNumber(long n)
        {
            long a0 = 0;
            long a1 = 1;
            long a = a1;
            for (int i = 2; i <= n; i++)
            {
                a = a0 + a1;
                a0 = a1;
                a1 = a;
            }
            return a1;
        }

        /// <summary>
        /// Get Fibonacci number(recursively)
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>Result</returns>
        internal static long GetFibNumberRecurs(long n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return GetFibNumberRecurs(n - 1) + GetFibNumberRecurs(n - 2);
        }
    }
}
