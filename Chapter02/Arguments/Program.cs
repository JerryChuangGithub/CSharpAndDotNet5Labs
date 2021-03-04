using System;
using static System.Console;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            foreach (var arg in args)
            {
                WriteLine(arg);
            }
        }
    }
}
