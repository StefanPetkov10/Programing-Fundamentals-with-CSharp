using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
