/* 3. Write a program in C to display n terms of natural numbers and their sum.
Test Data : 7
Expected Output :
The first 7 natural number is :
1 2 3 4 5 6 7
The Sum of Natural Number upto 7 terms : 28 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Display_N_Terms_of_Natural_Numbers_and_Their_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number;
            int Sum = 0;
            int Total_Numbers = 0;
            Console.WriteLine("Enter Total Natural Numbers You Want To Find Sum Of:- ");
            Total_Numbers = Convert.ToInt32(Console.ReadLine());

            for (int count = 1; count <= Total_Numbers; count++)
            {
                Console.WriteLine("Enter Natural Number "+count+" :-");
                Number = Convert.ToInt32(Console.ReadLine());
                Sum += Number;
            }
            Console.WriteLine("Sum Of Natural Numbers is :- "+Sum);
            Console.Read();
        }
    }
}
