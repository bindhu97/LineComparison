using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LengthOfLine
    {
        public void Length()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            StringBuilder sb = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Enter point x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine("Length of Line between two points: " + length);

            Console.ReadLine();
        }
    }
}
