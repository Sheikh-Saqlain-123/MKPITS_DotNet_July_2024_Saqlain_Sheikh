using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__Sum_Of_The_First_10_Natural_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            Console.WriteLine("The First 10 Natural numbers Are:- ");
            for (int Number=0; Number<11; Number++)
            {
                Console.WriteLine(Number);
                Sum += Number; 
            }
            Console.WriteLine("The Sum Of First 10 Numbers:-  " +Sum);
            Console.Read();
        }
    }
}
