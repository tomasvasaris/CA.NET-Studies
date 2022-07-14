using BasicMethods;

namespace BM018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            // Masyvai. Teorija

            int number0 = MyMods.IntAsk();
            int number1 = 100;

            int[] numberArray = { number0, number1, 420, 25 };

            Console.WriteLine(numberArray[0]);      // pasirinkti vieną masyvo dalį
            Console.WriteLine(numberArray[2]);
            numberArray[2] = 130;                   // pakeisti kažkurią masyvo dalį
            Console.WriteLine(numberArray[2]);

            int[][] doubleArray0 = new int[4][];    // dvigubi masyvai
            int[,]  doubleArray1 = new int[4,5];

            */


            SchoolArray(); // Užduotis[3]. Įvesti mokinių skaičių, tada mokinių vardus, tada atspausdinti vardus atvirkštine tvarka


        }

        static void SchoolArray()
        {
            int number = MyMods.IntAsk("number of students");
            string[] names = new string[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter a student name: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(names[number-i-1]);
            }
        }
    }
}