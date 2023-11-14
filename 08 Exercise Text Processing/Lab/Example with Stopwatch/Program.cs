using System;
using System.Text;
using System.Diagnostics;

namespace Example_with_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            Stopwatch stopwatch =
                new Stopwatch();

            for (int i = 0; i < 2000; i++)
            {
                sb.Append($"{i}");    //Very quickly
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            //string result = string.Empty;
            //Stopwatch stopwatch = 
            //    new Stopwatch();
            //stopwatch.Start();
            //for (int i = 0; i < 2000; i++)
            //{
            //    result += $"{i}";    //Very slowly  
            //}
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);

        }
    }
}
