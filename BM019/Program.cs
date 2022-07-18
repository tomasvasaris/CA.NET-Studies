namespace BM019
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Užduotis [01]
            // Rasti mažiausią skaičių masyve

            // Užduotis [02]
            // Rasti didžiausią skaičių masyve

            // Užduotis [03]
            // Surikiuoti masyvą nuo didžiausio iki mažiausio

            // Užduotis [04]
            // Paprašoma įvesti 3 raides
            // Validuojama kad tai char simboliai
            // Surikiuojamas masyvas pagal abėcėlę

            char[] test = new char[] { 'd', 'A', 'z', 'o', 'd', 'i' };
            test = sortArrayABC(test);
            Console.WriteLine($"{test[0]}, {test[1]}, {test[2]}, {test[3]}, {test[4]}, {test[5]}");

        }

        public static char[] sortArrayABC(char[] input)
        {
            for (int i = 0; i < (input.Length - 1); i++)
            {
                if (Convert.ToInt32(input[i]) > Convert.ToInt32(input[i + 1]))
                {
                    char temp = input[i];
                    input[i] = input[i + 1];
                    input[i + 1] = temp;
                }
            }

            return input;
        }

        public static char[] ThreeLetters()
        {
            Console.WriteLine("Please write the 1st letter:");
            char letter1 = ValidateChar(Console.ReadLine());

            Console.WriteLine("Please write the 2nd letter:");
            char letter2 = ValidateChar(Console.ReadLine());

            Console.WriteLine("Please write the 3rd letter:");
            char letter3 = ValidateChar(Console.ReadLine());

            char[] letters = new char[3] { letter1, letter2, letter3 };
            return letters;
        }
        public static char ValidateChar(string input)
        {
            for (; ; )
            {
                if (Char.TryParse(input, out _) == false)
                {
                    Console.WriteLine("That is not a char, try again");
                    input = Console.ReadLine();
                }
                else { return Convert.ToChar(input); }
            }
        }

        public static int[] sortArrayFromLargest(int[] input)
        {
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] < input[i+1])
                {
                    int temp = input[i];
                    input[i] = input[i + 1];
                    input[i + 1] = temp;
                }
            }

            return input;
        }

        public static int SmallestArrayNo(int[] inputArray)
        {
            int smallest = inputArray[0];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] < smallest) { smallest = inputArray[i]; } 
            }

            return smallest;
        }

        public static int LargestArrayNo(int[] inputArray)
        {
            int largest = inputArray[0];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > largest) { largest = inputArray[i]; }
            }

            return largest;
        }
    }
}