using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineOperation
    {
        public static double CalculateLength()
        {
            Console.WriteLine("Enter length of x1");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length of x2");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length of y1");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length of y2");
            double y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of a Line is: {0}", length);
            return length;
        }
        public static void CheckEquality(double line1, double line2)
        {
            if (line1.Equals(line2))
            {
                Console.WriteLine("\nBoth the lines are equal");
            }
            else
            {
                Console.WriteLine("\nLines are not Equal");
            }
        }
        public static void CompareTwoLines(double line1, double line2)
        {
            if (line1.CompareTo(line2) < 0)
            {
                Console.WriteLine("line2 is greater than line1");
            }
            else if (line1.CompareTo(line2) > 0)
            {
                Console.WriteLine("line1 is greater than line2");
            }
            else
            {
                Console.WriteLine("Both the lines are equal");
            }
        }
    }
}
