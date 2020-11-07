using System;

namespace Strings
{
    public class StringMax
    {
        public static void Main(string[] args)
        {
            string str;
            int[] count = new int[256];
            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                count[str[i]]++;    
            }
            int max = -1;
            char result = ' ';

            for (int i = 0; i < str.Length; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }
            }
            Console.WriteLine("Maximum occuring character: "+ result);
            Console.WriteLine("Frequency of "+result+" is "+max);
        }
    }
}
