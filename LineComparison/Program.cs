using System;
namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating length for Line 1 \n" + "==============================");
            double line1 = LineOperation.CalculateLength();
            Console.WriteLine("\nCalculating length for Line 2 \n" + "==============================");
            double line2 = LineOperation.CalculateLength();

            LineOperation.CheckEquality(line1, line2);
        }
    }
}