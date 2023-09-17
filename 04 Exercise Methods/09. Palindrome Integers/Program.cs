using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindromeNumber = " ";
            while ((palindromeNumber = Console.ReadLine()) != "END")
            {
                bool output = Palindrome(palindromeNumber);
                Console.WriteLine(output);
            }
        }
        private static bool Palindrome(string palindromeNumber)
        {
                int length = palindromeNumber.Length;
                for (int i = 0; i < length / 2; i++)
                {
                    if (palindromeNumber[i] != palindromeNumber[length - i - 1])
                    
                    return false;
                }
                return true; 
            }

        }
    }

