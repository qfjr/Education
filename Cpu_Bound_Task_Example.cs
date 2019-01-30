using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpu_bound_task_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(Speak);
            // the above Task consutructor takes the TYPE Action, which is a DELEGATE that says I want a function that has NO RETURN VALUE or RETURN TYPE
            // ANDDDDD takes in NOOOO parameters

            t.Start();
        }

        private static void Speak()
        {
            Console.WriteLine("Hello World");
        }
    }
}
