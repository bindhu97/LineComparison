using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class CheckEquality
    {
        public void Equality()
        {
            Console.WriteLine("Enter points for first line:");
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Enter point x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Double length1 = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            Console.WriteLine("Length of first line: " + length1);

            Console.WriteLine("\nEnter points for second line:");
            Console.WriteLine("Enter point x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());
            Double length2 = Math.Sqrt((Math.Pow((x4 - x3), 2)) + (Math.Pow((y4 - y3), 2)));
            Console.WriteLine("Length of second line is: " + length2);

            Boolean result = length2.Equals(length1);

            if (result == true)
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
            Console.ReadLine();
        }
    }
}
