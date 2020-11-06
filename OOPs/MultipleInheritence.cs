// A program to understand the concepts of multiple inheritence

using System;
namespace OOPs
{
    public class MultipleInheritence
    {
        class MainClass
        {
            public void Print()
            {
                Console.WriteLine("Print");
            }
        }
        interface MainClass1
        {
            public void Print1();
        }
        class Subclass : MainClass, MainClass1
        {
            void Print2()
            {
                Console.WriteLine("Print 2");
            }
            public void Print1()
            {
                Console.WriteLine("Print 1");
            }
            static void Main(string[] args)
            {
                Subclass s = new Subclass(); //creating object
                //accessing methods of parent classes
                s.Print();
                s.Print1();
                s.Print2();
            }
        }
    }
}
