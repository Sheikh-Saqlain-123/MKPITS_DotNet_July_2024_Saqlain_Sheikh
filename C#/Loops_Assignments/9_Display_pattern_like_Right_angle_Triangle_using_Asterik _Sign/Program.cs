using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Display_pattern_like_Right_angle_Triangle_using_Asterik__Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number OF Rows you want to print the Right Angle Triangle In :- ");
            int numOfRows = Convert.ToInt32(Console.ReadLine());
            for(int rows=0; rows < numOfRows; rows++)
            {
                for(int column=0; column < rows; column++)
                {
                    Console.Write("*  ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
