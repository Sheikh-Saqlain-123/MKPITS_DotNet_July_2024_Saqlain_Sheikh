/*  7. Write a program in C to display the multiplier table vertically from 1 to n.
Test Data :
Input upto the table number starting from 1 : 8
Expected Output :
Multiplication table from 1 to 8
1x1 = 1,
2x1 = 2,
3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
...
1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10
= 80 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Multiplier_Table_Vertically_From_1_To_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter the Total Numbers to Print Their Table:-");
             number = Convert.ToInt32(Console.ReadLine());
            for (int row = 1; row <= number; row++)
            {
                Console.WriteLine("Table Of "+number+" :-");
                for (int col = 1; col < 11; col++)
                {
                    //number = row * col;
                    Console.WriteLine(row+"*"+col+" = "+(row*col)+"\t");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
