using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong[] fib = new ulong[100];
            byte i;

            fib[0] = 0; fib[1] = 1; fib[2] = 1;
            for (i = 3; i < 100; i++)
                fib[i] = fib[i - 1] + fib[i - 2];

            for (i = 0; i < 100; i++)
                Console.WriteLine($"{i + 1}) {fib[i]}");
        }
    }
}
