using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public Guid Id;
    public string Name;
    public int age;
    public string group;
}

namespace Test
{

    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();

            student.Name = "Alice";
            student.age = 21;
            student.Id = Guid.NewGuid();
            student.group = "asdfghj";
            return student;
        }
        static void Print(Student student)
        {
            Console.WriteLine("Student information");
            Console.WriteLine($"Name is: {student.Name}");
            Console.WriteLine($"Age is: {student.age}");
            Console.WriteLine($"Id:{student.Id}");
            Console.WriteLine($"Group:{student.group}");
        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            Print(firstStudent);
        }
    }
}
