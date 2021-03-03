using System;

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

            // interpolated strings.
            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

            // Understanding format strings
            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;
            Console.WriteLine(
              format: "{0,-8} {1,6:N0}",
              arg0: "Name",
              arg1: "Count");
            Console.WriteLine(
              format: "{0,-8} {1,6:N0}",
              arg0: applesText,
              arg1: applesCount);
            Console.WriteLine(
              format: "{0,-8} {1,6:N0}",
              arg0: bananasText,
              arg1: bananasCount);

            // Getting text input from the user
            Console.Write("Type your first name and press ENTER: ");
            string firstName = Console.ReadLine();
            Console.Write("Type your age and press ENTER: ");
            string age = Console.ReadLine();
            Console.WriteLine(
              $"Hello {firstName}, you look good for {age}.");
        }
    }
}
