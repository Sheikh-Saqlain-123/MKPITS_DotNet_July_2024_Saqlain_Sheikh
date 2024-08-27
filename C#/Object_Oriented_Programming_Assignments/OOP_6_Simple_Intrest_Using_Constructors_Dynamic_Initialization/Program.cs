using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6_Simple_Intrest_Using_Constructors_Dynamic_Initialization
{
    public class Intrest
    {
        private double p;
        private double r;
        private double t;
        public Intrest(double principle, double rate, double time)
        {
            p = principle;
            r = rate;
            t = time;
        }

        public double SimpleIntrest()
        {
            return (p * r * t) / 100;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter the Principal amount: ");
                double principal = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the Rate of interest (in %): ");
                double rate = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the Time period (in years): ");
                double time = Convert.ToDouble(Console.ReadLine()); 

                Intrest obj  = new Intrest(principal,rate,time);
                double si = Convert.ToDouble( obj.SimpleIntrest());

            Console.Write("Simple Intrest Is :- "+si);

            Console.ReadLine();
        }
    }
}
