namespace BM010
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /* 
            
            WriteHelloToScreen();                   // Metodas numeris vienas. Nieko nepriima. Nieko negrąžina
            double b = GetSomeNo();                 // Nieko nepriima. Grąžina double'ą
            
            int a = 2;
            WriteNumberPlusThree(a);                // Priima skaičių. Nieko negrąžina
            Console.WriteLine(a);                   // Metodo a != Main'o a

            double c = SumOfNo(10, b);              // Priima du parametrus, grąžina vieną
            Console.WriteLine(c);

            double d = SumOfNo(10, b, 1);           // OVERLOAD. Same name but different number of parameters
            int e = SumOfNo(10, a);                 // OVERLOAD. Same name but different type (int)

            WriteTextToScreen();                    // neprivalomi
            WriteTextToScreen("Džomulungma");       // parametrai.


            Console.WriteLine(NumberCheck(10, 15, 20));
            Console.WriteLine(NumberCheck(min:10, number:15, max:20));

            int number;
            GetNumber(out number);
            Console.WriteLine(number);


            // Užduotis 01

            SveikiVisi();
            GerosDienos();


            // Užduotis 02

            Console.WriteLine("Kas per vardas?");
            string vardas = Console.ReadLine();

            Console.WriteLine(LabasIvestis(vardas));
            GerosDienosIvestis(vardas);

            */


            // Užduotis 03

            Console.WriteLine("Įveskite skaičių 01:");
            var input1 = Console.ReadLine();
            Console.WriteLine("Įveskite skaičių 02:");
            var input2 = Console.ReadLine();

            if(Double.TryParse(input1, out Double result1) == true && Double.TryParse(input2, out Double result2) == true)
            {
                double sk1 = Convert.ToDouble(input1);
                double sk2 = Convert.ToDouble(input2);
                Console.WriteLine($"Rezultatas: {Sudejimas(sk1, sk2)}");
            }
            else
            {
                Console.WriteLine("Sudėjimas neįmanomas");
            }

            Console.WriteLine("\n\n");


            // Užduotis 04

            Console.WriteLine("Įveskite bet kokį sakinį:");
            string sakinys = Console.ReadLine();
            Console.WriteLine($"Tarpų kiekis: {Tarpai(sakinys)}");


            // Užduotis 05

            Console.WriteLine("Įveskite bet kokį tekstą:");
            string manoTekstas = Console.ReadLine();
            Console.WriteLine($"Teksto ilgis yra: {TekstasBeTarpuAplink(manoTekstas)}");


        }

        private static int TekstasBeTarpuAplink(string? manoTekstas)
        {
            return manoTekstas.Length;
        }

        private static double Sudejimas(double a, double b)
        {
            return a + b;
        }

        private static int Tarpai(string sakinys)
        {
            return sakinys.Length - sakinys.Replace(" ", "").Length;
        }

        private static void GerosDienosIvestis(string? vardas)
        {
            Console.WriteLine($"Linkiu jums, {vardas}, geros dienos");
        }

        private static string LabasIvestis(string? vardas)
        {
            return $"Laba, {vardas}";
        }

        private static void GerosDienos()
        {
            Console.WriteLine("Linkiu jums geros dienos");
        }

        private static void SveikiVisi()
        {
            Console.WriteLine("Sveiki, visi!");
        }

        public static double GetSomeNo()
        {
            return 100;
        }

        public static void WriteHelloToScreen()
        {
            Console.WriteLine("Hello.");
        }

        public static void WriteNumberPlusThree(int a)
        {
            Console.WriteLine(a + 3);
        }

        public static double SumOfNo(double a, double b)
        {
            return a + b;
        }

        public static int SumOfNo(int a, int b)
        {
            return a + b;
        }

        public static double SumOfNo(double a, double b, double c)
        {
            return a + b + c;
        }

        public static void WriteTextToScreen(string text = "No text")
        {
            Console.WriteLine(text);
        }


        public static int NumberCheck(int number, int min, int max)
        {
            if (number < min)
            {
                return min;
            } 
            else if (number > max)
            {
                return max;
            }
            else
            {
                return number;
            }

        }

        public static void GetNumber(out int number)
        {
            number = 5;
        }

    }
}