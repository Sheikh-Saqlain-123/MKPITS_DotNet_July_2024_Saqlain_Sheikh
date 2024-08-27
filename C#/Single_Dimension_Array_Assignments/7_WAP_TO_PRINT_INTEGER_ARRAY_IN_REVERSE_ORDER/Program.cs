/*
 WAP to print integer array in Reverse Order.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_WAP_TO_PRINT_INTEGER_ARRAY_IN_REVERSE_ORDER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER ARRAY SIZE:- ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arrr = new int[size];
            Console.WriteLine("ENTER ARRAY ELEMENTS");
            for (int count=0; count<size; count++)
            {
                arrr[count] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ENTERED ELEMENTS ARRAY ARE :- ");
            for (int count = 0; count < size; count++)
            {
                Console.WriteLine(arrr[count]);
            }

            Console.WriteLine("REVERSED ARRAY ELEMENTS ARE :-");
            int reverse = 0;
            for (int count=(arrr.Length)- 1; count>=0; count--)
            {
                reverse =  arrr[count];
                Console.WriteLine(reverse);
            }

            Console.Read();
        }
    }
}
