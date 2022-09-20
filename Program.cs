
using System;

namespace Deliverable_4_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = 25;
            
            int[] fib = new int[number];
            fib[0] = 0;
            fib[1] = 1;
            
            for (int i = 2; i < number; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }

            
            foreach (int input in fib)
            {
                Console.WriteLine("Fibonacci number = " + input.ToString());
            }
                
                
        }
    }
}