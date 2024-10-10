using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8_Multiplication_Cubic_Values_Using_Inline_Function
{
    public class InlineFunctionClass
    {
        public void InlineMultiplicationFunction(int number1, int number2)
        {
            Console.WriteLine("The Multiplication Of " + number1+" & "+number2+" is :-" + (number1 * number2));
        }
        public void InlineCubeFunction(decimal num)
        {
            Console.WriteLine("The Cube Of "+num+" is :-"+(num*num*num));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            InlineFunctionClass obj = new InlineFunctionClass();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Enter The Two Numbers For Multiplication :-");
            int num1= Convert.ToInt32(Console.ReadLine());
            int num2= Convert.ToInt32(Console.ReadLine());
            obj.InlineMultiplicationFunction(num1, num2);
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Enter The Numbers to find Its Cube :-");
            decimal number= Convert.ToDecimal(Console.ReadLine());
            obj.InlineCubeFunction(number);
            Console.WriteLine("---------------------------------------------------------------------------");

            Console.Read();
        }
    }
}
