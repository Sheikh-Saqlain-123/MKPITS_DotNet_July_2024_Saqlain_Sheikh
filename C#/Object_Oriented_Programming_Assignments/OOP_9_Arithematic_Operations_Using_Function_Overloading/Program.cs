using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_9_Arithematic_Operations_Using_Function_Overloading
{
    //class ArithematicOperations
    //{

    //    public void Operation(int num1, int num2)
    //    {
    //        Console.WriteLine("The Addition is :-"+(num1 + num2));
    //    }
    //    public void Operation(int num1,int num2)
    //    {
    //        Console.WriteLine("The Substraction is :-" + (num1 - num2));
    //    }
    //    public void Operation(int num1, int num2)
    //    {
    //        Console.WriteLine("The Division is :-" + (num1 /num2));
    //    }
    //    public void Operation(int num1, int num2)
    //    {
    //        Console.WriteLine("The Multiplication is :-" + (num1 * num2));
    //    }
    //}



    class Arithematic
    {
        // Function to add two integers
        public int Calculate(int a, int b)
        {
            return a + b;
        }

        // Function to subtract two integers
        public int Calculate(int a, int b, char operation)
        {
            if (operation == '-')
                return a - b;
            else
                throw new ArgumentException("Invalid operation");
        }

        // Function to multiply two integers
        public int Calculate(int a, int b, bool isMultiplication)
        {
            if (isMultiplication)
                return a * b;
            else
                throw new ArgumentException("Invalid operation");
        }

        // Function to divide two integers
        public double Calculate(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division by zero is not allowed");
            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithematic obj = new Arithematic();
            Console.WriteLine("ENTER THE NUMBERS :- ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("THE NUMBERS ON WHICH DIFFERENT OPERATION ARE TO BE PERFORMED ARE:- \n"+num1+" & "+num2);

            Console.WriteLine("Addition is: " + obj.Calculate(num1, num2));
            Console.WriteLine("Subtraction is: " + obj.Calculate(num1, num2, '-'));
            Console.WriteLine("Multiplication is: " + obj.Calculate(num1, num2, true));
            Console.WriteLine("Division is: " + obj.Calculate((double)num1, (double)num2));

            Console.Read();
        }
    }
}
