using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10HM
{
    class StudentWithAdvisor : Student
    {
        public Teacher Advisor { get; set; }

        public StudentWithAdvisor(string name, int age, int course, Teacher advisor) : base(name, age, course)
        {
            Advisor = advisor;
        }

        public static StudentWithAdvisor RandomStudentWithAdvisor(Teacher advisor)
        {
            var student = RandomStudent();
            student.Advisor = advisor;
            return (StudentWithAdvisor)student;
        }
    }

}
