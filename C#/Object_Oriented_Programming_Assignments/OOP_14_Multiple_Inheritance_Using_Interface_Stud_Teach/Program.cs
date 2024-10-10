using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14_Multiple_Inheritance_Using_Interface_Stud_Teach
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

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    interface IStudent
    {
        double Percentage { get; set; }
        void DisplayStudentInfo();
    }

    interface ITeacher
    {
        double Salary { get; set; }
        void DisplayTeacherInfo();
    }

    class Student : Person, IStudent
    {
        public double Percentage { get; set; }

        public Student(string name, int age, double percentage)
            : base(name, age)
        {
            Percentage = percentage;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine("Percentage is :- "+Percentage);
        }
    }

    class Teacher : Person, ITeacher
    {
        public double Salary { get; set; }

        public Teacher(string name, int age, double salary)
            : base(name, age)
        {
            Salary = salary;
        }

        public void DisplayTeacherInfo()
        {
            Console.WriteLine("Salary is :- "+Salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            char opt = 'y';
            do
            {
                Console.WriteLine("Enter Student Details:- ");
                Console.WriteLine("Enter Student name:- ");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Student Age:- ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student percentage:- ");
                double per = Convert.ToInt32(Console.ReadLine());
                Student student = new Student(name, age, per);
                Console.WriteLine("-------------------------------------------------------------------------------------------------/n");
                Console.WriteLine("Student Information:");
                student.DisplayPersonInfo();
                student.DisplayStudentInfo();
                Console.WriteLine("-------------------------------------------------------------------------------------------------/n");

                Console.WriteLine("-------------------------------------------------------------------------------------------------");
                Console.WriteLine("Enter Teacher Details:- ");
                Console.WriteLine("Enter Teacher name:- ");
                string teacherName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Teacher Age:- ");
                int teacherAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Teacher Salary:- ");
                int salary = Convert.ToInt32(Console.ReadLine());
                Teacher teacher = new Teacher(teacherName, teacherAge, salary);
                Console.WriteLine("-------------------------------------------------------------------------------------------------/n");
                Console.WriteLine("\nTeacher Information:");
                teacher.DisplayPersonInfo();
                teacher.DisplayTeacherInfo();
                Console.WriteLine("-------------------------------------------------------------------------------------------------/n");

                Console.WriteLine("Press 'y' to Continue:\nOR\nPress 'n' To Exit:");
            } while (opt != 'n');
            Console.Read();
        }
    }
}
