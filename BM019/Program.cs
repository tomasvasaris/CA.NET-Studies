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