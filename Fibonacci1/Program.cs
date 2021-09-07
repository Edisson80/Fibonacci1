using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci objFibonacci = new Fibonacci(7);
            objFibonacci.imprimirSerieFibonacci();
            objFibonacci.imprimirNumeroPrimo();
            Console.ReadLine();
        }
    }
}
