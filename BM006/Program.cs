namespace BM006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UŽDUOTIS: Termometras

            Console.WriteLine("Įveskite temperatūrą pagal Celsijų:");
            double Celcius = Convert.ToDouble(Console.ReadLine());

            // Farenheito formulė: (0°C × 9/5) + 32 = 32°F
            double Farenheit = (Celcius * 9 / 5) + 32;

            // Kelvino formulė:    0°C + 273.15 = 273.15K
            double Kelvin = Celcius + 273.15;

            // Far atgal į Cel:    (0°F − 32) × 5/9 = -17.78°C
            double CalciusFar = (Farenheit - 32) * 5 / 9;
            Console.WriteLine($"\nKonvertacija į Farenheitą sėkminga? {Celcius == CalciusFar}");

            // Kel atgal į Cel:    0K − 273.15 = -273.1°C
            double CalciusKel = Kelvin - 273.15;
            Console.WriteLine($"Konvertacija į Kelviną sėkminga? {Celcius == CalciusFar}");

            // Far konv. į Kel:    (0°F − 32) × 5/9 + 273.15 = 255.372K
            double FarenheitKel = (Farenheit - 32) * 5 / 9 + 273.15;
            Console.WriteLine($"Farenheito konvertacija sėkminga? {Kelvin == FarenheitKel}");

            // Kintamieji
            double CelciusP40 = Celcius + 40;
            double CelciusP35 = Celcius + 35;
            double CelciusP30 = Celcius + 30;
            double CelciusP25 = Celcius + 25;
            double CelciusP20 = Celcius + 20;
            double CelciusP15 = Celcius + 15;
            double CelciusP10 = Celcius + 10;
            double CelciusP05 = Celcius + 5;
            double CelciusN40 = Celcius - 40;
            double CelciusN35 = Celcius - 35;
            double CelciusN30 = Celcius - 30;
            double CelciusN25 = Celcius - 25;
            double CelciusN20 = Celcius - 20;
            double CelciusN15 = Celcius - 15;
            double CelciusN10 = Celcius - 10;
            double CelciusN05 = Celcius - 5;

            // termometras
            Console.WriteLine("\nTermometras:");
            Console.WriteLine("");
            Console.WriteLine($"  ^F        -        ^C  ");
            Console.WriteLine($" {(CelciusP40 * 9 / 5) + 32} \t - | | -    {CelciusP40}");
            Console.WriteLine($" {(CelciusP35 * 9 / 5) + 32} \t - | | -    {CelciusP35}");
            Console.WriteLine($" {(CelciusP30 * 9 / 5) + 32} \t - | | -    {CelciusP30}");
            Console.WriteLine($" {(CelciusP25 * 9 / 5) + 32} \t - | | -    {CelciusP25}");
            Console.WriteLine($" {(CelciusP20 * 9 / 5) + 32} \t - | | -    {CelciusP20}");
            Console.WriteLine($" {(CelciusP15 * 9 / 5) + 32} \t - | | -    {CelciusP15}");
            Console.WriteLine($" {(CelciusP10 * 9 / 5) + 32} \t - | | -    {CelciusP10}");
            Console.WriteLine($" {(CelciusP05 * 9 / 5) + 32} \t - | | -    {CelciusP05}");
            Console.WriteLine($" {((Celcius) * 9 / 5) + 32} \t - | | -    {Celcius}   ");
            Console.WriteLine($" {(CelciusN05 * 9 / 5) + 32} \t - | | -    {CelciusN05}");
            Console.WriteLine($" {(CelciusN10 * 9 / 5) + 32} \t - | | -    {CelciusN10}");
            Console.WriteLine($" {(CelciusN15 * 9 / 5) + 32} \t - | | -    {CelciusN15}");
            Console.WriteLine($" {(CelciusN20 * 9 / 5) + 32} \t - | | -    {CelciusN20}");
            Console.WriteLine($" {(CelciusN25 * 9 / 5) + 32} \t - | | -    {CelciusN25}");
            Console.WriteLine($" {(CelciusN30 * 9 / 5) + 32} \t - | | -    {CelciusN30}");
            Console.WriteLine($" {(CelciusN35 * 9 / 5) + 32} \t - | | -    {CelciusN35}");
            Console.WriteLine($" {(CelciusN40 * 9 / 5) + 32} \t - | | -    {CelciusN40}");
            Console.WriteLine($"          (___)       ");
            Console.WriteLine("");

            Console.WriteLine("Termometro pabaiga.\n\n");
            // Komentaras: nesugalvojau kur galėtų prireikti .ToString() ir .Replace() :(



            // UŽDUOTIS: Kelias


























            Console.WriteLine("Kelio pabaiga.\n\n");
            // Komentaras: N/A

            // užduočių pabaiga
        }
    }
}