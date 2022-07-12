namespace BM015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //BreakSkip();
            //ForNesting();

            /*
            UŽDUOTIS 1. [12-07-2022]
            Sukurti metodą ReadIntNumber,
            kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
            Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
            įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
            neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
            (Hint) -> Panaudoti int.TryParse metodą ir while ciklą.
            */

            //ReadIntNumber();


            // UŽDUOTIS 2. Konvertuoti skaičių į dvejetainį formatą
            //Console.WriteLine("Write a number you want to convert to binary:");
            //Console.WriteLine(ConvertToBinary(Console.ReadLine()));

            // UŽDUOTIS 3. Pakelti laipsniu
            MultiplyByDegree(3, 3);


        }

        private static void MultiplyByDegree(int number, int degree)
        {
            int total = number;

            if (number == 0 && degree > 0) { total = 1; } else
            {
                degree--;

                while (degree > 0)
                {
                    total *= number;
                    degree--;
                }
            }

            Console.WriteLine(total);
        }

        private static string ConvertToBinary(string input)
        {
            string binary = "";
            int intInput;

            if(!Int32.TryParse(input, out _)) { return "error"; } else
            {
                intInput = Convert.ToInt32(input);

                while (intInput > 0)
                {
                    binary = intInput % 2 + binary;
                    intInput /= 2;
                }

                return binary;
            }
        }

        private static void ReadIntNumber()
        {
            Console.WriteLine("Please write an int number");
            string? input = Console.ReadLine();
            bool isInt = false;

            while (!isInt)
            {
                if (Int32.TryParse(input, out _) == false)
                {
                    Console.WriteLine("That is not an int, try again");
                    input = Console.ReadLine();

                } else
                {
                    isInt = true;
                    Console.WriteLine(input);
                }
            }
        }

        static void ForLoop()
        {
            for (int i = 0; i < 10; i++) // double tab to create template automagically
            {
                Console.WriteLine(i);
            }
        }

        static void BreakSkip()
        {
            for (int i = 0; i < 10; i++)
            {
                int skaicius = 5;
                if (i == skaicius)
                {
                    Console.WriteLine("skipio");
                    continue; // will skip everything below and jump back to top
                }

                if (i == 8)
                {
                    break; // will stop once i becomes 8
                }

                Console.WriteLine(i);
            }
        }

        static void ForNesting()
        {
            for (int i = 0; i < 10; i++) // double tab to create template automagically
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static int ForSubstring(string dnr, string element)
        {
            var count = 0;

            for (int i = 0; i < dnr.Length; i+=4)
            {
                if (dnr.Substring(i, 3) == element)
                {
                    count++;
                }
            }

            return count;
        }
    }
}