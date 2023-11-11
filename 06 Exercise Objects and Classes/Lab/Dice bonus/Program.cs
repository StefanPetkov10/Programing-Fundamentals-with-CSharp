using System;

namespace Dice_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();//6
            dice.Sides = 6;
            dice.Roll();
            Console.WriteLine(dice.SideName);
        }
    }

    public class Dice
    {
        //public Dice(int sides)
        //{
        //    Sides = sides;
        //}
        public string SideName
        {
            get
            {
                return $"My side name is {Sides}";
            }
        }
        public int Sides { get; set; }
        public void Roll()
        {
            Random random = new Random();
            int rndNumber = random.Next(1, Sides + 1);
            Console.WriteLine(rndNumber);
        }
    }
}
