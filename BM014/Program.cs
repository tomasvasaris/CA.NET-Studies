namespace BM014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WhileCiklas0();
            //WhileCiklas1();
            //DoWhileCiklas1();
            //DoWhileCiklas2();
            //DoWhileCiklas3();
            //IkiNeigiamo();
            //Slaptazodis();
            MonetosMetimas();
        }

        static void WhileCiklas0() // suskaičiuoja skaičius iki int'o
        {
            int skaicius = 1;

            while (skaicius <= 10)
            {
                Console.WriteLine(skaicius);
                skaicius++;
            }
        }

        static void WhileCiklas1() // verifikuoja kad pasirinktas teigingas skaičius su While
        {
            int skaicius = 0;

            while (skaicius < 1 || skaicius > 10)
            {
                Console.WriteLine("Write number no less than 0 and no more than 10");
                skaicius = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void DoWhileCiklas1() // verifikuoja kad pasirinktas teigingas skaičius su DoWhile
        {
            int skaicius = 0;

            do
            {
                Console.WriteLine("Write number no less than 0 and no more than 10");
                skaicius = Convert.ToInt32(Console.ReadLine());
            } while (skaicius < 1 || skaicius > 10);
        }

        static void DoWhileCiklas2() // suskaičiuoja skaičiaus ir sumą visų skaičių nuo vieno iki jo
        {                            // WARNING: potencialiai užlaužia kompą jeigu įvedi minusinį skaičių :D
            Console.WriteLine("Write any number");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int suma = skaicius;

            do
            {
                skaicius--;
                suma += skaicius;

            } while (skaicius > 0);

            Console.WriteLine($"Sum total: {suma}");
        }

        /* UŽDUOTIS
         * Paprašyti vartotojo įvesti bet kokį skaičių. 
         * Išvesti visus lyginius skaičius nuo 0 iki pasirinkto skaičiaus, 
         * vienoje eilutėje per kablelį. Pvz.: 0, 2, 4, 6.....
         */

        static void DoWhileCiklas3() // UŽDUOTIS 01
        {
            Console.WriteLine("Write any number");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int lyginukas;
            long suma = 0;

            do
            {
                lyginukas = skaicius % 2 == 0 ? skaicius : 0;
                suma += lyginukas;

                if (skaicius > 0) { skaicius--; } else { skaicius++; }

            } while (skaicius != 0);

            Console.WriteLine($"Sum total: {suma}");
        }

        static void IkiNeigiamo() // Susumuoja skaicius iki pirmo įvesto neigiamo
        {
            int skaicius = 0;
            int suma = 0;

            do
            {
                Console.WriteLine("Įveskite skaičių!");
                skaicius = Convert.ToInt32(Console.ReadLine());

                if (skaicius > 0)
                {
                    suma += skaicius;
                    Console.WriteLine($"Suma: {suma} \n");
                }
            } while (skaicius > 0);
        }

        /* UŽDUOTIS
         * Parasykite slaptazodzio ivedimo simuliacija. 
         * Pirma kompiuteris paprasys, kad nustatytumete slaptazodi tada prasys naudotojo pakartoti slaptazodi. 
         * Bet koks neteisingas ivedimas grazina “Slaptazodis neteisingas. Bandykite dar karta”. 
         * Kada slaptazodis atspejamas turi buti isvedamas tekstas “Sveikinam! Prisijungete!”.
         * BONUS TASKAI: Padarykite taip, kad po 3 neteisingai ivestu slaptazodzio kartu programa ismestu teksta: 
         * “Jus uzblokuotas” ir iseitu is ciklo.
         */

        static void Slaptazodis() // UŽDUOTIS 02
        {
            Console.WriteLine("Įveskite savo slaptažodį:");
            string pass1 = Console.ReadLine();
            string pass2;

            int tries = 0;
            bool isCorect = false;

            Console.WriteLine("");

            do
            {
                Console.Write("Pakartokite slaptažodį: ");
                pass2 = Console.ReadLine();
                if (pass1 == pass2) { isCorect = true; }
                if (isCorect == false) { Console.WriteLine("Slaptažodis neteisingas!\n"); }
                else { Console.WriteLine("Slaptažodis teisingas :)\n"); }
                tries++;

            } while (tries < 3 && isCorect == false);

            if (isCorect == false) { Console.WriteLine("Sąskaita užblokuota!"); }
        }

        static void MonetosMetimas()
        {
            var randomObjektas = new Random();
            int ismestaMoneta;

            int spejimas;
            int teisingiMetimai   = 0;
            int neteisingiMetimai = 0;
            int goal = 5;

            Console.WriteLine("Žaidimas: Monetos metimas!");
            Console.WriteLine("1 - Skaičius, 2 - herbas\n");

            while (teisingiMetimai < goal && neteisingiMetimai < goal)
            {
                ismestaMoneta = randomObjektas.Next(1, 3);

                Console.Write("\nAtspėkite metimą: ");
                string? įrašas = Console.ReadLine();

                if (int.TryParse(įrašas, out _) == true) { spejimas = Convert.ToInt32(įrašas); }
                else { spejimas = 0; }

                if (ismestaMoneta == spejimas)
                {
                    Console.WriteLine("Teisingai!");
                    teisingiMetimai++;
                } else
                {
                    Console.WriteLine("Nope!");
                    neteisingiMetimai++;
                }
            }

            if (teisingiMetimai > neteisingiMetimai) { Console.WriteLine("Sveikinu, laimėjote žaidimą!"); } 
            else { Console.WriteLine("Deja, deja. Žaidimą pralaimėjot."); }

            Console.WriteLine($"\nSpėjimai: teisingi - {teisingiMetimai}, neteisingi - {neteisingiMetimai}");
            Console.WriteLine($"Iš viso: {teisingiMetimai + neteisingiMetimai}");
        }

    }
}