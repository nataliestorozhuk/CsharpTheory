﻿using System;
using System.Collections.Generic;

namespace Arrays
{
    class SamplesArray
    {
        public static void Run()
        {

            // Create and initialize a new string array.
            String[] myArr = { "The", "quick", "brown", "fox" };

            // Display the values of the array.
            Console.WriteLine("The string array initially contains the following values:");
            PrintIndexAndValues(myArr);

            // Create a read-only IList wrapper around the array.
            IList<string> myList = Array.AsReadOnly(myArr);

            // Display the values of the read-only IList.
            Console.WriteLine("The read-only IList contains the following values:");
            PrintIndexAndValues(myList);

            // Attempt to change a value through the wrapper.
            try
            {
                myList[3] = "CAT";
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine("{0} - {1}", e.GetType(), e.Message);
                Console.WriteLine();
            }

            // Change a value in the original array.
            myArr[2] = "RED";

            // Display the values of the array.
            Console.WriteLine("After changing the third element, the string array contains the following values:");
            PrintIndexAndValues(myArr);

            // Display the values of the read-only IList.
            Console.WriteLine("After changing the third element, the read-only IList contains the following values:");
            PrintIndexAndValues(myList);
        }

        public static void PrintIndexAndValues(String[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine("   [{0}] : {1}", i, myArr[i]);
            }
            Console.WriteLine();
        }

        public static void PrintIndexAndValues(IList<string> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("   [{0}] : {1}", i, myList[i]);
            }
            Console.WriteLine();
        }
    }

}

