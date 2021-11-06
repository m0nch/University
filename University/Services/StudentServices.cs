using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class StudentServices
    {
        List<Student> _students; 

        public StudentServices(int count)
        {
            Random rnd = new Random();
            _students = new List<Student>(count);

            for (int i = 0; i < count; i++)
            {
                string name = "Name" + (i + 1);
                int age = rnd.Next(16, 22);

                Student student = new Student(name, age);
                _students.Add(student);
            }
        }

        public Student Get(Guid id)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == id)
                {
                    return _students[i];
                }
            }
            return default(Student);
        }
        public List<Student> GetAll()
        {
            return _students;
        }

        public List<Student> GetAllByTeacher(Guid id)
        {
            List<Student> group = new List<Student>();
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._teacher._id == id)
                {
                    group.Add(_students[i]);
                }
            }
            return group;
        }
        public void Add(Student student)
        {
            _students.Add(student);
        }

        public void Remove(Student student) 
        {
            _students.Remove(student);
        }

        public void Update(Student student)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i]._id == student._id)
                {
                    _students[i] = student;
                }
            }
        }
    }
}
