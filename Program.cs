using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeClass_class_metadata_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Below are examples of using the TYPE class to get the TYPE at either COMPILE time or RUNTIME

            var dog = new Dog();

            // Compile Time - Getting TYPE
            Type t1 = typeof(Dog);


            // Runtime - Getting TYPE
            Type t2 = dog.GetType();




            //Now we will show an example of using the TYPE class to access the METADATA of the DOG class or type::

            // get the CLASS name
            Console.WriteLine(t1.Name);

            // get the assembly of the class
            Console.WriteLine(t2.Assembly);

        }
    }

    class Dog
    {
        public int NumberOfLegs { get { return 5; } }
    }
}
