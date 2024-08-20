using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_WAP_TO_PRINT_DUPLICATE_ELEMENTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Total Array Elements:- ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("  Enter Array Elements:- ");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("  Array Elements are:- ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("  Duplicate Array Elements are:- ");
            for (int outer = 0; outer < size; outer++)
            {
                for (int inner = outer + 1; inner < size; inner++)
                {
                    if (arr[outer] == arr[inner])
                    {
                        Console.WriteLine("Duplicate Element :- " + arr[inner]);
                    }

                }
            }

            Console.Read();
        }
    }
}
