namespace BM002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            // Užduotis: Įvesti ir išvesti vardą
            Console.WriteLine("My name is Tomas. Write your name: ");
            Console.WriteLine("Hi, {0}", Console.ReadLine());

            // Užduotis: Įvesti raidę, išvesti ASCII kodą
            Console.WriteLine("Write a letter: ");
            Console.WriteLine("\nYour letter in ASCII: {0}", (int)Console.ReadKey().KeyChar); //cast as int, read key, as ASCII number

            // Užduotis: Susumuoti įvestus raidę ir skaičių
            Console.WriteLine("Write a letter and a number: ");
            Console.WriteLine("\nRezult: {0}", (int)Console.ReadKey().KeyChar + (int)Console.ReadKey().KeyChar);

            // Užduotis: Pardavimo menu
            Console.WriteLine("(1) Pirkti \n(2) Parduoti \n(3) Likučiai");
            Console.WriteLine("\nPasirinkimas: \"" + Console.ReadKey().KeyChar +"\". Bandykite vėl");
            Console.WriteLine("\nPasirinkimas: \"{0}\". Bandykite vėl", Console.ReadKey().KeyChar);
            Console.WriteLine($"\nPasirinkimas: \"{Console.ReadKey().KeyChar}\". Bandykite vėl");

            // Užduotis: Kabutės
            Console.WriteLine("\"LABAS\"");
            Console.WriteLine("\u0022LABAS\u0022");

            // Užduotis: Vardo antroji raidė
            Console.WriteLine("Parašykite savo vardą: ");
            Console.WriteLine("Vardo antroji raidė yra: {0}", Console.ReadLine()[1]);

            // Užduotis: Vardo ilgis
            Console.WriteLine("Parašykite savo vardą: ");
            Console.WriteLine("Vardo ilgis yra: {0}\n", Console.ReadLine().Length);

            // Užduotis: ASCII art
            Console.WriteLine("     *********     ");
            Console.WriteLine("   **         **   ");
            Console.WriteLine("  ** ()  |  () **  ");
            Console.WriteLine(" **      |      ** ");
            Console.WriteLine(" **   *     *   ** ");
            Console.WriteLine("  **   *****   **  ");
            Console.WriteLine("   **         **   ");
            Console.WriteLine("     *********     ");

            Console.WriteLine("\n");

            Console.WriteLine("     \"\"\"\"\"\"\"\"\"     ");
            Console.WriteLine("   \"\"         \"\"   ");
            Console.WriteLine("  \"\" ()  |  () \"\"  ");
            Console.WriteLine(" \"\"      |      \"\" ");
            Console.WriteLine(" \"\"   \"     \"   \"\" ");
            Console.WriteLine("  \"\"   \"\"\"\"\"   \"\"  ");
            Console.WriteLine("   \"\"         \"\"   ");
            Console.WriteLine("     \"\"\"\"\"\"\"\"\"     ");

            Console.WriteLine(@"

                 *********     
               **         **   
              ** ()  |  () **  
             **      |      ** 
             **   *     *   ** 
              **   *****   **  
               **         **   
                 *********     

            ".Replace("*", "\""));
            

            // Tekstinio tipo kintamieji

            string kintamasis = "Hello!";     // tipas, pavadinimas, priskyrimas, reikšmė;
            Console.WriteLine(kintamasis);

            var stringamasis = "Text";        // var - compiler decides the type
            var tuscias = "";                 // empty variable
            string nullas = null;             // empty != null
            
            */


            // Užduotis: Sukurti Tower of Hanoi

            string towerHanoi_0 = "       |    ";
            string towerHanoi_1 = "      #|#   ";
            string towerHanoi_2 = "     ##|##  ";
            string towerHanoi_3 = "    ###|### ";
            string towerHanoi_4 = "   ####|####";

            // Tower of Hanoi: 01

            Console.WriteLine($"Tower of Hanoi 01 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_1}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_2}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_3}{towerHanoi_0}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_4}{towerHanoi_0}{towerHanoi_0}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 02

            Console.WriteLine($"Tower of Hanoi 02 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_4}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_3}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_2}{towerHanoi_0}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_1}{towerHanoi_0}{towerHanoi_0}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 03

            Console.WriteLine($"Tower of Hanoi 03 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 04

            Console.WriteLine($"Tower of Hanoi 04 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_4}{towerHanoi_4}{towerHanoi_4}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 05

            Console.WriteLine($"Tower of Hanoi 05 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_0}{towerHanoi_1}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_4}{towerHanoi_2}{towerHanoi_3}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 06

            Console.WriteLine($"Tower of Hanoi 06 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_3}{towerHanoi_1}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_4}{towerHanoi_2}{towerHanoi_3}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 07

            Console.WriteLine($"Tower of Hanoi 07 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_3}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_3}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_3}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_3}{towerHanoi_3}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_4}{towerHanoi_3}{towerHanoi_3}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 08

            Console.WriteLine($"Tower of Hanoi 08 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_1}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_2}\n" +
                $"4eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_3}\n" +
                $"5eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_4}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 09

            string towerHanoi_1b = "      \"|\"   ";
            string towerHanoi_2b = "     \"\"|\"\"  ";
            string towerHanoi_3b = "    \"\"\"|\"\"\" ";
            string towerHanoi_4b = "   \"\"\"\"|\"\"\"\"";

            Console.WriteLine($"Tower of Hanoi 09 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_1b}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_2b}\n" +
                $"4eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_3b}\n" +
                $"5eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_4b}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 10

            Console.WriteLine("Enter your Hanoi piece: ");

            string towerHanoi_x = "   " + Console.ReadLine();

            Console.WriteLine($"Tower of Hanoi 10 \n\n" +
                $"1eil.{towerHanoi_x}{towerHanoi_4}{towerHanoi_2}\n" +
                $"2eil.{towerHanoi_3}{towerHanoi_3}{towerHanoi_3}\n" +
                $"3eil.{towerHanoi_4}{towerHanoi_2}{towerHanoi_4}\n" +
                $"4eil.{towerHanoi_3}{towerHanoi_3}{towerHanoi_3}\n" +
                $"5eil.{towerHanoi_2}{towerHanoi_4}{towerHanoi_2}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            // Tower End




        }
    }
}