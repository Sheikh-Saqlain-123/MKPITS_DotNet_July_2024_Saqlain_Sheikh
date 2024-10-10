using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_13_Inheritance_Example_Of_Cricketer
{
    class Cricketer
    {
        // Base class for cricketer
        public string Name { get; set; }
        public int MatchesPlayed { get; set; }

        public Cricketer(string name, int matchesPlayed)
        {
            Name = name;
            MatchesPlayed = matchesPlayed;
        }
    }

    class Batsman : Cricketer
    {
        // Derived class for batsman
        public int TotalRuns { get; set; }
        public double AverageRuns { get;  set; }
        public int BestPerformance { get; set; }

        public Batsman(string name, int matchesPlayed, int totalRuns, int bestPerformance)
            : base(name, matchesPlayed)
        {
            TotalRuns = totalRuns;
            BestPerformance = bestPerformance;
            CalculateAverageRuns();
        }

        // Method to input data
        public void InputData()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine();

            Console.Write("Enter matches played: ");
            MatchesPlayed = int.Parse(Console.ReadLine());

            Console.Write("Enter total runs: ");
            TotalRuns = int.Parse(Console.ReadLine());

            Console.Write("Enter best performance: ");
            BestPerformance = int.Parse(Console.ReadLine());

            CalculateAverageRuns();
        }

        // Method to calculate average runs
        private void CalculateAverageRuns()
        {
            if (MatchesPlayed != 0)
            {
                AverageRuns = (double)TotalRuns / MatchesPlayed;
            }
            else
            {
                AverageRuns = 0;
            }
        }

        // Method to display data
        public void DisplayData()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Matches Played: {MatchesPlayed}");
            Console.WriteLine($"Total Runs: {TotalRuns}");
            Console.WriteLine($"Best Performance: {BestPerformance}");
            Console.WriteLine($"Average Runs: {AverageRuns:F2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Batsman batsman = new Batsman("Sachin", 200, 15000, 200);
            char opt = 'y';
            do
            {
                Console.WriteLine("----------------------------------------------------------------------------------------");
                batsman.InputData();
                Console.WriteLine("----------------------------------------------------------------------------------------");
                batsman.DisplayData();
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine("Press 'y' to Type the Cricketer's Name  Again: \nOR \nPress 'n' To EXIT");
                opt = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------------------------------");
            }
            while(opt != 'n');
            


            Console.Read();
        }
    }
}
