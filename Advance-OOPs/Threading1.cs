using System;  
using System.Threading;

namespace Threading
{
    class Program
    {
        static void T1()
        {
            Console.WriteLine("Thread1 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1 executing");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1 executing");
        }

        static void T2()
        {
            Console.WriteLine("Thread2 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread2 executing");
            Thread.Sleep(5000);
            Console.WriteLine("Thread2 executing");
        }

        public static void Main()
        {
            Thread t1 = new Thread(T1);
            Thread t2 = new Thread(T2);
            t1.Start();
            t2.Start();
        }
    }
}
