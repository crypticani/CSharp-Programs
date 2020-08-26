/*A program to print the following pyramid pattern:
1     
12    
123   
1234  
12345 
123456
*/

using System;
namespace myproject
{
    public class Pattern_HalfPyramidNum
    {
        public static void Main(string[] args)
        {
            int space, rows;
            Console.WriteLine("A program to print pyramid pattern of numbers:");
            Console.WriteLine("Enter the number of rows:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= rows; i++)
            {

                for (int num = 1; num <= i; num++)
                {
                    Console.Write(num);
                }
                for (space = i; space < rows; space++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
