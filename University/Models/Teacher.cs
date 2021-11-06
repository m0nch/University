﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Teacher
    {
        public Guid _id;
        public string _name;
        public int _age;
        public List<Student> _students;
        
        public Teacher()
        {
            _id = Guid.NewGuid();
        }
        
        public Teacher(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
        }
        
        public void AssignStudents(List<Student> students)  //It's not my idea, this help from a friend
        {
            _students = students;
        }

        public void Print()
        {
            Console.WriteLine($"--------------------\nTeacher name -- {_name} age -- {_age} Id -- {_id}");
            Console.WriteLine("Students list");
            for (int i = 0; i < _students.Count; i++)
            {
                _students[i].Print();
            }
        }

    }
}
