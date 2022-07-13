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

            /*
            Sukurti skaiciuotuva. Ijungus programa mes turetume gauti pranesima 
            “1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”. Pasirinkus 1 turetu ismesti ”
            1. Sudetis
            2. Atimtis
            3. Daugyba
            4. Dalyba”
            Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius, 
            o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis su rezultatu. Sudeties pvz:
            “1
            15
            45
            Rezultatas: 60
            1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
            Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. 
            Pasirinkus 3 programa turetu issijungti. Visa kita turetu veikti tokiu pat budu.
            BONUS1: Iskelkite operacijas i metodus
            BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius. Pvz: dalyba is nulio, neteisingu ivesciu prevencija 
            pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
            BONUS3: Parasyti unit testus uztikrinant operaciju veikima
            BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas
            */

            //Užduotis: Skaičiuotuvas
            Calculator();
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

            Console.WriteLine("Valid operations: \n1) Sum \n2) Subtract \n3) Multiply \n4) Divide \n");

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