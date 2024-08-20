/* 1. Write a program in C to display the first 10 natural numbers.
Expected Output :
1 2 3 4 5 6 7 8 9 10
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_To_Display_The_First_10_Natural_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number To Check Whether it is Natural Number or Not:- ");
            int chk_Natural_Number = Convert.ToInt32(Console.ReadLine());
            if (chk_Natural_Number > 0)
            {
                Console.WriteLine("The Number:-"+chk_Natural_Number+" is a Natural Number !");
            }
            else
            {
                Console.WriteLine("The Number:-" + chk_Natural_Number + " is Not a Natural Number !");
            }

            Console.Read();
        }
    }
}
