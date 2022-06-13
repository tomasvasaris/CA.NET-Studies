namespace BM004
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Implicit casting
            // byte-> short-> int-> long-> float-> double-> decimal
            int numberInt = 100;
            long numberLong = 100;
            long castedLong0 = (long)numberInt;
            long castedLong1 = numberInt;
            var  castedLong2 = (long)numberInt;
            byte numberByte = 200;
            long numberLong2 = numberByte;
            long numberLong3 = castedLong2;
            //etc

            // Explicit casting
            // decimal-> double-> float-> long-> int-> char
            int castedInt0 = (int)numberLong;
            float numberFloat = 5.6f;
            int castedInt1 = (int)numberFloat; // apvalinimas neįvyksta
            char numberLetter = 'a';
            int castedInt2 = numberLetter; // nereikia įmantrybių
            int castedLong3 = numberLetter;

            // Type Conversion Methods
            string convertString0 = Convert.ToString(numberInt);
            string convertString1 = numberInt.ToString();
            long convertLong0 = Convert.ToInt64(numberLong);
            double convertDouble = Convert.ToDouble(numberInt);

            // Nullable types
            int? numberIntNull = null;
            //long castedLong4 = (long)numberIntNull; BREAKS
            long convertLong1 = Convert.ToInt64(numberIntNull);
            // also BREAKS but returns default value (i.e. 0)

            // Parsing
            string numberString = "100";
            int numberIntParsed = int.Parse(numberString);
            //Console.WriteLine($"numberIntParsed + 1 = {numberString + 1}");
            //Console.WriteLine($"numberIntParsed + 1 = {numberIntParsed + 1}");
            string numberStringHuuuge = "999999999999999999999999"; // too large to be parsed
            string textas = "asafafafsdg"; // text cannot be parsed


            // OPERATORS
            int skaicius;
            int kitasSkaicius = 20;
            skaicius = 10;
            skaicius += kitasSkaicius; // skaicius = skaicius + kitasSkaicius

            double dalyba = (double)skaicius / kitasSkaicius; // nekonvertuojant neveiks


            // Overflow and Underflow

            short shorty1 = 30_000;
            short shorty2 = 30_000;
            short shorty3;
            //shorty3 = short(shorty1 + shorty2); // lūžta įjungus opciją stebėti kada įvyksta Overflow



            /* Užduotis 01

            Console.WriteLine($"Write a number, please");
            double numberOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nWrite another number, please");
            double numberTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"Sum:    {numberOne + numberTwo}");
            Console.WriteLine($"Dif:    {numberOne - numberTwo}");
            Console.WriteLine($"Mul:    {numberOne * numberTwo}");
            Console.WriteLine($"Div:    {numberOne / numberTwo}");


            // Užduotis 02

            Console.WriteLine($"Write a number, please");
            double numberAvg1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Write another number, please");
            double numberAvg2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"And another number, please");
            double numberAvg3 = Convert.ToDouble(Console.ReadLine());
            double numberAvg0 = (numberAvg1 + numberAvg2 + numberAvg3)/3;
            Console.WriteLine("");
            Console.WriteLine($"Average: {numberAvg0}");

            */


            // Užduotis 03

            long labaiIlgas = long.MaxValue;
            short labaiTrumpas = short.MaxValue;

            //end

        }
    }
}