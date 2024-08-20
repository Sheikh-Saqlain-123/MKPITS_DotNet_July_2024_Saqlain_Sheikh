/* 4. Write a program in C to read 10 numbers from the keyboard and find their
sum and average.
Test Data :
Input the 10 numbers :
Number-1 :2 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4_Find__Sum_And_Average_Of_Numbers_From_User_Inputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers Of Your Choice:- ");
            int Size = Convert.ToInt32(Console.ReadLine());
            int Number;
            int Sum = 0;
            int Average = 0;

            for(int count=1; count<=Size; count++)
            {
                Console.WriteLine("Enter Number "+count+" :-");
                Number = Convert.ToInt32(Console.ReadLine());

                Sum += Number;
                
            }
            
            Average = Sum/Size;
            Console.WriteLine("The Sum Of Numbers Inputted From User Is :- "+Sum);
            Console.WriteLine("The Average Of Numbers Inputted From User Is :- " + Average);
            Console.Read();
        }
    }
}
