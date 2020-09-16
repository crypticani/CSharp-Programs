//A program to print fibonacci series of n terms

using System;
namespace myproject
{
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A program to print fibonacci series of n terms");
            int m, n, a = 0,b=1;

            Console.WriteLine("Enter the value of n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci Series: ");
            for (m = 1; m <= n; m++)
            {
                Console.WriteLine(a);
                int next = a + b;
                a = b;
                b = next;

            }
        }
    }
}
