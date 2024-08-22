using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Display_The_Cube_Of_The_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number To Calculate Its Cube:- ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int Cube = Number * Number * Number;

            Console.WriteLine("Cube Of Number Is:- "+Cube);
            Console.Read();
        }
    }
}
