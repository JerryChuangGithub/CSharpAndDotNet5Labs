using System.Diagnostics;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Writing to the default trace listener
            Debug.WriteLine("Debug says, I am watching");
            Trace.WriteLine("Trace says, I am watching");
        }
    }
}
