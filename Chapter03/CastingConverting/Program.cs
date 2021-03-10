﻿using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Casting numbers implicitly and explicitly
            int a = 10;
            double b = a; // an int can be safely cast into a double
            WriteLine(b);

            double c = 9.8;
            // int d = c; // compiler gives an error for this line
            int d = (int)c;
            WriteLine(d); // d is 9 losing the .8 part

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");
            e = 5_000_000_000;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            // Converting with the System.Convert type
            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");
        }
    }
}
