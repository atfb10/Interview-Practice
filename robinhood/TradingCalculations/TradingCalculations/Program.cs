using System;
using System.Collections.Generic;

// iterate through a list of trades and transform it to output a list of buy/sell pairs 
// also calculate overall profit while doing so.

namespace TradingCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            Dictionary<string, float> buySellPairs = new Dictionary<string, float>();
            buySellPairs.Add("buy1", -300.75f);
            buySellPairs.Add("buy2", -450.90f);
            buySellPairs.Add("buy3", -1000.43f);
            buySellPairs.Add("sell1", 400.00f);
            buySellPairs.Add("sell2", 400.00f);
            buySellPairs.Add("sell3", 1500.85f);

            // print pairs
            PrintPairs(buySellPairs);

            // calculate total plus minus after selling all shares
            double final = Returns(buySellPairs);
            final = Math.Round(final, 2);
            Console.WriteLine("\nYour total net +- is: ${0}", final);

            // keep console open
            Console.Read();
        }

        // print buy/sell pairs
        private static void PrintPairs(Dictionary<string, float> dict)
        {
            foreach(KeyValuePair<string, float> pair in dict)
            {
                Console.WriteLine("Buy/Sell Item: {0}, Buy/Sell Price: {1}", pair.Key, pair.Value);
            }
        }

        // show current gain or loss
        private static float Returns(Dictionary<string, float> dict)
        {
            float plusMinus = 0.00f;

            foreach (float value in dict.Values)
            {
                plusMinus += value;
            }

            return plusMinus;
        }
    }
}
