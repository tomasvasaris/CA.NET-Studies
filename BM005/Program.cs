﻿namespace BM005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paskaitos konspektai 14-06-2022

            /*

            Console.WriteLine("Reliaciniai operatoriai \n");

            var skaiciusLyginis = 10;
            var skaiciusNelyginis = 5;
            Console.WriteLine($"{skaiciusLyginis} == {skaiciusNelyginis} yra {skaiciusLyginis == skaiciusNelyginis} \n");

            bool is10equal5 = skaiciusLyginis == skaiciusNelyginis;


            // Užduotis 01

            long skaiciusIlgas = long.MaxValue;
            short skaiciusShort = short.MaxValue;
            double rezultatas = (double)skaiciusIlgas / skaiciusShort;

            Console.WriteLine($"Padalinta: {rezultatas};");
            Console.WriteLine($"Atimta:    {rezultatas - skaiciusIlgas};");
            Console.WriteLine($"Pridėta:   {rezultatas - skaiciusIlgas + int.MaxValue}.");
            Console.WriteLine("");


            // Užduotis 02

            double skaiciusDickis = 1234567890;

            //Console.WriteLine($"Int:   {Convert.ToInt32(skaiciusDickis)}"); no error
            //Console.WriteLine($"Short: {Convert.ToInt16(skaiciusDickis)}"); ERROR!!!
            //Console.WriteLine($"Byte:  {Convert.ToByte(skaiciusDickis)}");  ERROR!!!

            Console.WriteLine($"Int:   {(int)skaiciusDickis}");
            Console.WriteLine($"Short: {(short)skaiciusDickis}");
            Console.WriteLine($"Byte:  {(byte)skaiciusDickis}");
            Console.WriteLine("");


            // Užduotis 03

            Console.WriteLine("Įveskite rutulio diametrą:");
            double diameter = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"Plotas: {4 * Math.PI * Math.Pow(diameter / 2, 2)}");
            Console.WriteLine($"Tūris:  {4 / 3 * Math.PI * Math.Pow(diameter / 2, 3)}");
            Console.WriteLine("");


            // Užduotis 04

            Console.WriteLine("Įveskite atstumą (metrais):");
            double atstumas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Įveskite laiką (sekumdėmis):");
            double laikas = Convert.ToDouble(Console.ReadLine());

            int metraiKile = 1000;
            int sekundesVal = 3600;

            Console.WriteLine("");
            Console.WriteLine($"Greitis (km/h): {(atstumas * metraiKile) / (laikas * sekundesVal)}");
            Console.WriteLine($"Greitis (km/s): {(atstumas * metraiKile) / laikas}");
            Console.WriteLine("");


            // Užduotis 05

            Console.WriteLine("Įveskite skaičių (x):");
            double skaiciusX0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Įveskite skaičių (y):");
            double skaiciusY0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"y+2y+x+1: {skaiciusY0 + 2 * skaiciusY0 + skaiciusX0 + 1}\n");


            // Užduotis 06

            Console.WriteLine("Įveskite skaičių (x):");
            double skaiciusX1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Įveskite skaičių (y):");
            double skaiciusY1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"y²+x/2: {skaiciusY1 * skaiciusY1 + skaiciusX1 / 2}\n");


            // Užduotis 07

            Console.WriteLine("Įveskite penkiaženklį skaičių:");
            string skaiciusString = Console.ReadLine();

            skaiciusString = skaiciusString.Replace('1', '0');
            double skaicius5 = Convert.ToDouble(skaiciusString);

            Console.WriteLine($"Rezultatas: {skaicius5 / 2}");


            // Užduotis 08

            Console.WriteLine("Įveskite penkiaženklį sveikąjį skaičių:");
            string skaiciusString = Console.ReadLine();

            skaiciusString = skaiciusString.Replace('2', '0');
            skaiciusString = skaiciusString.Replace('3', '0');
            skaiciusString = skaiciusString.Replace('4', '0');
            skaiciusString = skaiciusString.Replace('5', '0');
            skaiciusString = skaiciusString.Replace('6', '0');
            skaiciusString = skaiciusString.Replace('7', '0');
            skaiciusString = skaiciusString.Replace('8', '0');
            skaiciusString = skaiciusString.Replace('9', '0');

            double skaicius5 = Convert.ToDouble(skaiciusString);

            Console.WriteLine($"Rezultatas ({skaicius5}/2): {skaicius5 / 2}");

            // Dėstytojo sprendimas
            Console.WriteLine("Įveskite penkiaženklį sveikąjį skaičių:");
            var skaicius = Convert.ToDouble(Console.ReadLine()
                .Replace('2', '0')
                .Replace('3', '0')
                .Replace('4', '0')
                .Replace('5', '0')
                .Replace('6', '0')
                .Replace('7', '0')
                .Replace('8', '0')
                .Replace('9', '0'));

            Console.WriteLine($"Rezultatas ({skaicius}/2): {skaicius / 2}");


            // Užduotis 09
            Console.WriteLine("Įveskite sveikąjį skaičių:");
            long sk = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Rezultatas: {++sk} {++sk} {++sk} {++sk} {++sk}"); // ++ after == doesn't work correctly

            */


            // Paskaitos konspektai 15-06-2022

            Console.WriteLine($"");

        }
    }
}