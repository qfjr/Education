using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace thread_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Thread1);
            t.Start();

            for (var n=0; n < 10; n++)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
            
        }

        static void Thread1()
        {
            for (var n = 10; n < 20; n++)
            {
                Console.WriteLine(n);
            }
        }
    }
}
