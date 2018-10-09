using System;
using System.Text;

/// <summary>
/// given a string of size n, write functions to perform following operations
/// 
/// 1. Left rotate the string by arbitrary number of elements where
/// 2. Left rotate the string by arbitrary number of elements where
/// 
/// Example rotate adam 1 space
/// left: dama
/// right: mada
/// </summary>

namespace Left_and_Right_Rotation_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string str = "testing";
            int x = 2;

            // initialize variables to hold rotated string values
            string rotatedLeft = "";
            string rotatedRight = "";

            // call methods and pass in args
            rotatedLeft = LeftRotate(str, x);
            rotatedRight = RightRotate(str, x);

            Console.WriteLine("Left rotation by {0} = {1}", x, rotatedLeft);
            Console.WriteLine("Right rotation by {0} = {1}", x, rotatedRight);

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Rotate string to left by arbitrary number of places
        /// </summary>
        /// <param name="str"></param>
        /// <param name="shiftPlaces"></param>
        /// <returns></returns>
        private static string LeftRotate(string str, int shiftPlaces)
        {
            // value to return
            StringBuilder rotated = new StringBuilder();

            // create counter for loops
            int counter = 0;

            // convert string to char array
            char[] ogArr = str.ToCharArray();

            // create new char array that will be converted to shifted string
            char[] shiftedArr = new char[ogArr.Length];

            // add vals to shifted array
            for (int i = shiftPlaces; i < ogArr.Length; i++)
                shiftedArr[counter++] = ogArr[i];

            // move front of original array to back
            for (int i = 0; i < shiftPlaces; i++)
                shiftedArr[counter++] = ogArr[i];

            // build string
            for (int i = 0; i < shiftedArr.Length; i++)
                rotated.Append(shiftedArr[i]);

            // return the shifted string
            return rotated.ToString();
        }

        /// <summary>
        ///  Rotate string to right by arbitrary number of places
        /// </summary>
        /// <param name="str"></param>
        /// <param name="shiftPlaces"></param>
        /// <returns></returns>
        private static string RightRotate(string str, int shiftPlaces)
        {
            // stringbuilder object to be returned
            StringBuilder rotated = new StringBuilder();

            // loop counter 
            int counter = 0;

            // convert string to char array
            char[] ogArr = str.ToCharArray();

            // create new array that will be converted to returned string
            char[] shiftedArr = new char[ogArr.Length];

            // shift end items to front
            for (int i = ogArr.Length - shiftPlaces; i < ogArr.Length; i++)
                shiftedArr[counter++] = ogArr[i];

            // add rest of items
            for (int i = 0; i < ogArr.Length - shiftPlaces; i++)
                shiftedArr[counter++] = ogArr[i];

            // build string
            for (int i = 0; i < shiftedArr.Length; i++)
                rotated.Append(shiftedArr[i]);

            // return the rotated stringbuilder object
            return rotated.ToString();
        }
    }
}
