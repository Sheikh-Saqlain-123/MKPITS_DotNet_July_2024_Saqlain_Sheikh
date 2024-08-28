/*
 WAP to find Maximum and Minimum ELement in an Array.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_WAP_TO_FIND_MAXIMUM_AND_MINIMUM_ELEMENT_IN_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER ARRAY SIZE:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int min = 0;int max = 0;
            Console.WriteLine("ENTER ARRAY ELEMENTS:");
            for (int count = 0; count < size; count++)
            {
                arr[count] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ENTERED ELEMENTS IN ARRAY ARE:");
            for (int count = 0; count < size; count++)
            {
                Console.WriteLine(arr[count]);
            }


            Console.WriteLine("MAXIMUM ELEMENT IN ARRAY IS:");
            for (int count = 0; count < size; count++)
            {
                if (arr[count] > max)
                {
                    min = max;
                    max = arr[count];
                    
                }
            }
            Console.WriteLine(max);

            Console.WriteLine("MINIMIM ELEMENT IN ARRAY IS:");
            for (int count = 0; count < size; count++)
            {
                if (arr[count] < min)
                {
                    min = arr[count];
                    
                }
            }
            Console.WriteLine(min);
            Console.Read();
        }
    }
}
