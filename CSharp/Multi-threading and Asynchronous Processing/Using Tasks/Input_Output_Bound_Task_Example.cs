using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Threading;

namespace input_output_bound_task_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> downloadResults = DownloadWebPageAsync("https://techcrunch.com/");
            //agilemanifesto.org/principles.html
            while (!downloadResults.IsCompleted)
            {
                Console.Write(".");
                Thread.Sleep(10000);
            }

            Console.WriteLine(downloadResults.Result);
        }

        private static string DownloadWebPage(string url) // this function will return the html of the website specified
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            var reader = new StreamReader(response.GetResponseStream());
            {
                // this will return the content of the web page
                return reader.ReadToEnd();
            }
        }

        private static Task<string> DownloadWebPageAsync(string url) // this function is used to call the DownloadPae asynchronously
        {
            return Task.Factory.StartNew(() => DownloadWebPage(url));
        }
    }
}
