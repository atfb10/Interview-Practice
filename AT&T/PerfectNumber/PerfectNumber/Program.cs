using System;

// check if a number is perfect or not
// A number is perfect if it is equal to sum of its proper divisors
// that is, the sum of its positive divisors excluding the number itself
// formula is 2^(p-1)(2^p - 1) where 2^p-1 is prime

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // call method and show which numbers < 10000 are perfect numbers
            for (int i = 0; i < 10000; i++)
            {
                // if perfect, inform user
                if (IsPerfectNum(i))
                {
                    Console.WriteLine("{0} is a perfect number.", i);
                }
            }

            // keep console open
            Console.Read();
        }

        // return true if perfect number, else false
        private static bool IsPerfectNum(int n)
        {
            // store sum of divisors, start at 1 since that is automatic
            int sum = 1;
            bool result = false;

            // find divisors and add them. Start at 2, because one does not count and cannot divide by 0
            for (int i = 2; i*i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i + n / i;
                }
            }

            // check if sum is equal to n. If so, its true
            if (sum == n && n != 1)
            {
                result = true;
            }

            // return result
            return result;
        }
    }
}
