//A program to check if the given number is Armstrong Number or not

using System;
namespace myproject
{
    public class Armstrong
    {
        public static void main(string[] args)
        {
            Console.WriteLine("A program to check if the given number is Armstrong Number or not");
            int n, m, num ,d; 
            double result = 0, number;

            Console.WriteLine("Enter the number of iterations: ");
            n = int.Parse(Console.ReadLine());
            for (m = 0; m < n; m++)
            {
                Console.WriteLine("Enter the number of digits: ");
                d = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number: ");
                num = int.Parse(Console.ReadLine());
                number = num;
                for(int i=0;i<d;i++)
                { 
                int rem = num % 10;  //split last digit from number 
                    double power = Math.Pow(rem, d);
                    //Console.WriteLine(power);
                     result = result + power;
                    num = num / 10;
                }
                if(number == result)
                {
                    Console.WriteLine(number + " is an Armstrong number.");
                    result = 0;
                }
                else
                {
                    Console.WriteLine(number + " is NOT an Armstrong number");
                    result = 0;
                }
            }
        }
    }
}
