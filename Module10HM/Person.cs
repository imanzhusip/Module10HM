using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10HM
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public static Person RandomPerson()
        {
            Random random = new Random();
            string[] names = { "Alice", "Bob", "Charlie", "David", "Eva" };
            string name = names[random.Next(names.Length)];
            int age = random.Next(18, 30);
            return new Person(name, age);
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Name == p2.Name && p1.Age == p2.Age;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }
    }
}
