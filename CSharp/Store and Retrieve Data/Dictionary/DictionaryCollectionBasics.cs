using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> superheroes = new Dictionary<string, string>();

            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wanye", "Batman");
            superheroes.Add("Barry West", "Flash");

            superheroes.Remove("Bruce Wayne");

            superheroes.TryGetValue("Clark Kent", out string value);

            Console.WriteLine(value);
        }
    }
}
