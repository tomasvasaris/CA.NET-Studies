namespace BM022
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ForEach loop/ciklas

            int[] pointArray = new int[10];
            pointArray[0] = 1;

            foreach (int points in pointArray)
            {
                Console.WriteLine(points);
            }

            List<string> names = new List<string> { "John", "Eve", "Kahn" };
            foreach (string name in names)
            {
                if (name == "Eve") { Console.WriteLine(name); }
            }
        }

        // Užduotis[Test01]
        // Integer sąrašo vidurkis
        public static int ListAverage(List<int> input)
        {
            int total = 0;

            foreach (int number in input)
            {
                total += number;
            }

            return (total / input.Count);
        }

        // Užduotis[Test02]
        // Grąžina ar skaičius sąraše neigiamas ar teigiamas
        public static List<string> ListPositivity(List<int> input)
        {
            var posList = new List<string>();

            foreach (int number in input)
            {
                if (number >= 0)
                { posList.Add("Pos"); } else
                { posList.Add("Neg"); }
            }

            return posList;
        }

        // Užduotis[01] || Ištraukti skaičių
        // Metodas priima tekstą ir gražina tik jame esančius skaičius
        // Kitas metodas surikiuoja skaičius (m>d, foreach, naujas List'as)
        public static string GetNumbersInText(string input)
        {
            string output = "";

            foreach (char key in input)
            {
                if (Int32.TryParse(key.ToString(), out _))
                { output += key; }
            }

            return output;
        }
        public static List<int> SortNumbersFromText(string input)
        {
            List<int> output = new List<int>(); 

            foreach (char key in input)
            {
                output.Add(key - 48);
            }

            output.Sort();
            return output;
        }

        /*
        //  Parašyti metodą IsmetytiZodzius, kuris priima sakini, bet grazina nauja zodziu List sudaryta tik is zodziu, kurie ilgesni nei 5 raides ir yra surikiuoti abeceles tvarka.
        //  Tada parasykite metoda, kuris priima 2 zodziu sarasus, juos sujungia i viena kolekcija naudojant ciklus ir atspausdina ekrane.
        //  PRIMINIMAS: Kad isskirti string i atskirus zodzius naudokite pavyzdinisString.Split(' ')
        //  PVZ: Ivedame: "Labas as esu Kodelskis ir labai megstu programuoti". 
        //  Programa be rusiavimo grazina mums: as esu ir Labas Kodelskis labai megstu programuoti
        //  Programa su rusiavimu grazina mums: as esu ir Kodelskis labai Labas megstu programuoti
        */
    }
}