using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_SUM_OF_TWO_GREATEST_NUMBERS_FROM_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstMax = 0;
            int secondMax = 0;
            Console.WriteLine("Enter Array Size:- ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter Array Elements:- ");
            for (int count = 0; count < size; count++)
            {
                array[count] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enterd Elements in  Array are :- ");
            for (int count = 0; count < size; count++)
            {
                Console.WriteLine(array[count]);
            }
            for (int count = 0; count < size; count++)
            {
                if (array[count] > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = array[count];
                }
                else if (array[count] > secondMax)
                {
                    secondMax = array[count];
                }
              
            }
            Console.WriteLine("This First Max Element is:- "+firstMax);
            Console.WriteLine("This Second Max Element is:- " + secondMax);
            int sum = firstMax + secondMax;
            Console.WriteLine("Their Sum is:- "+sum);
            Console.ReadLine();
        }
    }
}
