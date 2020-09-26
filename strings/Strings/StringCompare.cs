using System;

namespace Strings
{
    public class StringCompare
    {
        public void StrComp()
        {
        string str1, str2;
            int flag = 0;

            Console.WriteLine("A program to compare two strings.");
            Console.WriteLine("Enter string 1: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter string 2: ");
            str2 = Console.ReadLine();
    
            for(int i=0; i<str1.Length; i++)
            {
                if(str1[i]!=str2[i])
                {
                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;
                }
            }
            
            if(flag==0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are NOT equal");
            }
            else if(flag==1)
            {
                Console.WriteLine(str1 + " and " + str2 + " are Equal");
            }
        }
    }
}