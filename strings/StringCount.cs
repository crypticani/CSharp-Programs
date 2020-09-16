/* A program in C# to count the total number of alphabets, digits and special characters. */

using System;
namespace String
{
    public class StringCount
    {
        public static void Main(string[] args)
        {
            string str;
            int alpha=0, digit=0, sym=0;

            Console.WriteLine("Enter the main string: ");
            str = Console.ReadLine();

            foreach(char s in str)
                {
                if(s>=65&&s<=90||s>=97&&s<=122) //Alphabet
                    {
                    alpha += 1;
                    }
                else if(s>=48&&s<=57) //Digits
                {
                    digit += 1;
                }
                else
                {
                    sym += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Number of Alphabets: "+alpha);
            Console.WriteLine("Number of Digits: " + digit);
            Console.WriteLine("Number of Special Characters: " + sym);
        }
    }
}
