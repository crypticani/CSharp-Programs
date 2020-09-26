using System;

namespace OOPs
{
    public class MethodOverriding
    {
        public class Cs
        {
            public virtual void Fun()
            {
                Console.WriteLine("Bca");
            }
        }
        
        public class Mca:Cs
        {
            public override void Fun()
            {
                Console.WriteLine("MCA");
            }
        }
        
        private class Bca:Cs
        {
            public override void Fun()
            {
                Console.WriteLine("BCA");
            }
        }
        
        public static void main()
            {
                Cs c;
                c = new Bca();
                c.Fun();
                c = new Mca();
                c.Fun();
            }
    }
}
