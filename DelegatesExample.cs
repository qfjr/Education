using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{

    // you can use IL Spy or dotPeek to see the actual WorkPerformedHandler DELEGATE CLASS
    public delegate void WorkPerformedHandler(int hours, WorkType workType);   //The word "HANDLER" is typically used when naming delegates

    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);  // w/i the delegate object constructor, you put the name of the METHOD HANDLER (or EVENT HANDLER)
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);

            del1(5, WorkType.Golf);   // this DELEGATE passes the values in the ( )
            del2(10, WorkType.GenerateReports);

            Console.Read();
        }

        static void WorkPerformed1(int hours, WorkType workType)  // heres the 1st METHOD HANDLER
        {
            Console.WriteLine("WorkPerformed1 called" + " " + hours.ToString());
        }

        static void WorkPerformed2(int hours, WorkType workType)   // heres the 2nd METHOD HANDLER
        {
            Console.WriteLine("WorkPerformed2 called" + " " + hours.ToString());
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
