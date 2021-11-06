using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class UniversityServices
    {
        TeacherServices _teacherServices;
        StudentServices _studentServices;

        //List<Student> _students;
        //List<Teacher> _teachers;
        public UniversityServices(StudentServices studentServices, TeacherServices teacherServices)
        {
            _teacherServices = teacherServices;
            _studentServices = studentServices;
        }
        public void Distribute()
        {
            List<Student> students = _studentServices.GetAll();
            List<Teacher> teachers = _teacherServices.GetAll();

            int studentCount = students.Count;
            int teacherCount = teachers.Count;
            
            int avarageStudents = studentCount / teacherCount;
            for (int i = 0; i < teachers.Count - 1; i++)
            {
                List<Student> currentTeachersStudets = new List<Student>(avarageStudents);
                for (int j = 0; j < avarageStudents; j++)
                {
                    int studentIndex = i * avarageStudents + j;
                    currentTeachersStudets.Add(students[studentIndex]);
                }
                teachers[i].AssignStudents(currentTeachersStudets);
            }
            int leftStudents = avarageStudents + studentCount % teacherCount;
            for (int i = teacherCount-1; i < teacherCount; i++)
            {
                List<Student> currentTeachersStudets = new List<Student>(leftStudents);
                for (int j = 0; j < leftStudents; j++)
                {
                    int studentIndex = studentCount - leftStudents + j;
                    currentTeachersStudets.Add(students[studentIndex]);
                }
                teachers[i].AssignStudents(currentTeachersStudets);
            }
        }


        public void Print()
        {
            List<Teacher> teachers = _teacherServices.GetAll();
            Console.WriteLine($"Group ");
            for (int i = 0; i < teachers.Count; i++)
            {
                teachers[i].Print();
            }

        }
    }
}
