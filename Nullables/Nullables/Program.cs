using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    class NullablesAtShow
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            // display the values

            Console.WriteLine("Nullable at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A nullable boolean value: {0}", boolval);
            Console.ReadLine();

            double? num5 = null;
            double? num6 = 3.14157;
            double num7;
            num7 = num1 ?? 5.34;
            Console.WriteLine("Value of num7: {0}", num7);
            num7 = num6 ?? 5.34;
            Console.WriteLine("Value of num7: {0}", num7);
            Console.ReadLine();
        }
    }
}
