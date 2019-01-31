using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_method_lesson
{
    delegate void CountIt();

    class Program
    {
        static void Main(string[] args)
        {
            CountIt testDel = delegate  // this is the start of the ANONYMOUS METHOD
            {
                for (int i = 0; i < 5; i++)    // the keyword DELEGATE tells the COMPILER that its an ANONYMOUS METHOD
                {
                    Console.WriteLine(i);
                }
            };

            testDel();
        }



        // the below code is reference and only shows you how methods were ORIGINALLY written and how anonymous functions are EASIER TO WRITE

        static void TestFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
