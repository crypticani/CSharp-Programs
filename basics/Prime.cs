// A program to check whether the number is prime or not.

using System;
namespace myproject
{
    public class Prime
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("A program to check whether the number is prime or not.");
            int m, n, count=0, i,j;

            Console.WriteLine("Enter the number of iterations: ");
            j = int.Parse(Console.ReadLine());

            for (i = 0; i < j; i++)
            {
                Console.WriteLine("Enter the number: ");
                n = int.Parse(Console.ReadLine());

                for (m = 2; m <= n / 2; m++)
                {
                    if (n % m == 0)
                    {
                        count = count + 1;
                    }

                }
                if (count == 0)
                {
                    Console.WriteLine("The number " + n + " is a prime number");
                }
                else
                {
                    Console.WriteLine("The number " + n + " is NOT a prime number");
                    count = 0;
                }
            }
        }
    }
}
