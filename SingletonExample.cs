What is a Singleton Pattern?
If we want a class to have only ONE OBJECT, then use the singleton Pattern



Using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com.Singleton
{
    class TestLogger
    {
        static void Main()
        {
            // With the Singleton Design Pattern our goal is to only allow ONE OBJECT on the class to be created
            // By default you have the ability to create as many objects as you want (see code below)
            Logger obj1 = new Logger();
            Logger obj2 = new Logger();

            // When you create an OBJECT by default the objects CONSTRUCTOR METHOD is called first (this is the first
            // method that is called) (like how the main method is the first method called in C# desktop app code)
            // that method is the "()" in <  new Logger(); >
            Logger obj1 = new Logger();

            // Every class (OBJECT) by default has a a built in constructor, EVEN IF YOU DONT WRITE IT
            // See Logger class below, even it the < public Logger() > in the Logger is not written there
            // To reiterate a constructor is a method that has the same name as the class (OBJECT)
            // when ever you create an object with the new keyword that constructor is called
            // And without that constructor you cannot create objects
            // in the singleton design you make the default constructor on a class private so no other classes can create objects of that class
            // then you create an instance of Logger inside of the same class (instantiate the object in the class) its the "private Logger logger" in the Logger class



            // Now  in the below code, you can create an instance variable that points the already created object of Logger
            Logger objInstance1 = Logger.GetInstance();
            Logger objInstance2 = Logger.GetInstance();

            // using the code below we can verify that the reference variables above are in fact pointing to the same object
            Console.WriteLine(objInstance1.GetHashCode());
            Console.WriteLine(objInstance2.GetHashCode());

        }
    }

    static class Logger
    {
        static private Logger logger;

        private Logger()
        {

        }

        static public GetInstance()
        {
            if(logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }
    }
}