using System;
namespace test
{
    class Student
    {
        private int roll;
        private string name;
        public int Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student A = new Student();
            A.Roll = 6;
            A.Name = "Aniket";
            Console.WriteLine("Roll: " + A.Roll);
            Console.WriteLine("Name: " + A.Name);
        }
    }
}
