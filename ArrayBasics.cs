using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic example of an array
            string[] students = new string[10]; //this code will create an array of 10 string "variables"

            students[0] = "David";
            students[1] = "Susie";


            // you can also use the array intitalizer syntax to create arrays and populate the elements (like objects)

            byte[] arrayByte = { 0X00 }; // you don't need to use the NEW keyword becuase the TYPE is inferred by the compiler

            foreach(var item in arrayByte)
            {
                Console.WriteLine(item); // this will print "0" to the console b/c the HEX 0X00 represents 0 in ASCII
            }

        }
    }
}
