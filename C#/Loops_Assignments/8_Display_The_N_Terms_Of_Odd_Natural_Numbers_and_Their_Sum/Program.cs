/*  8. Write a C program to display the n terms of odd natural numbers and their
sum.
Test Data
Input number of terms : 10
Expected Output :
The odd numbers are :1 3 5 7 9 11 13 15 17 19
The Sum of odd Natural Number upto 10 terms : 100 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Display_The_N_Terms_Of_Odd_Natural_Numbers_and_Their_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n number of terms : ");
            int numOfTerms = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int oddNumber ;
            Console.WriteLine("The Odd Numbers Are :- ");
            for (int count=1; count<= numOfTerms; count++)
            {
                oddNumber = 2 * count - 1;
                Console.WriteLine(oddNumber);
               
                sum = sum + oddNumber;
            }
            Console.Write("The Sum of odd Natural Number upto 10 terms :-"+sum);
            Console.Read();
        }
    }
}
