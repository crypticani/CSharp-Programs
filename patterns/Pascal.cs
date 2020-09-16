/*
A program to print the Pascal's triangle.
        1 
      1 1 
     1 2 1 
    1 3 3 1 
   1 4 6 4 1 
  1 5 10 10 5 1

*/
using System;
namespace myproject
{
    public class Pascal
    {
        public static int Factorial(int fact)
        {
            int m, f = 1;
            for (m = 1; m <= fact; m++)
            {
                f = f * m;
            }
            return f;
        }

        public static int Ncr(int a, int b)
        {
            return Factorial(a)/(Factorial(b) * Factorial(a - b));
        }

        public static void Main(string[] args)
        {
            int space, rows, c;
            Console.WriteLine("A program to print the Pascal's triangle.");
            Console.WriteLine("Enter the number of rows:");
            rows = int.Parse(Console.ReadLine());

            for (int i = 0; i <= rows; i++)
            {
                for (space = i; space < rows; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                   c = Ncr(i, j);
                    Console.Write(c+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
