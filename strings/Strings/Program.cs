using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A program for some basic string operations.");
            Console.WriteLine("Press any key to continue.");
            StringCompare comp = new StringCompare();
            StringCopy cp = new StringCopy();
            StringType type = new StringType();

            int flag = 1;
            while(flag==1)
            {
                Console.ReadLine();
                Console.WriteLine("Enter your choice: \n 1. String Compare\n 2. String Copy\n 3. String Type\n0. Exit");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        comp.StrComp();
                        break;
                    case 2:
                        cp.StrCp();
                        break;
                    case 3:
                        type.StrType();
                        break;
                    case 0:
                        flag = 0;
                        break;
                    default:
                        Console.WriteLine("Please enter right choice.");
                        break;
                }
            }
        }
    }
}