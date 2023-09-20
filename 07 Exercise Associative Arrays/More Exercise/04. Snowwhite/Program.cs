using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dwarf> dwarfs = new Dictionary<string, Dwarf>();
            string input;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inputArg = input
                    .Split(" <:> ")
                    .ToArray();

                string name = inputArg[0];
                string hat = inputArg[1];
                int physics = int.Parse(inputArg[2]);

                string key = name + hat;

                Dwarf newDwarf = new Dwarf(name, hat, physics);
                if (!dwarfs.ContainsKey(key))
                {
                    dwarfs.Add(key, newDwarf);
                }
                else
                {
                    dwarfs[key].Physics = Math.Max(physics, dwarfs[key].Physics);
                }
            }
            foreach (var dw in dwarfs.OrderByDescending(x => x.Value.Physics)
                     .ThenByDescending((n => dwarfs
                     .Where(m => m.Value.Hat == n.Value.Hat)
                     .Count())))
            {
                Console.WriteLine($"({ dw.Value.Hat}) {dw.Value.Name} <-> {dw.Value.Physics}");
            }
        }
    }
    public class Dwarf
    {
        public Dwarf(string name, string hat, int physics)
        {
            Name = name;
            Hat = hat;
            Physics = physics;
        }
        public string Name { get; set; }
        public string Hat { get; set; }
        public int Physics { get; set; }
    }
}