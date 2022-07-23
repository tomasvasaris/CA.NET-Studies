using BasicMethods;

namespace BM022
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*/ ForEach loop/ciklas

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
            
            */


            var suits = new List<string>()
            {
                "Sirdziu",
                "Bugnu",
                "Vynu",
                "Kryziu",
            };

            var faces = new List<string>()
            {
                "Tuzas",
                "Dviake",
                "Triake",
                "Keturake",
                "Penkake",
                "Sesake",
                "Septynake",
                "Astuonake",
                "Devynakės",
                "Desimtake",
                "Valetas",
                "Dama",
                "Karalius",
            };

            PrintDeck(SortDeck(ConstructDeck(suits, faces)));
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

        // Užduotis[02] || Išmėtyti žodžius
        // n/a
        public static List<string> ScrambleWords(List<string> input)
        {
            var longer = new List<string>();
            var shortr = new List<string>();

            foreach (string item in input)
            {
                if (item.Length >= 5)
                { longer.Add(item); } else
                { shortr.Add(item); }
            }

            shortr.AddRange(longer);
            return shortr;
        }

        // 21-07-2022

        // Užduotis[03] || Statome Kaladę
        // Parašyti metodą kuris sukonstruoja kaladę iš dviejų string list'ų
        // Paaršyti kitą metodą kuris surikiuoja kaladę pagal abėcėlę
        // Atspausdinti visą kaladę ekrane

        public static List<string> ConstructDeck(List<string> suits, List<string> faces)
        {
            var cards = new List<string>();

            foreach (string suit in suits)
            {
                foreach (string face in faces)
                {
                    cards.Add(suit + " " + face);
                }
            }

            return cards;
        }

        public static List<string> SortDeck(List<string> cards) { cards.Sort(); return cards; }

        public static void PrintDeck(List<string> cards)
        {
            foreach (string card in cards)
            {
                Console.WriteLine(card);
            }
        }

    }
}