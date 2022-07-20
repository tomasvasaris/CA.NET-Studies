using System;
using System.Collections.Generic;

namespace BM022
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ForEach loop/ciklas

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

        }

        // Užduotis[1]
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

        // Užduotis[2]
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

        // Užduotis[3]
        // 
        public static List<string> UNKNOWN(List<int> input)
        {
            var posList = new List<string>();

            foreach (int number in input)
            {
                if (number >= 0)
                { posList.Add("Pos"); }
                else
                { posList.Add("Neg"); }
            }

            return posList;
        }
    }
}