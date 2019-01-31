using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Team Tree House Fitness Frog Console Application
            //Below is the code for the application

            int runningTotal = 0;

            bool keepGoing = true;

            while (keepGoing)
            {
                //Propmt user for mintues exercised
                Console.Write("Enter how many mintues you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                } 
                else
                {
                    try
                    {
                        //Add minutes exercised to total (converts the STRING entry to an INT)
                        int minutes = int.Parse(entry);

                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not an acceptable value.");
                            continue; //This will keep the while loop going. and allow the user to input a valid number
                        }
                        else if (minutes <= 10)
                        {
                            Console.WriteLine("Better than nothing, am I right?");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Way to go Awesome Sauce!");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You must be a ninja in training :)");
                        }
                        else
                        {
                            Console.WriteLine("You are a workout MANIAC!!!");
                        }

                        //Add minutes exercised to total
                        runningTotal = runningTotal + minutes;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid input");
                        continue;
                    }

                    //Display total minutes exercised to the screen
                    Console.WriteLine("You've entered " + runningTotal + " minutes.");
                }
                
                //Repeat until user quits
                         
            }

            Console.WriteLine("Goodbye");
            Console.ReadKey();
            
        }
    }
}
