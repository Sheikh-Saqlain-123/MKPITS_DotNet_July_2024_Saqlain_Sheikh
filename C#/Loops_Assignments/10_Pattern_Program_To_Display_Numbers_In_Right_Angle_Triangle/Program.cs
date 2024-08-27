/* 10. Write a C program to display a pattern like a right angle triangle with a
number.
The pattern like :
1
12
123
1234  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Pattern_Program_To_Display_Numbers_In_Right_Angle_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int outercounter=1; outercounter<=5; outercounter++)
            {
                for (int innercounter=1; innercounter<=outercounter; innercounter++)
                {
                    Console.Write(innercounter+"  ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
