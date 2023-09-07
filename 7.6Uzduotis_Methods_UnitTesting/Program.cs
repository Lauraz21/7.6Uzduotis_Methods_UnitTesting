using System;
namespace _7._6Uzduotis_Methods_UnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            bool ret = IsNumberEven(userInput);
            Console.WriteLine(ret);
        }
        public static bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

    }
}