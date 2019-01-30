using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_lesson
{
    class Program
    {
        delegate int CountIt(int x);

        static void Main(string[] args)
        {
            // Example Code of Expression Lambda

            CountIt testDel = (int x) => x + 5;

            int result = testDel(5);
        }
    }
}
