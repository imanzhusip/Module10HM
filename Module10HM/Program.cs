using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10HM
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 5; i++)
            {
                people.Add(Person.RandomPerson());
                people.Add(Student.RandomStudent());
                people.Add(Teacher.RandomTeacher());
            }

            int personCount = 0;
            int studentCount = 0;
            int teacherCount = 0;

            foreach (var person in people)
            {
                if (person is Student)
                {
                    studentCount++;
                    Student student = person as Student;
                    if (student != null)
                    {
                        student.Course++;
                    }
                }
                else if (person is Teacher)
                {
                    teacherCount++;
                }
                else
                {
                    personCount++;
                }

                Console.WriteLine(person.ToString());
                Console.ReadKey();
            }

            Console.WriteLine($"People: {personCount}, Students: {studentCount}, Teachers: {teacherCount}");
        }
    }
}
