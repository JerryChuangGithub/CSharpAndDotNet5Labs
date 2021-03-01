using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint natureNumber = 23;

            int integerNumber = 23;

            float realNumber = 2.3F;

            double anotherRealNumber = 2.3;

            int decimalNotation = 2_000_000;

            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;

            int hexadecimalNotation = 0x_001E_8480;

            Console.WriteLine($"{decimalNotation == binaryNotation}");

            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");
        }
    }
}
