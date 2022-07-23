namespace BM023
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dictionaries | Žodynai

            PrintDictionary();
        }

        public static void DictionaryExamples()
        {
            var demoDict = new Dictionary<string, double>(3);
            var cityDict = new Dictionary<string, int>
            {
                { "Vilnius", 8 },
                { "Kaunas" , 4 },
                { "Mariukė", 8 },
            };
        }

        // Užduotis[01] Kėlimas kvadratu
        public static Dictionary<int, int> SquareDictionary(int input)
        {
            var output = new Dictionary<int, int>();

            for (int i = 1; i < input+1; i++)
            {
                output.Add(i, i*i);
            }

            return output;
        }

        public static void PrintDictionary()
        {
            var dict = SquareDictionary(5);

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Value}:{item.Value}");
            }
        }

    }
}