namespace BM020
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 19-07-2022 || Lists

            List<int> intLists = new List<int> { 1, 2, 3 };
            List<string> autos = new List<string> { "Volvo", "Audi", "BMV" };

            autos.Add("Toyota");                 // Add another item to the e/o list
            Console.WriteLine(String.Join(", ", autos)); // funky!

            autos[2] = "Mazda";                  // Replace [2] with new value
            int autosCount = autos.Count;        // Number o'items in the list

            List<string> moreAutos = new List<string> { "Mercedes", "VW" };
            autos.AddRange(moreAutos);           // Combine lists

            autos.RemoveAt(0);                   // Clear first item
            autos.Insert(2, "Porsche");          // Insert new item
            // abiejuose įvyksta reindex'avimas, trunka ilgai, VENGTI!

            bool hasBMW = autos.Contains("BMW"); // Searching for specific item
            autos.Sort();                        // Sorting
            autos.Sort((x, y) => y.CompareTo(x));// Sorting [reversed]
            intLists.Sort((x, y) => y-x);        // Sorting [reversed, int]

            string[] autoArray = autos.ToArray();// Convert list to array

            autos.Clear();                       // Clear ALL items


            List<int> test = new List<int> { 5, 1, 6, 8, 7 };
            Console.WriteLine(largerThanLargest(test)[5]);

            // Užduotis[1]
            // Didžiausias skaičius sąraše

            // Užduotis[2]
            // Pridėti prie sąrašo vienu didesnį nei didžiausias skaičių
        }

        public static int largestInList(List<int> input)
        {
            //return input.Max();

            input.Sort();
            return input[input.Count - 1];
        }

        public static List<int> largerThanLargest(List<int> input)
        {
            int largest = input[1];

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > largest) { largest = input[i]; }
            }

            input.Add(largest + 1);
            return input;
        }
    }
}