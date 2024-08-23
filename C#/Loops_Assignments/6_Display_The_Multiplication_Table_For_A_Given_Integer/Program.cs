/* 6. Write a program in C to display the multiplication table for a given integer.
Test Data :
Input the number (Table to be calculated) : 15
Expected Output :
15 X 1 = 15 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__Display_The_Multiplication_Table_For_A_Given_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number To Display Its Multiplication Table:- ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication Table Of "+Number+" :-");
            for(int count=1; count<11; count++)
            {
                Console.WriteLine(Number+"\t*\t"+count+"\t=\t"+(Number * count));
            }
            Console.Read();
        }
    }
}
