using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineOperation
    {
        public static void CalculateLength()
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
        }
    }
}
