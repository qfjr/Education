using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threads
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ================================================================
            Simple Thread Example
            ================================================================
            //The below code will show how you cannot guarantee when a thread is going to execute, hence the random "1" and "0" displaying

            Thread t = new Thread(Print1);
            t.Start();


            //this below code is the MAIN THREAD running because it is called inside the MAIN METHOD
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }

            Console.ReadKey();
            */






            /*
            ================================================================
            Sleep (thread example)
            ================================================================
            

            //With the sleep() method the thread us SUSPENDED for the designated amount of time

            int num = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num);

                //Here we Pause for 1 second
                Thread.Sleep(1000);

                num++;
            }

            Console.WriteLine("Thread Ends");
            Console.ReadKey();
            */








            /*
            ==================================================================
            Lock (thread example)
            ==================================================================

            //LOCK keeps other threads from entering a statement block until another thread leaves





             */







             
        }

        static void Print1() //so this is a single independent thread (called a worker thread - seperate from MAIN thread)  !!!KEY CONCEPT!!!
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }


        class BankAcct
        {
            private Object acctLock = new object();
            double Balance { get; set; }

            public BankAcct(double bal)
            {
                Balance = bal;
            }

            public double Withdraw (double amt)
            {
                if ((Balance - amt) < 0)
                {
                    Console.WriteLine($"Sorry ${Balance} in Account");
                    return Balance;
                }

                //now if the above code doesnt work we will use the lock keyword
                //and thats going to keep any other threads from coming in here and trying
                //to access all of the code b/t the curly braces or anything inside until each
                //thread is finished
                lock (acctLock)
                {
                    if (Balance >= amt)
                    {
                        Console.WriteLine("Removed {0} and {1} left in Account", amt, (Balance - amt));
                        Balance -= amt;
                    }
                    return Balance;
                }
            }



        }
    }
}
