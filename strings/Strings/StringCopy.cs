using System;

namespace Strings
{
    public class StringCopy
    {
        public void StrCp()
        {
            string s1, s2="Not Copied";

            Console.WriteLine("A program to copy string");

            Console.WriteLine("Enter the string: ");
            s1 = Console.ReadLine();

            foreach(char a in s1)
            {
                s2 = s1;
            }
            Console.WriteLine("String Copied");
            Console.WriteLine("Copied String is: " + s2);
        }
    }
}