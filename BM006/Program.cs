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
            Console.WriteLine($"Konvertacija į Kelviną sėkminga? {Celcius == CalciusKel}");

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

            // Termometras
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
            Console.WriteLine($" {(Celcius    * 9 / 5) + 32} \t - |#| -    {Celcius}   ");
            Console.WriteLine($" {(CelciusN05 * 9 / 5) + 32} \t - |#| -    {CelciusN05}");
            Console.WriteLine($" {(CelciusN10 * 9 / 5) + 32} \t - |#| -    {CelciusN10}");
            Console.WriteLine($" {(CelciusN15 * 9 / 5) + 32} \t - |#| -    {CelciusN15}");
            Console.WriteLine($" {(CelciusN20 * 9 / 5) + 32} \t - |#| -    {CelciusN20}");
            Console.WriteLine($" {(CelciusN25 * 9 / 5) + 32} \t - |#| -    {CelciusN25}");
            Console.WriteLine($" {(CelciusN30 * 9 / 5) + 32} \t - |#| -    {CelciusN30}");
            Console.WriteLine($" {(CelciusN35 * 9 / 5) + 32} \t - |#| -    {CelciusN35}");
            Console.WriteLine($" {(CelciusN40 * 9 / 5) + 32} \t - |#| -    {CelciusN40}");
            Console.WriteLine($"          (###)       ");
            Console.WriteLine($"           |_|       ");
            Console.WriteLine("");

            Console.WriteLine("Termometro pabaiga.\n\n");
            // Komentaras: nesugalvojau kur galėtų prireikti .ToString() ir .Replace() :(



            // UŽDUOTIS: Kelias

            Console.WriteLine("Įveskite atstumą kilometrais:");
            double atstumas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įveskite A transporto greitį:");
            double greitisA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Įveskite B transporto greitį:");
            double greitisB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            // Laiko kintamieji
            double laikasVal = atstumas / (greitisA + greitisB);    // Susidūrimo laikas
            double laikasMinA = greitisA * atstumas;   // A transporto praleistas laikas
            double laikasMinB = greitisB * atstumas;   // B transporto praleistas laikas

            // Susitikimo vieta
            double vietaKm = laikasVal* greitisA;
            Console.WriteLine($"Susitikimo vieta metrais:      {vietaKm * 1000}");

            // Laikas; išvedimas
            Console.WriteLine($"Susitikimo laikas sekundėmis:  {laikasVal * 3600}");
            Console.WriteLine($"Atvykimo laikas minutėmis (A): {laikasMinA * 60}");
            Console.WriteLine($"Atvykimo laikas minutėmis (B): {laikasMinB * 60}");

            // CO2 tarša (95 g/km)
            Console.WriteLine($"Bendra kelionių tarša gramais: {atstumas * 95 * 2}");

            // Segmentacija į 20 dalių
            int seg0 = Convert.ToInt32(atstumas) / 20;

            // Segmentai 01
            string seg1  = Convert.ToString((vietaKm > (seg0 * 0 )) && (vietaKm <= seg0 * 1 )).Replace("True", "V").Replace("False", "_");
            string seg2  = Convert.ToString((vietaKm > (seg0 * 1 )) && (vietaKm <= seg0 * 2 )).Replace("True", "V").Replace("False", "_");
            string seg3  = Convert.ToString((vietaKm > (seg0 * 2 )) && (vietaKm <= seg0 * 3 )).Replace("True", "V").Replace("False", "_");
            string seg4  = Convert.ToString((vietaKm > (seg0 * 3 )) && (vietaKm <= seg0 * 4 )).Replace("True", "V").Replace("False", "_");
            string seg5  = Convert.ToString((vietaKm > (seg0 * 4 )) && (vietaKm <= seg0 * 5 )).Replace("True", "V").Replace("False", "_");
            string seg6  = Convert.ToString((vietaKm > (seg0 * 5 )) && (vietaKm <= seg0 * 6 )).Replace("True", "V").Replace("False", "_");
            string seg7  = Convert.ToString((vietaKm > (seg0 * 6 )) && (vietaKm <= seg0 * 7 )).Replace("True", "V").Replace("False", "_");
            string seg8  = Convert.ToString((vietaKm > (seg0 * 7 )) && (vietaKm <= seg0 * 8 )).Replace("True", "V").Replace("False", "_");
            string seg9  = Convert.ToString((vietaKm > (seg0 * 8 )) && (vietaKm <= seg0 * 9 )).Replace("True", "V").Replace("False", "_");
            string seg10 = Convert.ToString((vietaKm > (seg0 * 9 )) && (vietaKm <= seg0 * 10)).Replace("True", "V").Replace("False", "_");
            string seg11 = Convert.ToString((vietaKm > (seg0 * 10)) && (vietaKm <= seg0 * 11)).Replace("True", "V").Replace("False", "_");
            string seg12 = Convert.ToString((vietaKm > (seg0 * 11)) && (vietaKm <= seg0 * 12)).Replace("True", "V").Replace("False", "_");
            string seg13 = Convert.ToString((vietaKm > (seg0 * 12)) && (vietaKm <= seg0 * 13)).Replace("True", "V").Replace("False", "_");
            string seg14 = Convert.ToString((vietaKm > (seg0 * 13)) && (vietaKm <= seg0 * 14)).Replace("True", "V").Replace("False", "_");
            string seg15 = Convert.ToString((vietaKm > (seg0 * 14)) && (vietaKm <= seg0 * 15)).Replace("True", "V").Replace("False", "_");
            string seg16 = Convert.ToString((vietaKm > (seg0 * 15)) && (vietaKm <= seg0 * 16)).Replace("True", "V").Replace("False", "_");
            string seg17 = Convert.ToString((vietaKm > (seg0 * 16)) && (vietaKm <= seg0 * 17)).Replace("True", "V").Replace("False", "_");
            string seg18 = Convert.ToString((vietaKm > (seg0 * 17)) && (vietaKm <= seg0 * 18)).Replace("True", "V").Replace("False", "_");
            string seg19 = Convert.ToString((vietaKm > (seg0 * 18)) && (vietaKm <= seg0 * 19)).Replace("True", "V").Replace("False", "_");
            string seg20 = Convert.ToString((vietaKm > (seg0 * 19)) && (vietaKm <= seg0 * 20)).Replace("True", "V").Replace("False", "_");

            // Segmentai 02
            string xseg1  = (vietaKm <= seg0 * 1 ).ToString().Replace("True", "").Replace("False", "------");
            string xseg2  = (vietaKm <= seg0 * 2 ).ToString().Replace("True", "").Replace("False", "------");
            string xseg3  = (vietaKm <= seg0 * 3 ).ToString().Replace("True", "").Replace("False", "------");
            string xseg4  = (vietaKm <= seg0 * 4 ).ToString().Replace("True", "").Replace("False", "------");
            string xseg5  = (vietaKm <= seg0 * 5 ).ToString().Replace("True", "").Replace("False", "------");
            string xseg6  = (vietaKm <= seg0 * 6 ).ToString().Replace("True", "").Replace("False", "------");
            string xseg7  = (vietaKm <= seg0 * 7 ).ToString().Replace("True", "").Replace("False", "------");
            string xseg8  = (vietaKm <= seg0 * 8 ).ToString().Replace("True", "").Replace("False", "------");
            string xseg9  = (vietaKm <= seg0 * 9 ).ToString().Replace("True", "").Replace("False", "------");
            string xseg10 = (vietaKm <= seg0 * 10).ToString().Replace("True", "").Replace("False", "------");
            string xseg11 = (vietaKm <= seg0 * 11).ToString().Replace("True", "").Replace("False", "------");
            string xseg12 = (vietaKm <= seg0 * 12).ToString().Replace("True", "").Replace("False", "------");
            string xseg13 = (vietaKm <= seg0 * 13).ToString().Replace("True", "").Replace("False", "------");
            string xseg14 = (vietaKm <= seg0 * 14).ToString().Replace("True", "").Replace("False", "------");
            string xseg15 = (vietaKm <= seg0 * 15).ToString().Replace("True", "").Replace("False", "------");
            string xseg16 = (vietaKm <= seg0 * 16).ToString().Replace("True", "").Replace("False", "------");
            string xseg17 = (vietaKm <= seg0 * 17).ToString().Replace("True", "").Replace("False", "------");
            string xseg18 = (vietaKm <= seg0 * 18).ToString().Replace("True", "").Replace("False", "------");
            string xseg19 = (vietaKm <= seg0 * 19).ToString().Replace("True", "").Replace("False", "------");
            string xseg20 = (vietaKm <= seg0 * 20).ToString().Replace("True", "").Replace("False", "------");

            // Kelelis
            Console.WriteLine($"\nKelelis:");
            Console.WriteLine("");
            Console.WriteLine($" |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |{seg0,4} |");
            Console.WriteLine($" |     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |     |");
            Console.WriteLine($"_A__{seg1}__|__{seg2}__|__{seg3}__|__{seg4}__|__{seg5}__|__{seg6}__|__{seg7}__|__{seg8}__|__{seg9}__|__{seg10}__|__{seg11}__|__{seg12}__|__{seg13}__|__{seg14}__|__{seg15}__|__{seg16}__|__{seg17}__|__{seg18}__|__{seg19}__|__{seg20}__B_");
            Console.WriteLine($" |{xseg1}{xseg2}{xseg3}{xseg4}{xseg5}{xseg6}{xseg7}{xseg8}{xseg9}{xseg10}{xseg11}{xseg12}{xseg13}{xseg14}{xseg15}{xseg16}{xseg17}{xseg18}{xseg19}{xseg20}--| ({vietaKm} km)");
            Console.WriteLine("");
            Console.WriteLine($" |------------------------------------------------------ {atstumas, 6} km ------------------------------------------------------| ");
            Console.WriteLine($" |>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> {laikasMinA, 5} min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>| ");
            Console.WriteLine($" |<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< {laikasMinB, 5} min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<| ");
            Console.WriteLine("");

            Console.WriteLine("Kelio pabaiga.\n\n");
            // Komentaras: Įdomi užduotis! Iš pradžių maniau kad bus neįmanoma apsieit be IF'o, bet va

        }
    }
}