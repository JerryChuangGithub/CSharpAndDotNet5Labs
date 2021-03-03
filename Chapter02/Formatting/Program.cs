using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            // numbered positional arguments
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;
            WriteLine(
              format: "{0} apples costs {1:C}",
              arg0: numberOfApples,
              arg1: pricePerApple * numberOfApples);

            string formatted = string.Format(
              format: "{0} apples costs {1:C}",
              arg0: numberOfApples,
              arg1: pricePerApple * numberOfApples);
            //WriteToFile(formatted); // writes the string into a file

            // interpolated strings.
            WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

            // Understanding format strings
            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Bananas";
            int bananasCount = 56789;
            WriteLine(
              format: "{0,-8} {1,6:N0}",
              arg0: "Name",
              arg1: "Count");
            WriteLine(
              format: "{0,-8} {1,6:N0}",
              arg0: applesText,
              arg1: applesCount);
            WriteLine(
              format: "{0,-8} {1,6:N0}",
              arg0: bananasText,
              arg1: bananasCount);

            // Getting text input from the user
            Write("Type your first name and press ENTER: ");
            string firstName = ReadLine();
            Write("Type your age and press ENTER: ");
            string age = ReadLine();
            WriteLine(
              $"Hello {firstName}, you look good for {age}.");
        }
    }
}
