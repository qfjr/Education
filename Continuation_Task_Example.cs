using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continuation_task_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> firstTask = Task.Factory.StartNew<int>(() =>
            {
                Console.WriteLine("First Task");
                return 42;
            });

            Task secondTask = firstTask.ContinueWith((ft) => {
                Console.WriteLine("Second Task, First task returned {0}", ft.Result);
            });
        }
    }
}
