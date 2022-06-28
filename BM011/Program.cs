namespace BM011
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*

            // Užduotis 06 
            Console.WriteLine("Įveskite bet kokį sakinį:");
            Console.WriteLine($"Žodžių kiekis: {ZodziuKiekis(Console.ReadLine())}");


            // Užduotis 07
            Console.WriteLine("Įveskite bet kokį tekstą:");
            Console.WriteLine($"Tarpai gale: {TarpaiGale(Console.ReadLine())}");


            // Užduotis 08
            Console.WriteLine("Įveskite bet kokį tekstą:");
            Console.WriteLine($"Tarpai priekyje: {TarpaiPrieky(Console.ReadLine())}");

            */


            // Užduotis 09
            Console.WriteLine("Įveskite bet kokį tekstą:");
            Console.WriteLine($"Tarpai priekyje: {TarpaiPriekyIrGale(Console.ReadLine(), out int tarpaiGale)}");
            Console.WriteLine($"Tarpai gale:     {tarpaiGale}");



        }

        public static int TarpaiPriekyIrGale(string? tekstas, out int tarpaiGale)
        {
            tarpaiGale = tekstas.Length - tekstas.TrimEnd().Length;
            return tekstas.Length - tekstas.TrimStart().Length;
        }

        public static object TarpaiPrieky(string? tekstas)
        {
            return tekstas.Length - tekstas.TrimStart().Length;
        }

        public static object TarpaiGale(string? tekstas)
        {
            return tekstas.Length - tekstas.TrimEnd().Length;
        }

        public static int ZodziuKiekis(string? sakinys)
        {
            if(sakinys.Trim().Replace(" ", "") != "")
            {
                return sakinys.Trim().Length - sakinys.Trim().Replace(" ", "").Length + 1;
            } else
            {
                return 0;
            }
        }
    }
}