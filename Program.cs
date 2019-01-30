using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // NON-GENERIC
            Compare obj = new Compare();
            obj.Check(40, 20); // this method will require you to use data of TYPE INT, any other data types throws an error

            // GENERIC #1
            Compare<string> i = new Compare<string>();
            i.Check("string", "value");

            // GENERIC #2
            Compare<decimal> ii = new Compare<decimal>();
            ii.Check(3.77M, 7.53M);

        }
    }

    class Compare
    {

        // The below method is considered NOT GENERIC, becuase the logic (the algortim) and the data (specified by the parameters having to be 
        // of type INT) are COUPLED, meaning you can only use INT TYPES with this method
        public bool Check(int num1, int num2)
        {
            if(num1 > num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Compare<T>
    {
        // The below method is considered GENERIC, because the logic and the data are decoupled.
        // by using <T> that specifies that you can use any data type (int, strings, objects, etc)
        public bool Check(T dataValue1, T dataValue2)
        {
            if (dataValue1.Equals(dataValue2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
