namespace BM002
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Užduotis: Sukurti Tower of Hanoi

            // Kintamieji
            string towerHanoi_0 = "       |    ";
            string towerHanoi_1 = "      #|#   ";
            string towerHanoi_2 = "     ##|##  ";
            string towerHanoi_3 = "    ###|### ";
            string towerHanoi_4 = "   ####|####";

            // Tower of Hanoi: 01
            // Nupieškite Tower of Hanoi. Piešiniui naudokite kintamuosius.

            Console.WriteLine($"Tower of Hanoi 01 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_1}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_2}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_3}{towerHanoi_0}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_4}{towerHanoi_0}{towerHanoi_0}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 02
            // Apverskite pirmą sulpelį ir išveskite visą Tower of Hanoi

            Console.WriteLine($"Tower of Hanoi 02 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_4}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_3}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_2}{towerHanoi_0}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_1}{towerHanoi_0}{towerHanoi_0}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 03
            // Išvalykite pirmą stulpelį ir išveskite tuščią Tower of Hanoi

            Console.WriteLine($"Tower of Hanoi 03 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 04
            // Į kiekvieno stulpelio 5eil įdėkite po 4 dalių elementą ir išveskite Tower of Hanoi

            Console.WriteLine($"Tower of Hanoi 04 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_4}{towerHanoi_4}{towerHanoi_4}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 05
            // Į 1stulp 5eil įdėkite 4 dalių elementą, 2stulp 5eil - 3 dalių, 3stulp 4eil - 1 dalies, 3stulp 5eil - 2 dalių, ir išveskite Tower of Hanoi

            Console.WriteLine($"Tower of Hanoi 05 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_0}{towerHanoi_1}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_4}{towerHanoi_2}{towerHanoi_3}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 06
            // Į 1stulp 4eil įdėkite tokį pat elementą kaip yra 3stulp 4eil, ir išveskite Tower of Hanoi

            Console.WriteLine($"Tower of Hanoi 06 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_3}{towerHanoi_1}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_4}{towerHanoi_2}{towerHanoi_3}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 07
            // Į visas 2stulp eilutes įdėkite tokį pat elementą kaip yra 3stulp 5eil, ir išveskite Tower of Hanoi

            Console.WriteLine($"Tower of Hanoi 07 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_3}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_3}{towerHanoi_0}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_3}{towerHanoi_0}\n" +
                $"4eil.{towerHanoi_3}{towerHanoi_3}{towerHanoi_0}\n" +
                $"5eil.{towerHanoi_4}{towerHanoi_3}{towerHanoi_3}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 08
            // Į 3stulp sudėkite teisingą piramidę. 1stulp ir 2 stulp turi likti tušti, išveskite Tower of Hanoi

            Console.WriteLine($"Tower of Hanoi 08 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_1}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_2}\n" +
                $"4eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_3}\n" +
                $"5eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_4}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 09
            // Pakeiskite visų elementų dizainą iš # į " , išveskite Tower of Hanoi

            /* Pirmas variantas su naujais kintamaisiais
            string towerHanoi_1b = "      \"|\"   ";
            string towerHanoi_2b = "     \"\"|\"\"  ";
            string towerHanoi_3b = "    \"\"\"|\"\"\" ";
            string towerHanoi_4b = "   \"\"\"\"|\"\"\"\""; */

            // Antras variantas su Replace funkcija
            towerHanoi_0 = towerHanoi_0.Replace("#", "\"");
            towerHanoi_1 = towerHanoi_1.Replace("#", "\"");
            towerHanoi_2 = towerHanoi_2.Replace("#", "\"");
            towerHanoi_3 = towerHanoi_3.Replace("#", "\"");
            towerHanoi_4 = towerHanoi_4.Replace("#", "\"");

            Console.WriteLine($"Tower of Hanoi 09 \n\n" +
                $"1eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_0}\n" +
                $"2eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_1}\n" +
                $"3eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_2}\n" +
                $"4eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_3}\n" +
                $"5eil.{towerHanoi_0}{towerHanoi_0}{towerHanoi_4}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();


            // Tower of Hanoi: 10
            // Paprašykite naudotojo nupiešti 1 sulpelio 1 eilutę. Išveskite visą Tower of Hanoi su perpiešta pirma eilute

            Console.WriteLine("Enter your Hanoi piece: ");

            string towerHanoi_x = "   " + Console.ReadLine();

            Console.WriteLine($"Tower of Hanoi 10 \n\n" +
                $"1eil.{towerHanoi_x}{towerHanoi_4}{towerHanoi_2}\n" +
                $"2eil.{towerHanoi_3}{towerHanoi_3}{towerHanoi_3}\n" +
                $"3eil.{towerHanoi_4}{towerHanoi_2}{towerHanoi_4}\n" +
                $"4eil.{towerHanoi_3}{towerHanoi_3}{towerHanoi_3}\n" +
                $"5eil.{towerHanoi_2}{towerHanoi_4}{towerHanoi_2}\n" +
                $"       ---1stlp-------2stlp-------3stlp---- \n\n");

            Console.ReadKey();

            // Tower End

        }
    }
}