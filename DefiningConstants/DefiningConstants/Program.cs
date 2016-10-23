using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            const double pi2 = Math.PI;

            // constant declaration
            double r;
            Console.WriteLine("Enter Radius: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi * r * r;
            Console.WriteLine("Readius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();

            // constant declaration actual
            double r2;
            Console.WriteLine("Enter Radius: ");
            r2 = Convert.ToDouble(Console.ReadLine());
            double areaCircle2 = pi2 * r2 * r2;
            Console.WriteLine("Readius: {0}, Area: {1}", r2, areaCircle2);
            Console.ReadLine();

        }
    }
}
