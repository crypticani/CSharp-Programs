using System;
namespace myproject
{
    public class Factorial
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A program to print factorial of the given number n");
            int m, n, fact = 1;

            Console.WriteLine("Enter the value of n: ");
            n = int.Parse(Console.ReadLine());
            for (m = 1; m <= n; m++)
            {
                fact = fact * m;
            }
            Console.WriteLine(fact);
        }
    }
}
