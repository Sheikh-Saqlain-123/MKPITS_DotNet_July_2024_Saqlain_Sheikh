/*
 4. WAP to print the Largest Number from an Array. ( any onr may get asked-----> to find 2nd Largest or 3rd Largest or any  ).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_WAP_TO_PRINT_LARGEST_NUMBER_FROM_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size :-");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int max1, max2, max3;
            Console.WriteLine("Enter Array Elements :-");
            for (int position = 0; position < size; position++)
            {
                arr[position] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe Entered Array Elements are:-");
            for (int position = 0; position < size; position++)
            {
                Console.Write(arr[position] + " ");
            }
            Console.WriteLine();

            max1 = 0;
            max2 = 0;
            max3=0;
            for (int count = 0; count < size; count++)
            {
                if (arr[count] > max1)
                {
                    max2 = max1;
                    max1 = arr[count];
                }
                else if (arr[count] > max2)
                {
                    if (max1 == max2)
                    {
                        break;
                    }
                    max3 = max2;
                    max2 = arr[count];
                }
                else if (arr[count] > max3)
                {
                    int tmp = max3;
                    max3 = arr[count];
                }
            }
            Console.WriteLine("Here 1st Largest Element in the Array is:-" + max1);  //First Largest.
            Console.WriteLine("Here 2nd Largest Element in the Array is:-" + max2);  //First Largest.
            Console.WriteLine("Here 3rd Largest Element in the Array is:-" + max3);  //First Largest.

            Console.Read();
        }
    }
}
