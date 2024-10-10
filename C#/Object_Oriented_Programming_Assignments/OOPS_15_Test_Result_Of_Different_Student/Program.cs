using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_15_Test_Result_Of_Different_Student
{
    class Students
    {
        public int RollNumber { get; set; }
    }

    class Test : Students
    {
        public int Subject1Marks { get; set; }
        public int Subject2Marks { get; set; }
    }

    class Result : Test
    {
        public int TotalMarks { get; set; }

        public void CalculateTotalMarks()
        {
            TotalMarks = Subject1Marks + Subject2Marks;
        }

        public void DisplayResult()
        {
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Subject 1 Marks: " + Subject1Marks);
            Console.WriteLine("Subject 2 Marks: " + Subject2Marks);
            Console.WriteLine("Total Marks: " + TotalMarks);
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Result studentResult = new Result();

            studentResult.RollNumber = 1;
            studentResult.Subject1Marks = 85;
            studentResult.Subject2Marks = 90;

            studentResult.CalculateTotalMarks();
            studentResult.DisplayResult();

            Console.Read();
        }
    }
}
