/*A program to print the following pyramid pattern:
******      
*****     
****    
***   
**  
* 
*/

using System;
namespace myproject
{
    public class Pattern_HalfPyramidInverse
    {
        public static void Main(string[] args)
        {
            int space, rows;
            Console.WriteLine("A program to print pyramid pattern");
            Console.WriteLine("Enter the number of rows:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i <= rows; i++)
            {

                for (int star = rows; star >i; star--)
                {
                    Console.Write("*");
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
