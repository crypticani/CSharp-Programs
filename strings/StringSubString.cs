using System;

namespace Strings
{
    public class StringSubString
    {
        public static void Main(string[] args)
        {
            string str, substr;
            Console.WriteLine("A program to check if the given substring is present in string.");
            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();
            Console.WriteLine("Enter the Sub-string");
            substr = Console.ReadLine();

            int flag = 0;
            for(int i=0;i<=str.Length-substr.Length;i++)
            { 
                for(int j=i;j<i+substr.Length;j++)
                {
                    flag=1;
                    if (str[j]!=substr[j-i])
                    {
                        flag=0;
                        break;
                    }
                }
                if (flag==1)
                    break;
            }

            if (flag == 1)
            {
                Console.WriteLine("The substring is present in String");
            }
            else
            {
                Console.WriteLine("The substring is NOT present in String");
            }
        }
    }
}
