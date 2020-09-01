/*
A program to print the following diamond like pattern:
   *
  ***
 *****
*******
 *****
  ***
   *

*/  

using System;
namespace myproject
{
    public class Pattern_diamond
    {
        public static void main(string[] args)
        {
            int rows, i, j, space;

            Console.Write("Enter the number of rows: ");
            rows = int.Parse(Console.ReadLine());

            for (i = 0; i <= rows / 2; i++)
            {
                for (space = i; space < rows / 2; space++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = rows / 2 + 1; i >= 1; i--)
            {
                for (space = i; space <= rows / 2 + 1; space++)
                {
                    Console.Write(" ");
                }
                for (j = i * 2 - 4; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
