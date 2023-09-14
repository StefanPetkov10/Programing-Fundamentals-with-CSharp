using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs1 = Console.ReadLine()
                .Split(" ");
            string[] strs2 = Console.ReadLine()
                .Split(" ");
            

            for (int i = 0; i < strs2.Length; i++)
                {
                for (int j = 0; j < strs1.Length; j++)
                {
                    if (strs2[i] == strs1[j])
                    {
                        Console.Write(string.Join(" ", strs2[i] + " "));
                    }    
                }
            }
            
        }
    }
}
