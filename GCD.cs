using System;
namespace myproject
{
    public class GCD
    {
        public static void Main(string[] args)
        {
            int n, a,b, gcd=1, temp;
            Console.WriteLine("A program to find out the GCD of two numbers");
            Console.WriteLine("Enter the number of iterations: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i<n;i++)
            {
                Console.WriteLine("Enter the numbers:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                /*   for(int z = 1; z<=a && z <= b; z++)
                      {
                          if (a%z==0 && b%z==0)
                              gcd = z;
                      }
                      */
                while (b != 0)
                {
                    temp = b;
                    b = a % b;
                    a = temp;
                }
                gcd = a;
                Console.WriteLine("GCD = " + gcd);
            }
        }
    }
}
