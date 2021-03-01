using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Amir";
            Console.WriteLine($"{name} is {height} metres tall.");
            // int length1 = name.Length; // gives compile error!
            int length2 = ((string)name).Length;
            Console.WriteLine($"{name} has {length2} characters.");
        }
    }
}
