using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class TeacherServices
    {
        List<Teacher> _teachers;
        public TeacherServices(int count)
        {
            Random rnd = new Random();
            _teachers = new List<Teacher>(count);

            for (int i = 1; i < count + 1; i++)
            {
                string name = "Teacher" + (i);
                int age = rnd.Next(25, 65);

                Teacher teacher = new Teacher(name, age);
                _teachers.Add(teacher);
            }
        }

        public Teacher Get(Guid id)
        {
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == id)
                {
                    return _teachers[i];
                }
            }
            return default(Teacher);
        }
        public List<Teacher> GetAll()
        {
            return _teachers;
        }

        public List<Student> GetGroup(Guid id)
        {
            List<Student> group = new List<Student>();
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == id)
                {
                    group = _teachers[i]._students;
                }
            }
            return group;
        }

        public void Add(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void Remove(Teacher teacher)
        {
            _teachers.Remove(teacher);
        }

        public void Update(Teacher teacher)
        {
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == teacher._id)
                {
                    _teachers[i] = teacher;
                }
            }
        }

    }
}
