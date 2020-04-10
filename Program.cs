using System;

namespace InheritanceLatihan
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Thomas";
            person.Age = 20;
            person.GetNameAndAge();


            Teacher teacher = new Teacher();
            teacher.Name = "Thomas";
            teacher.Age = 20;
            teacher.TeacherId = "190302";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Student student = new Student();
            student.Name = "Thomas";
            student.Age = 20;
            student.StudentId = "190302";
            student.Email = "onny.s@students.amikom.ac.id";
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
 }

