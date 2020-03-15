using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prac_mode_3
{
    class PahirapNiRenCharLang
    {
        static void Main()
        {
            double total = 0;
            int count;
            const int DASHES = 50;
            
            Write("Enter how many input you want: ");
            int x = Convert.ToInt32(ReadLine());
            int[] scores = new int[x] ;

            string inputString;
   
           for (x = 0; x < scores.Length; ++x)
           {
            Write("Enter your score on test {0}: ", x + 1);
            inputString = ReadLine();
            scores[x] = Convert.ToInt32(inputString);
           }
            WriteLine();
            for (count = 0; count < DASHES; ++count)
            {
                Write("-");
            }
            WriteLine();
            
            Array.Sort(scores);
            for (x = 0; x < scores.Length; ++x)
            {
                Write("{0,6}", scores[x]);
            }
            WriteLine();

            WriteLine();
            for (count = 0; count < DASHES; ++count)
                Write("-");
            
            WriteLine();
            for (int i = 0; i<x; ++i)
            {
            total += scores[i];
            }
            Write("The total is: {0}", total);
            WriteLine();
            ReadKey();
        }
    }
}
