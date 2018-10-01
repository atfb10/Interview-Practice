using System;
using System.Text;

/// <summary>
/// Start at 1
/// For each number divisible by 3, print fizz
/// For each number divisible by 5, print buzz
/// For each number divisible by 7, print cocoa
/// For each number divisible by 11, print prime
/// If number is divisible by multiple dividends, concatenate word
/// </summary>

namespace FizzBuzzVariation
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            int x = 40;

            // call method, pass in x
            FizzBuzz(x);

            // keep console open
            Console.Read();
        }

        // pass in n
        private static void FizzBuzz(int n)
        {
            // loop from 1 to n
            for(int i = 1; i <= n; i++)
            {
                // create mutable stringbuilder object
                StringBuilder printStr = new StringBuilder();

                // for each case, append result

                // check if divisible by 3
                if (i % 3 == 0)
                    printStr.Append("Fizz" + " ");

                // check if divisible by 5
                if (i % 5 == 0)
                    printStr.Append("Buzz" + " ");

                // check if divisible by 7
                if (i % 7 == 0)
                    printStr.Append("Cocoa" + " ");

                // check if divisible by 11
                if (i % 11 == 0)
                    printStr.Append("Prime" + " ");

                // other cases
                if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0)
                    printStr.Append(i);

                // print the strinbuilder object
                Console.WriteLine(printStr.ToString());
            }
        }
    }
}
