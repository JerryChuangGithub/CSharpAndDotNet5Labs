﻿using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            // numbered positional arguments
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;
            Console.WriteLine(
              format: "{0} apples costs {1:C}",
              arg0: numberOfApples,
              arg1: pricePerApple * numberOfApples);

            string formatted = string.Format(
              format: "{0} apples costs {1:C}",
              arg0: numberOfApples,
              arg1: pricePerApple * numberOfApples);
            //WriteToFile(formatted); // writes the string into a file
        }
    }
}
