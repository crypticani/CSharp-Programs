using System;
namespace myproject
{
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A program to print fibonacci series of n numbers");
            int m, n, a = 0;

            Console.WriteLine("Enter the value of n: ");
            n = int.Parse(Console.ReadLine());
            for (m = 0; m < n; m++)
            {
                a = a + m;
                Console.WriteLine(a);
            }
        }
    }
}
