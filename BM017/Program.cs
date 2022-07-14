using System.Text;

namespace BM017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nauja užduotis. Parašyti skaičiaus kongo liniją
            //Console.WriteLine(NumberLine());


            //Užduotis: Daugybos lentelė
            //Console.WriteLine(MultiTable());

            //Užduotis: Skaičiuotuvas
            //Calculator();

            //Užduotis: Figūra 101
            //Figure();

            //Užduotis: Skaičiai atvirkščiai
            ReverseNumbers();
        }

        static void ReverseNumbers()
        {
            int input = IntAsk();
            int output = 0;
            bool isWorking = true;

            while (isWorking)
            {
                output = output * 10 + Convert.ToInt32((Convert.ToDouble(input) / 10 - input / 10) * 10);
                input = input / 10;
                isWorking = input <= 0 ? false : true;
            }

            Console.WriteLine($"\nReversed: \n{output}");
        }

        static void Figure()
        {
            int input = IntAsk("number of lines");
            int nr = 1;
            Console.WriteLine();

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(nr);
                    if (nr == 0) { nr++; } else { nr--; }
                }
                if (i % 2 == 0) { nr=0; } else { nr=1; }
                Console.WriteLine();
            }
        }

        static void Calculator()
        {
            bool isWorking = true;
            double result = 0;

            while (isWorking)
            {
                Console.WriteLine("CALCULATOR MENU: \n1) New operation \n2) Continue with result \n3) Exit \n");

                int select1 = IntAsk("your selection");
                switch (select1)
                {
                    case 1:
                        result = NewOperation();
                        break;
                    case 2:
                        result = NewOperation(result);
                        break;
                    case 3:
                        isWorking = false;
                        break;
                    default:
                        Console.WriteLine("That is not a valid selection, try again");
                        break;
                }

                Console.WriteLine($"\nYour result: {result} \n");
            }
        }

        static double NewOperation(double input1 = 0, double input2 = 0)
        {
            if (input1 == 0) { input1 = IntAsk(); }
            input2 = IntAsk();

            Console.WriteLine("Valid operations: \n1) Sum \n2) Subtract \n3) Multiply \n4) Divide \n5) Exponentiation \n6) Square root");

            while (true)
            {
                int select2 = IntAsk("your selection");
                switch (select2)
                {
                    case 1:
                        return input1 + input2;
                    case 2:
                        return input1 - input2;
                    case 3:
                        return input1 + input2;
                    case 4:
                        return input1 / input2;
                    case 5:
                        return Math.Pow(input1, input2);
                    case 6:
                        return Math.Sqrt(input1);
                    default:
                        Console.WriteLine("That is not a valid selection, try again \n");
                        break;
                }
            }
        }

        static string MultiTable()
        {
            StringBuilder output = new StringBuilder();
            int input1 = IntAsk();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                output.AppendLine($"{input1} x {i+1} =");
                output.AppendLine($"{input1 * (i + 1)}");
                output.AppendLine();
            }

            return output.ToString();
        }

        static string NumberLine()
        {
            StringBuilder output = new StringBuilder();
            int input  = IntAsk();
            int groups = IntAsk("number of groups");
            Console.WriteLine();

            for (int i = 0; i < groups; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    output.Append(input);
                }
                if (i < groups-1) { output.Append(" -> "); }
            }

            return output.ToString();
        }


        static int IntAsk(string specify = "an int number")
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
                else
                {
                    return Convert.ToInt32(input);
                }
            }
        }
    }
}