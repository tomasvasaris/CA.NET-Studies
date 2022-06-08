namespace BM003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Užduotis 01

            // Kintamieji
            string nameMokykla = "Code Academy";
            string nameKursass = "CA.NET2";
            int numberStudents = 19;
            var startDate = new DateTime(2022, 5, 30);
            var finalDate = new DateTime(2022, 12, 30);

            double trukme = (finalDate - startDate).Days;

            // Išvedimas
            Console.WriteLine($"Mokykla: {nameMokykla}");
            Console.WriteLine($"Kursas: {nameKursass}");
            Console.WriteLine($"Studentai: {numberStudents}");
            Console.WriteLine($"Trukme: {trukme}");


            // Užduotis 02
            string keistasTekstas = "Tiesa";
            int keistasSkaicius = 1;
            bool keistasBool = true;

            Console.WriteLine($"\n{keistasTekstas}, {keistasSkaicius}, {keistasBool}.\n");


            // Užduotis 03
            int skaitmuo1 = 1;
            int skaitmuo2 = 2;
            int skaitmuo3 = 3;

            Console.WriteLine(skaitmuo1+skaitmuo2+skaitmuo3); //nepavyksta
            Console.WriteLine("{0}{1}{2}", skaitmuo1, skaitmuo2, skaitmuo3);
            Console.WriteLine($"{skaitmuo1}{skaitmuo2}{skaitmuo3}");


        }
    }
}