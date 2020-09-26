// A program in C# to understand the concepts of Abstraction and abstract classes

using System;

namespace OOPs
{
    public class Abstraction
    {
        abstract class Cs
        {
            public abstract void Fun();
        }
        
        private class Bca:Cs
        {
            public override void Fun()
            {
                Console.WriteLine("Bca");
            }
        }
        
        private class Mca:Cs
        {
            public override void Fun()
            {
                Console.WriteLine("MCA");
            }
        }
        
        private class BSc:Cs
        {
            public override void Fun()
            {
                Console.WriteLine("BSc IT");
            }
        }
        
        public class MyClass
        {
            public static void Main()
            {
                Cs c;
                c = new Bca();
                c.Fun();
                c = new Mca();
                c.Fun();
                c = new BSc();
                c.Fun();
            }
        }
    }
}
