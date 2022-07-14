﻿//using BasicMethods;

namespace BasicMethods
{
    public static class MyMods
    {
        public static int IntAsk(string specify = "an int number")
        {
            Console.WriteLine($"Please write {specify}: ");
            string? input = Console.ReadLine();

            for (; ; )
            {
                if (Int32.TryParse(input, out _) == false)
                {
                    Console.WriteLine("That is not an int, try again");
                    input = Console.ReadLine();
                }
                else { return Convert.ToInt32(input); }
            }
        }
    }
}
