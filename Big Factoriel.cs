

namespace _2._Big_Factorial
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            BigInteger f = 1;

            for (int i = 2; i <= N; i++)
            {
                f *= i;
            }
            Console.WriteLine(f); 
        }
    }
}
