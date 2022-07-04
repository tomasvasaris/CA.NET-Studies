namespace BM012
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Skaiciuotuvas(1, 1, "dalyba"));
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


        04-07-2022 UŽDUOTIS 1

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

        */

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

    }
}