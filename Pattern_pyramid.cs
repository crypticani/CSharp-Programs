/*A program to print the following pyramid pattern:
         *
      * * *
    * * * * *
  * * * * * * *
* * * * * * * * *
*/

using System;
namespace myproject
{
    public class Pattern_pyramid
    {
        public static void Main(string[] args)
        {
            int space, rows;
             Console.WriteLine("A program to print pyramid pattern");
            Console.WriteLine("Enter the number of rows:");
            rows = int.Parse(Console.ReadLine());

            for (int i = 1; i<= rows; i++)
            {
                for (space = i; space < rows; space++)
                {
                    Console.Write(" ");
                }
             for(int star =1; star < (i*2); star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
