using System;
namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            LineOperation line = new LineOperation();
            Console.WriteLine("Calculating length for Line 1 \n" + "==============================");
            double line1 = line.CalculateLength();
            Console.WriteLine("\nCalculating length for Line 2 \n" + "==============================");
            double line2 = line.CalculateLength();

            line.CheckEquality(line1, line2);
            line.CompareTwoLines(line1, line2);
        }
    }
}