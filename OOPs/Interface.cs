// A program in C# to understand the concepts of interface

using System;

namespace OOPs
{
    public class Interface
    {
        public interface Cs
        {
            void Fun();
        }
        
        private class Bca:Cs
        {
            public void Fun()
            {
                Console.WriteLine("BCA");
            }
        }
        private class Mca:Cs
        {
            public void Fun()
            {
                Console.WriteLine("MCA");
            }
        }
        
        public class MyClass
        {
            public static void Main(string[] args)
            {
                Cs c;
                c = new Bca();
                c.Fun();
                c = new Mca();
                c.Fun();
            }
        }
    }
}
