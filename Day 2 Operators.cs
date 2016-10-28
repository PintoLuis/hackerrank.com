using System;
using System.Collections.Generic;
using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = Convert.ToDouble(Console.ReadLine());
            double tipPercent = Convert.ToDouble(Console.ReadLine());
            double taxPercent = Convert.ToDouble(Console.ReadLine());

            double cost = Math.Round(CalcTotalCost(mealCost, tipPercent, taxPercent));
           
            Console.WriteLine("The total meal cost is " + cost + " dollars.");
        }

        public static double CalcTotalCost(double mealCost, double tipPercent, double taxPercent)
        {
            double tip = mealCost * (tipPercent / 100);
            double tax = mealCost * (taxPercent / 100);
            double totalCost = mealCost + tip + tax;
            
            return totalCost;
        }
    }