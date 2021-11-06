using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student
    {
        public Guid _id;
        public string _name;
        public int _age;
        public Teacher _teacher;

        public Student()
        {
            _id = Guid.NewGuid();
        }

        public Student(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Name -- {_name} age -- {_age} Id -- {_id} teacher {_teacher._name}");
        }
    }
}
