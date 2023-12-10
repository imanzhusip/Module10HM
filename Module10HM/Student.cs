using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10HM
{
    class Student : Person
    {
        public int Course { get; set; }
        public Teacher Advisor { get; internal set; }

        public Student(string name, int age, int course) : base(name, age)
        {
            Course = course;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Course: {Course}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Course: {Course}";
        }

        public static Student RandomStudent()
        {
            Random random = new Random();
            string[] names = { "Student1", "Student2", "Student3" };
            string name = names[random.Next(names.Length)];
            int age = random.Next(18, 30);
            int course = random.Next(1, 6);
            return new Student(name, age, course);
        }
    }
}
