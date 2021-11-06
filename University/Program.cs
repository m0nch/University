using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {

            int studentCountInGroups = default;
            int studentCountInLastGroup = default;

            Console.Write("How many students are in the University: ");
            int studentCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>(studentCount);

            Console.Write("How many teachers are in the University: ");
            int teacherCount = int.Parse(Console.ReadLine());

            List<Teacher> teachers = new List<Teacher>(teacherCount);

            if (studentCount % teacherCount == 0)
            {
                studentCountInGroups = studentCount / teacherCount;
                Console.WriteLine($"In {teacherCount} groups are {studentCountInGroups} students");
            }
            else
            { 
                studentCountInGroups = studentCount / teacherCount;
                studentCountInLastGroup = studentCount / teacherCount + studentCount % teacherCount;
                Console.WriteLine($"In {teacherCount - 1} groups are {studentCountInGroups} students, in last groups are {studentCountInLastGroup} students");
            }

            TeacherServices teacherServices = new TeacherServices(teacherCount);
            teachers = teacherServices.GetAll();
            StudentServices studentServices = new StudentServices(studentCount);
            students = studentServices.GetAll();

            UniversityServices universityServices = new UniversityServices(studentServices, teacherServices);
            universityServices.Distribute();

            universityServices.Print();
            teacherServices.GetGroup(teachers[0]._id);
            teachers[3].Print();
            Console.ReadKey();


        }
    }
}
