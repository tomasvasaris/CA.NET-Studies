namespace BM007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, IF!");

            int shields = 1, armor = 2;

            if (shields <= 0)
            {
                if (armor <=0)
                {
                    Console.WriteLine("GAME OVER");
                } else
                {
                    Console.WriteLine("Defence operational");
                }
            } else
            {
                Console.WriteLine("Defence optimal");
            }

            shields = (shields > armor) ? 0 : armor;


            // Užduotis 01

            Console.WriteLine("Įveskite skaičių: ");
            double skaicius = Convert.ToDouble(Console.ReadLine());

            if (skaicius % 2 == 0)
            {
                Console.WriteLine("Skaičius yra lyginis");
            }

            if (skaicius < 0)
            {
                Console.WriteLine("Skaičius yra neigiamas");
            }

            if (skaicius % 2 > 0 && skaicius > 0)
            {
                Console.WriteLine(skaicius);
            }


            // Užduotis 02

            Console.WriteLine("Įveskite grupės narių skaičių: ");
            int nariai = Convert.ToInt32(Console.ReadLine());

            if (nariai == 1)
            {
                Console.WriteLine("Tai solistas");
            }
            else if (nariai == 2)
            {
                Console.WriteLine("Tai duetas");
            }
            else if (nariai > 2 && nariai < 10)
            {
                Console.WriteLine("Tai kamerinis ansamblis");
            }
            else if (nariai >= 10)
            {
                Console.WriteLine("Tai ansamblis");
            } else
            {
                Console.WriteLine("Jokia čia grupė, nejuokauk");
            }

            */


            // Užduotis 03

            Console.WriteLine("Etatatas: 160 valandos");
            Console.WriteLine("Įveskite išdirbtas valandas: ");
            int valandos = Convert.ToInt32(Console.ReadLine());
            int liekana;

            if (valandos < 160)
            {
                liekana = 160 - valandos;
                Console.WriteLine($"Neišdirbtos {liekana} val.");
            } 
            else if (valandos == 160)
            {
                Console.WriteLine("Išdirbtas pilnas etatas!");
            } 
            else if (valandos > 160)
            {
                liekana = valandos - 160;
                Console.WriteLine($"Viršvalandžiai: {liekana} val.");
            }
            else
            {
                Console.WriteLine("Sistemos klaida.");
            } 


        }
    }
}