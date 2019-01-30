using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JSONSerializationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Bills bill = new Bills() { billName = "Rent", billPayment = "800" };
            

            File.WriteAllText(@"C:\Users\a179536\Desktop\yep\jsontext.txt", JsonConvert.SerializeObject(bill));

            Console.WriteLine("Serialization complete!");
            Console.ReadKey();

            //using (StreamWriter file = File.CreateText(@"C:\Users\a179536\Desktop\yep\jsontext2.txt"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    serializer.Serialize(file, bill);
            //}


        }
    }
}
