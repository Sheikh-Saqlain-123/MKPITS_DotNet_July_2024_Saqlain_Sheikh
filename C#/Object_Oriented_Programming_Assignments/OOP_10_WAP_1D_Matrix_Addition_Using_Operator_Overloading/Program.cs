using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_10_WAP_1D_Matrix_Addition_Using_Operator_Overloading
{
    class Matrix
    {
        private int[] elements;

        // Constructor to initialize the matrix with elements
        public Matrix(int[] elements)
        {
            this.elements = elements;
        }

        // Overloading the + operator to add two matrices
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.elements.Length != m2.elements.Length)
                throw new ArgumentException("Matrices must be of the same length");

            int[] result = new int[m1.elements.Length];
            Console.WriteLine(result);
            for (int i = 0; i < m1.elements.Length; i++)
            {
                result[i] = m1.elements[i] + m2.elements[i];
            }

            return new Matrix(result);
        }

        // Method to display the matrix elements
        public void Display()
        {
            for (int count=0; count<elements.Length; count++)
            {
                Console.WriteLine(string.Join(" ", elements[count]));
            }
          //  Console.WriteLine(string.Join(" ", elements));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of Array Elements :-");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[size];

            Console.WriteLine("Enter  Array 1 Elements :-");
            for (int count=0; count<array1.Length; count++)
            {
                array1[count] = Convert.ToInt32(Console.ReadLine());
            }
            int[] array2 = new int[size];
            Console.WriteLine("Enter  Array 2 Elements :-");
            for (int count = 0; count < array2.Length; count++)
            {
                array2[count] = Convert.ToInt32(Console.ReadLine());
            }

            Matrix m1 = new Matrix(array1);
            Matrix m2 = new Matrix(array2);

            Matrix result = m1 + m2;

            Console.WriteLine("Result of matrix addition:");
            result.Display();

            Console.Read();
        }
    }
}
