namespace BM008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            Console.WriteLine("Select menu option no.(1-3)");
            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("Selection 1");
                    break;
                case 2:
                    Console.WriteLine("Selection 2");
                    break;
                case 3:
                    Console.WriteLine("Selection 3");
                    break;
                default:
                    Console.WriteLine("Klaida.");
                    break;
            }

            Console.WriteLine("---------------------------");

            string menuChoiceX = menuChoice switch
            {
                1 => "Selection 1",
                2 => "Selection 2",
                3 => "Selection 3",
                _ => "Klaida."
            };
            Console.WriteLine(menuChoiceX);


            // UŽDUOTIS 01

            Console.WriteLine("Parašykite jūsų egzamino rezą: ");
            int examGrade = Convert.ToInt32(Console.ReadLine());

            switch (examGrade)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Nepatenkinamai");
                    break;
                case 5:
                    Console.WriteLine("Silpnai");
                    break;
                case 6:
                    Console.WriteLine("Patenkinamai");
                    break;
                case 7:
                    Console.WriteLine("Vidutiniškai");
                    break;
                case 8:
                    Console.WriteLine("Gerai");
                    break;
                case 9:
                    Console.WriteLine("Labai gerai");
                    break;
                case 10:
                    Console.WriteLine("Nuostabiai");
                    break;
                default:
                    Console.WriteLine("Klaida :(");
                    break;
            }

            Console.WriteLine("------------------------------");


            string examMenu = examGrade switch
            {
                0 or 1 or 2 or 3 or 4 => "Nepatenkinamai",
                5 => "Silpnai",
                6 => "Patenkinamai",
                7 => "Vidutiniškai",
                8 => "Gerai",
                9 => "Labai gerai",
                10=> "Nuostabiai",
                _ => "Klaida :("
            };
            Console.WriteLine(examMenu);

            Console.WriteLine("------------------------------");


            examMenu = "";

            if (examGrade >= 0 && examGrade < 5)
            {
                examMenu = "Nepatenkinamai";
            }
            else if (examGrade == 5)
            {
                examMenu = "Silpnai";
            }
            else if (examGrade == 6)
            {
                examMenu = "Patenkinamai";
            }
            else if (examGrade == 7)
            {
                examMenu = "Vidutiniškai";
            }
            else if (examGrade == 8)
            {
                examMenu = "Gerai";
            }
            else if (examGrade == 9)
            {
                examMenu = "Labai gerai";
            }
            else if (examGrade == 10)
            {
                examMenu = "Nuostabiai";
            }
            else
            {
                examMenu = "Klaida :(";
            }

            Console.WriteLine(examMenu);

            Console.WriteLine("------------------------------");


            // UŽDUOTIS 02

            Console.WriteLine("Parašykite kiek kavos puodelių perkate: ");
            int kava = Convert.ToInt32(Console.ReadLine()) / 3;

            Console.WriteLine(kava == 0 ?
                "Jums nepriklauso nemokama kava" :
                $"Jums priklauso {kava} nemokami puodeliai");


            // UŽDUOTIS 03

            Console.WriteLine("Parašykite skaičių no.1: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parašykite skaičių no.2: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parašykite skaičių no.3: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parašykite skaičių no.4: ");
            int skaicius4 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > 0 || skaicius1 < 0)
            {
                Console.Write($"{skaicius1} -> {skaicius1 * -1}; ");
            }
            else
            {
                Console.Write($"{skaicius1} -> N/A; ");
            }

            if (skaicius2 > 0 || skaicius2 < 0)
            {
                Console.Write($"{skaicius2} -> {skaicius2 * -1}; ");
            }
            else
            {
                Console.Write($"{skaicius2} -> N/A; ");
            }

            if (skaicius3 > 0 || skaicius3 < 0)
            {
                Console.Write($"{skaicius3} -> {skaicius3 * -1}; ");
            }
            else
            {
                Console.Write($"{skaicius3} -> N/A; ");
            }

            if (skaicius4 > 0 || skaicius4 < 0)
            {
                Console.Write($"{skaicius4} -> {skaicius4 * -1}; ");
            }
            else
            {
                Console.Write($"{skaicius4} -> N/A; ");
            }


            // UŽDUOTIS 04

            Console.WriteLine("Parašykite skaičių no.1: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parašykite skaičių no.2: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parašykite skaičių no.3: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Parašykite skaičių no.4: ");
            int skaicius4 = Convert.ToInt32(Console.ReadLine());

            Console.Write(skaicius1 == 0 ?
                $"{skaicius1} - > N/A; " :
                $"{skaicius1} - > {skaicius1 * -1}; ");

            Console.Write(skaicius2 == 0 ?
                $"{skaicius2} - > N/A; " :
                $"{skaicius2} - > {skaicius2 * -1}; ");

            Console.Write(skaicius3 == 0 ?
                $"{skaicius3} - > N/A; " :
                $"{skaicius3} - > {skaicius3 * -1}; ");

            Console.Write(skaicius4 == 0 ?
                $"{skaicius4} - > N/A; " :
                $"{skaicius4} - > {skaicius4 * -1}; ");


            // UŽDUOTIS 05

            Random randomNumber = new Random();
            int randNo = randomNumber.Next(1, 20);

            Console.WriteLine("Guess a number between 1 and 20! \n");

            Console.WriteLine("Write guess no.1: ");
            int guess1 = Convert.ToInt32(Console.ReadLine());

            if (guess1 == randNo)
            {
                Console.WriteLine("CORRECT! WOW!");
            }
            else
            {
                if (guess1 > 20 || guess1 < 1)
                {
                    Console.WriteLine("Incorrect number!");
                }
                else if (guess1 > randNo)
                {
                    Console.WriteLine("Too High!");
                }
                else if (guess1 < randNo)
                {
                    Console.WriteLine("Too Low!");
                }

                Console.WriteLine("Write guess no.2: ");
                int guess2 = Convert.ToInt32(Console.ReadLine());

                if (guess2 == randNo)
                {
                    Console.WriteLine("CORRECT!!");
                }
                else
                {
                    if (guess2 > 20 || guess2 <1)
                    {
                        Console.WriteLine("Incorrect number!");
                    }
                    else if (guess2 > randNo)
                    {
                        Console.WriteLine("Too High!");
                    }
                    else if (guess2 < randNo)
                    {
                        Console.WriteLine("Too Low!");
                    }

                    Console.WriteLine("Write guess no.3: ");
                    int guess3 = Convert.ToInt32(Console.ReadLine());

                    if (guess3 == randNo)
                    {
                        Console.WriteLine("CORRECT!");
                    }
                    else
                    {
                        if (guess3 > 20 || guess3 < 1)
                        {
                            Console.WriteLine("Incorrect number!");
                        }
                        else if (guess3 > randNo)
                        {
                            Console.WriteLine("Too High!");
                        }
                        else if (guess3 < randNo)
                        {
                            Console.WriteLine("Too Low!");
                        }

                        Console.WriteLine("Write guess no.4: ");
                        int guess4 = Convert.ToInt32(Console.ReadLine());

                        if (guess4 == randNo)
                        {
                            Console.WriteLine("CORRECT!");
                        }
                        else
                        {
                            if (guess4 > 20 || guess4 < 1)
                            {
                                Console.WriteLine("Incorrect number!");
                            }
                            else if (guess4 > randNo)
                            {
                                Console.WriteLine("Too High!");
                            }
                            else if (guess4 < randNo)
                            {
                                Console.WriteLine("Too Low!");
                            }

                            Console.WriteLine("Write guess no.5: ");
                            int guess5 = Convert.ToInt32(Console.ReadLine());

                            if (guess5 == randNo)
                            {
                                Console.WriteLine("CORRECT!");
                            }
                            else
                            {
                                if (guess5 > 20 || guess5 < 1)
                                {
                                    Console.WriteLine("Incorrect number!");
                                }
                                else if (guess5 > randNo)
                                {
                                    Console.WriteLine("Too High!");
                                }
                                else if (guess5 < randNo)
                                {
                                    Console.WriteLine("Too Low!");
                                }

                                Console.WriteLine("Write guess no.6: ");
                                int guess6 = Convert.ToInt32(Console.ReadLine());

                                if (guess6 == randNo)
                                {
                                    Console.WriteLine("CORRECT!");
                                }
                                else
                                {
                                    Console.WriteLine($"WRONG! Correct answer was: {randNo}");
                                }
                            }
                        }
                    }
                }
            }


            // UŽDUOTIS 06

            Console.WriteLine("Parašykite skaičių no.1: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Parašykite skaičių no.2: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Parašykite matematinę operaciją (+,-,*,/): ");
            var operacija = Console.ReadLine();

            Console.WriteLine("");

            if      (operacija == "+") Console.WriteLine($"{skaicius1} {operacija} {skaicius2} = {skaicius1 + skaicius2}");
            else if (operacija == "-") Console.WriteLine($"{skaicius1} {operacija} {skaicius2} = {skaicius1 - skaicius2}");
            else if (operacija == "*") Console.WriteLine($"{skaicius1} {operacija} {skaicius2} = {skaicius1 * skaicius2}");
            else if (operacija == "/") Console.WriteLine($"{skaicius1} {operacija} {skaicius2} = {(double)skaicius1 / skaicius2}");
            else Console.WriteLine($"ERROR!");

            Console.WriteLine("");

            switch (operacija)
            {
                case "+":
                    Console.WriteLine($"{skaicius1} {operacija} {skaicius2} = {skaicius1 + skaicius2}");
                    break;
                case "-":
                    Console.WriteLine($"{skaicius1} {operacija} {skaicius2} = {skaicius1 - skaicius2}");
                    break;
                case "*":
                    Console.WriteLine($"{skaicius1} {operacija} {skaicius2} = {skaicius1 * skaicius2}");
                    break;
                case "/":
                    Console.WriteLine($"{skaicius1} {operacija} {skaicius2} = {(double)skaicius1 / skaicius2}");
                    break;
                default:
                    Console.WriteLine("ERROR!");
                    break;
            }


            // UŽDUOTIS 07

            Console.WriteLine("Three friends.");

            Console.WriteLine("\nName of friend no.1: ");
            string friendName1 = Console.ReadLine();
            Console.WriteLine("Age of friend no.1: ");
            int friendAge1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nName of friend no.2: ");
            string friendName2 = Console.ReadLine();
            Console.WriteLine("Age of friend no.2: ");
            int friendAge2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nName of friend no.3: ");
            string friendName3 = Console.ReadLine();
            Console.WriteLine("Age of friend no.3: ");
            int friendAge3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("");

            Console.WriteLine($"Friend no. 1: {friendName1}, age {friendAge1}");
            Console.WriteLine($"Friend no. 2: {friendName2}, age {friendAge2}");
            Console.WriteLine($"Friend no. 3: {friendName3}, age {friendAge3}");

            Console.WriteLine($"\nAverage age is: {(friendAge1 + friendAge2 + friendAge3) / 3}");


            Console.Write($"Youngest friend is: ");

            if (friendAge1 < friendAge2 && friendAge1 < friendAge3)
            {
                Console.WriteLine(friendName1);
            }
            else if (friendAge2 < friendAge1 && friendAge1 < friendAge3)
            {
                Console.WriteLine(friendName2);
            }
            else Console.WriteLine(friendName3);


            Console.Write($"Eldest friend is: ");

            if (friendAge1 > friendAge2 && friendAge1 > friendAge3)
            {
                Console.WriteLine(friendName1);
            }
            else if (friendAge2 > friendAge1 && friendAge2 > friendAge3)
            {
                Console.WriteLine(friendName2);
            }
            else Console.WriteLine(friendName3);

            Console.WriteLine("\n\n");
            
            */


            // UŽDUOTIS 08

            Console.WriteLine("Christmas cookies!");

            Console.WriteLine("Date no.1 (yyyy-mm-dd): ");
            DateTime date01 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Date no.2 (yyyy-mm-dd): ");
            DateTime date02 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Date no.3 (yyyy-mm-dd): ");
            DateTime date03 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Date no.4 (yyyy-mm-dd): ");
            DateTime date04 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"\nInputs: \n{date01.ToString("yyyy-MM-dd")} \n{date02.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"{date03.ToString("yyyy-MM-dd")} \n{date04.ToString("yyyy-MM-dd")}");


            /* 
            
            // 22-06-2022

            Console.WriteLine("String manipulations");

            char[] letters = { 'H', 'e', 'l', 'l', 'o' }; // array /masyvas
            string greetings = new string(letters);       // string constructor

            DateTime greetDay = DateTime.Today;
            var greetingDate = $"{greetings}, date: {greetDay.ToString("yyyy-MM-dd")}";

            Console.WriteLine(greetingDate);

            */


        }
    }
}