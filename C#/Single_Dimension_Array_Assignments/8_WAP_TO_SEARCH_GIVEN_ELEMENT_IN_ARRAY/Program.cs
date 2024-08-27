/*
 WAP to search a given element in an array.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_WAP_TO_SEARCH_GIVEN_ELEMENT_IN_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER ARRAY SIZE:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            int Searchedposition = 0;
            Console.WriteLine("ENTER ARRAY ELEMENTS:");
            for (int count=0;count<size;count++)
            {
                arr[count]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ENTERED ELEMENTS IN ARRAY ARE:");
            for (int count = 0; count < size; count++)
            {
                Console.WriteLine(arr[count]);
            }

            Console.WriteLine("SEARCH ELEMENT IN ARRAY :- ");
            int searchElement = Convert.ToInt32(Console.ReadLine());
            for ( int counter = 0; counter < size; counter++)
            {
                if (arr[counter]==searchElement)
                {
                    //position = counter;
                    Searchedposition = counter;
                    Console.WriteLine(Searchedposition);
                    Console.Write("THE SEARCHED ELEMENT: " + searchElement + " IS AT POSITION: [ " + Searchedposition + " ]");
                }
               
            }

            Console.WriteLine();
            Console.Read();
        }
    }
}
