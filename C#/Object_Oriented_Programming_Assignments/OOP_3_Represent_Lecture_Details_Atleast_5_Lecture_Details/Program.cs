using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_3_Represent_Lecture_Details_Atleast_5_Lecture_Details
{

    public class LectureDetails
    {
        public string LecturerName;
        public string Subject;
        public string NameOfCourse;
        public int NumberOfLectures;

        public void AssignValues()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("Enter the Name of Lecturer :-");
            LecturerName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Name of Subject :-");
            Subject = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Name of Course :-");
            LecturerName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Nubmer of Lectures Assigned to the Lecturer :-");
            LecturerName = Convert.ToString(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------");


        }

        public void DisplayValues()
        {
            int millisecond = 1000;
            Console.Write("\nFetching Data"); Console.Write("."); Thread.Sleep(millisecond); Console.Write("."); Thread.Sleep(millisecond); Console.Write("."); Thread.Sleep(millisecond); Console.Write("."); Thread.Sleep(millisecond); Console.Write("."); Thread.Sleep(millisecond);
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("The Name Of Lecturer is :- "+LecturerName);
            Console.WriteLine("The Name Of Subject is :- "+Subject);
            Console.WriteLine("The Name Of Course is :- "+NameOfCourse);
            Console.WriteLine("The Nubmer of Lectures Assigned to the Lecturer is :- "+NumberOfLectures);
            Console.WriteLine("-------------------------------------------------------------------------------------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            char option = 'y';

            do
            {
                LectureDetails obj = new LectureDetails();
                Console.WriteLine("Please Select Any One Function :-");
                Console.WriteLine("Press ' 1 ' To Enter Lecturer Details :   OR    Press ' 2 ' To  Display All Lecturer's Entered Lecturers Details Before Exitiing:");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        obj.AssignValues();
                        break;
                    case 2:
                        obj.DisplayValues();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice !!!");
                        break;
                }


                Console.WriteLine("Do You Want to Continue :- 'y'---> Yes     OR      'n'--->No  :  ");
                option =Convert.ToChar(Console.ReadLine());
            }
            while (option == 'y');
            
            Console.ReadLine();
        }
    }
}
