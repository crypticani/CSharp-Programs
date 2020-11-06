using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = {1, 2, 3};
            try
            {
                Console.WriteLine(myNumbers[5]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
