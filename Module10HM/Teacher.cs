using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10HM
{
    class Teacher : Person
    {
        public List<Student> Students { get; set; }

        public Teacher(string name, int age) : base(name, age)
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Students: {Students.Count}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Students: {Students.Count}";
        }

        public static Teacher RandomTeacher()
        {
            Random random = new Random();
            string[] names = { "Teacher1", "Teacher2", "Teacher3" };
            string name = names[random.Next(names.Length)];
            int age = random.Next(30, 60);
            return new Teacher(name, age);
        }
    }
}
