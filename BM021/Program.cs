namespace BM021
{
    public class Program
    {
        static double? rezultatas = null;

        static void Main(string[] args)
        {
            // Užduotis: Super Duper Skaičiuotuvas 3000
        }

        public static void SuperSkaiciuotuvas(string ivedimas)
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

                if (isWorking == true) { Console.WriteLine($"\nYour result: {result} \n"); }
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

        public static double Rezultatas()
        {
            return rezultatas ?? 0;
        }

        public static void Reset()
        {
            //todo
            rezultatas = null;
        }

    }
}