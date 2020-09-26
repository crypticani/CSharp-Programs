using System;

namespace OOPs
{
    public class MethodOverloading
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }

        public static void main()
        {
            int sum1 = Sum(23, 34);
            double sum2 = Sum(43.54, 43.6);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}
