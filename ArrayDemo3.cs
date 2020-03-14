using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prac_mode_3
{
    class ArrayDemo3
    {
        static void  Main()
        {
                double[] payRate = { 13.00, 17.35, 19.12, 22.45 };

                for (int x = 0; x < payRate.Length; ++x)
                    WriteLine("Pay rate{0} is {1}", x, payRate[x].ToString("C"));
            ReadKey();
        }
    }
}
