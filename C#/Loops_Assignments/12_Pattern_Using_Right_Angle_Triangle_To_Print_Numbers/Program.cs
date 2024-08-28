/* 12. Write a program in C to make such a pattern like a right angle triangle
with the number increased by 1.
The pattern like :
1
2 3
4 5 6
7 8 9 10
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Pattern_Using_Right_Angle_Triangle_To_Print_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Result = 1;
            for (int outercounter=1; outercounter<=4;outercounter++)
            {
                for (int innercounter=1; innercounter<=outercounter; innercounter++)
                {
                    Console.Write((Result++)+" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
