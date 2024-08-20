using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Print_Sum_Of_UserEntered_Array_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Total Array Elements:- ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int sum = 0;

            Console.WriteLine("Enter  Array Elements:- ");
            foreach (int var in arr)
            {
                arr[var] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[var];
            }

            Console.WriteLine("Entered  Array Elements Are:- ");
            foreach (int var in arr)
            {
                Console.Write(var + " ");

            }
            Console.WriteLine("Sum is :- " + sum);

            Console.Read();
        }
    }
}
