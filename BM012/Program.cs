namespace BM012
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Skaiciuotuvas(1, 1, "dalyba"));


            /*
            // Užduotis: Matematika su pasirinkimu

            Console.Write("Įveskite skaičių a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Įveskite skaičių b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Pasirinkite operaciją:");
            Console.WriteLine("1) +");
            Console.WriteLine("2) -");
            Console.WriteLine("3) *");
            Console.WriteLine("4) /");
            Console.WriteLine("5) ^2");
            Console.WriteLine("6) ^3");
            var c = Console.ReadLine();

            Console.WriteLine("");


            bool isInt = (a == Math.Round(a) && b == Math.Round(b));

            if (isInt == true)
            {
                int intA = Convert.ToInt32(a);
                int intB = Convert.ToInt32(b);
                Console.WriteLine($"Rezultatas: {Skaiciuotuvas(intA, intB, c)}");

            } else
            {
                Console.WriteLine($"Rezultatas: {Skaiciuotuvas(a, b, c)}");
            }
            */

        }


        /*

        public static string Mokausi(string text) // Užduotis 11
        {
            string mokausi = text.ToLower().Contains("mokausi") ? "Taip" : "Ne";
            return mokausi;
        }

        public static string MokausiDar(string text) // Užduotis 11A
        {
            text = " " + text + " ";
            string mokausi = text.ToLower().Contains(" mokausi ") ? "Taip" : "Ne";
            return mokausi;
        }

        public static int ARaide(string text) // Užduotis 12
        {
            int mokausi = text.IndexOf("a")+1;
            return mokausi;
        }


        04-07-2022 UŽDUOTIS: Matematika

        1. Sukurti metodus Suma, Atimtis, Daugyba, Dalyba.
         - Main metode paprašykite įvesti 2 skaičius
         - Kiekvienas matematinis veiksmas turi turėti savo metodą
           metodas turi priimti 2 int tipo parametrus ir grąžinti atlikto veiksmo rezultatą.
         - Kiekvieno metodo darbo rezultatus atspausdinti Main metode.
         - Visų gautų rezultatų sumą atspausdinti Main metode.

        2. Skaičiuotuvas. Naudoti pirmos dalies matematinius metodus.
         - Main metode paprašykite įvesti 2 skaičius ir matematinį veiksmą
         - Metodas 'Skaiciuotuvas' turi priimti tris parametrus du skaičius ir veiksmą.
         - Metodas 'Skaiciuotuvas' turi parinkti reikiamą matematinį metodą ir grąžinti rezultatą (naudoti switch)
         - parašyti testus
         - gautą rezultatą atspausdinti į ekraną Main metode.

        public static double Skaiciuotuvas(int a, int b, string c)
        {
            switch (c)
            {
                case "Suma":
                case "suma":
                    return Suma(a, b);
                case "Atimtis":
                case "atimtis":
                    return Atimtis(a, b);
                case "Daugyba":
                case "daugyba":
                    return Daugyba(a, b);
                case "Dalyba":
                case "dalyba":
                    return Dalyba(a, b);
                default:
                    return 0;
            }
        }


        public static int Suma(int a, int b)
        {
            return a + b;
        }
        public static int Atimtis(int a, int b)
        {
            return a - b;
        }
        public static int Daugyba(int a, int b)
        {
            return a * b;
        }
        public static double Dalyba(int a, int b)
        {
            return (a == 0 || b == 0) ? 0 : (a / b);
        }

        05-07-2022 UŽDUOTIS: Daugiakampio plotas

        Paprašyti naudotojo įvesti taisyklingojo daugiakampio kraštių kiekį (n) ir kraštinės ilgį (b).,
        metodo parinkimui naudoti switch expression
        1. Kai įvestas trikampis,
        - paprašyti įvesti aukšį h
        - A=1/2bh
        2. Kai įvestas keturkampis,
        - A=b*b
        3. Kai įvestas penkiakampis, šešiakampis ir t.t.,
        - paprašyti įvesti statmenį r
        - A=n/2 * b * r
        4. išvesti betkokio poligono vidinių kampų sumą
        - 180 * (n - 2)
        N.B! atkreipkite dėmesį į metodų testuojamumą.
        visi atvejai 1,2,3 ir 4 turi būti atskiruose metoduose ir metodai turi būti testuojami

        */

        public static void PoligonoPlotas(int n, double b, double h, double r, out double A, out double K)
        {
            A = n switch
            {
                3 => Trikampis(b, h),
                4 => Kvadratas(b),
                _ => Daugiakampis(n, b, r)
            };

            K = VidiniaiKampai(n);
        }

        public static double Trikampis(double b, double h)
        {
            return 1 / 2 * b * h;
        }

        public static double Kvadratas(double b) => b * b;

        public static double Daugiakampis(int n, double b, double r)
        {
            return n / 2 * b * r;
        }

        public static double VidiniaiKampai(double n) => 180 * (n - 2);


        public static double Skaiciuotuvas(double a, double b, string c)
        {
            switch (c)
            {
                case "1":
                case "+":
                    return Suma(a, b);
                case "2":
                case "-":
                    return Atimtis(a, b);
                case "3":
                case "*":
                    return Daugyba((int)a, b);
                case "4":
                case "/":
                    return Dalyba((int)a, b);
                case "5":
                case "^2":
                    return Kvadratinimas(a);
                case "6":
                case "^3":
                    return Kubizmas(a);
                default:
                    return 0;
            }
        }


        public static int Suma(int a, int b) => a + b;

        public static int Atimtis(int a, int b) => a - b;

        public static int Daugyba(int a, int b) => a * b;

        public static int Dalyba(int a, int b) => (a == 0 || b == 0) ? 0 : (a / b);

        public static double Suma(double a, double b) => a + b;

        public static double Atimtis(double a, double b) => a - b;

        public static double Daugyba(double a, double b) => a * b;

        public static double Dalyba(double a, double b) => (a == 0 || b == 0) ? 0 : (a / b);

        public static double Kvadratinimas(double a) => a * a;

        public static double Kubizmas(double a) => a * a * a;

    }
}