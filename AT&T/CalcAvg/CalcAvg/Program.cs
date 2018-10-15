using System;

// calc average of two numbers

namespace CalcAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // test nums
            int x = 24, y = 45;

            // call method and print result
            Console.WriteLine("{0} and {1}'s average = {2}", x, y, CalcAvg(x, y));

            // keep console open
            Console.Read();
        }

        private static float CalcAvg(int x, int y)
        {
            float avg;
            int sum = x + y;

            // divide sum by total numbers
            avg = sum / (float)2;

            // return avg
            return avg;
        }
    }
}
