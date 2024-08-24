/*
 4. Write a program of to display in this format using class
Roll No Sub1 Sub2 Sub3 Total Percentage
1 30 25 45 100
2 25 20 25 70
3 20 15 35 70
4 35 30 40 105

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_4_Student_Suubjects___Total_Percentage
{
    public class StudentDetails
    {
        public int rollNo ;
        public int sub1;
        public int sub2;
        public int sub3;
        public int totalPercentage;

        public void GetStudentDetails()
        {

            Console.WriteLine("Enter Student Roll Number :-");
            rollNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Subject 1 Marks :-");
            sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Subject 2 Marks :-");
            sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Subject 3 Marks :-");
            sub3 = Convert.ToInt32(Console.ReadLine());

        }

        public void DisplayStudentDetails()
        {
            totalPercentage = sub1 + sub2 + sub3;
            Console.WriteLine("Student Details:-\nRoll Number:- "+rollNo+"\nSubject 1 Marks:- "+sub1+"\nSubject 2 Marks:- "+sub2+"\nSubject 3 Marks:- "+sub3+"\nTotal Percentage is :- "+totalPercentage);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentDetails student = new StudentDetails();
            Console.WriteLine("Press 1 to Start:   OR   Press 2 to Exit:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:

                    Console.WriteLine("Enter Total Number Of Students Details You want to Print :-");
                    int totalstudents = Convert.ToInt32(Console.ReadLine());
                    for (int count = 0; count < totalstudents; count++)
                    {
                        Console.WriteLine("Enter Student " + count + " Details :-");
                        student.GetStudentDetails();
                        student.DisplayStudentDetails();

                    }

                    break;
                case 2:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice !!");
                    break;
            }
            

            Console.ReadLine();
        }
    }
}
