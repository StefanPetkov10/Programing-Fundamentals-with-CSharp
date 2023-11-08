using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //"-1234"

            int absValue = Math.Abs(int.Parse(input)); //1234

            int sumOfEvenDigits = GetOfEvenDigits(absValue.ToString());
            int sumOfOddDigits = GetOfOddDigits(absValue.ToString());

            int result = sumOfEvenDigits * sumOfOddDigits;

            Console.WriteLine(result);
        }

        private static int GetOfEvenDigits(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //"1234"
                //input[0] = '1'
                //''1'.ToString() => "1"
                int currentNumber = int.Parse(input[i].ToString());

                if (currentNumber % 2 == 0)
                {
                    sum += currentNumber;
                }
            }
            return sum;
        }

        private static int GetOfOddDigits(string input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = int.Parse(input[i].ToString());

                if (currentNumber % 2 != 0)
                {
                    sum += currentNumber;
                }
            }
            return sum;
        }
    }
}
