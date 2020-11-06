// A program in C# to understand the concepts of interface

using System;
using OOPBasics;

namespace OOPBasics
{
    class Constructor
    {
        public class CSharp
        {
            public int roll;
            public string name;
            public int marks;

            public CSharp(int a, string b, int c)
            {
                roll = a;
                name = b;
                marks = c;
            }
        }
    }
    public class MyClass
        {
            public static void Main(string[] args)
            {
                Constructor.CSharp a = new Constructor.CSharp(6, "Aniket", 8);
                Console.WriteLine("Roll: "+ a.roll+"\nName: "+a.name+"\nMarks: "+a.marks);
            }
        }
}
