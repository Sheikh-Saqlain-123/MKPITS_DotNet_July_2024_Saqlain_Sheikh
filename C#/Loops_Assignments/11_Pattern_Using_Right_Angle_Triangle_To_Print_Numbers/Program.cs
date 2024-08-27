/* 11. Write a program in C to make such a pattern like a right angle triangle
with a number which will repeat a number in a row.
The pattern like :
1
22
333
4444
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Pattern_Using_Right_Angle_Triangle_To_Print_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int outercounter=1; outercounter<5; outercounter++)
            {
                for (int innercounter=0; innercounter<outercounter; innercounter++)
                {
                    Console.Write(outercounter+" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
