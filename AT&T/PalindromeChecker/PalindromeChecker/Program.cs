using System;
using System.Text;

// check if a word is a palindrome or not

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // test cases
            string test1 = "test";
            string test2 = "racecar";

            // print results
            if (IsPalindrome(test1))
                Console.WriteLine("{0} is a palindrome", test1);
            else
                Console.WriteLine("{0} is not a palindrome", test1);
            
            if (IsPalindrome(test2))
                Console.WriteLine("{0} is a palindrome", test2);
            else
                Console.WriteLine("{0} is not a palindrome", test2);

            // keep console open
            Console.Read();
        }

        // check if palindrome


        // reverse string
        private static string ReverseStr(string str)
        {
            // initialize variables 
            int i;
            char temp;
            StringBuilder reversed = new StringBuilder();

            // convert string to char array
            char[] arr = str.ToCharArray();
            int n = arr.Length;

            // loop through half of array and swap positions
            for (i = 0; i < n / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }

            // append the reversed char array 
            for (i = 0; i < n; i++)
            {
                reversed.Append(arr[i]);
            }

            // return the reversed string
            return reversed.ToString();
        }

        // check if word is palindrome
        private static bool IsPalindrome(string str)
        {
            // boolean result to return 
            bool result = false;

            // create variable to hold value of reversed string
            string reversed = ReverseStr(str);

            // compare original string to reversed. If identical, return true
            if (str == reversed)
                result = true;

            // return the result
            return result;
        }
    }
}
