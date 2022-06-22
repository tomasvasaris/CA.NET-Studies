namespace BM009
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Užduotis: Amžiaus Melagis!


            Console.WriteLine($"Vartotojo registracijos forma. \n");

            // Duomenų įvedimas

            Console.Write($"Įveskite savo pilną vardą ir pavardę:     ");
            var regVardas = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Įveskite savo asmens kodą (11 skaitmenų): ");
            var regAsmens = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Įveskite savo amžių ir/arba gimimo datą:  ");
            var regGimimo = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\nŠiandienos data: {DateTime.Today:yyyy-MM-dd}");


            // Kintamieji

            char regLytis;
            bool patikimumas;




            // Ataskaitos išvedimas

            Console.WriteLine($"\n\n");
            Console.WriteLine($"▓▓");
            Console.WriteLine($"▓▓");
            Console.WriteLine($"▓▓");
            Console.WriteLine($"▓▓");
            Console.WriteLine($"▓▓▓▓");
            Console.WriteLine($"▓▓▓▓     Vardas, pavardė ▓▓ {} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓               Lytis ▓▓ {} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓        Asmens kodas ▓▓ {} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓              Amžius ▓▓ {} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓         Gimimo data ▓▓ {} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓ Amžiaus patikimumas ▓▓ {} ▓▓▓▓");
            Console.WriteLine($"▓▓▓▓");
            Console.WriteLine($"\n\n");

        }
    }
}