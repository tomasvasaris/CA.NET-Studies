using System.Text;

namespace BM016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            StringBuilder sb0 = new StringBuilder();            // no text
            StringBuilder sb1 = new StringBuilder("'ello");     // with text

            sb0.Append("Labas");
            sb0.Append(", pasauli");
            sb0.AppendLine();
            sb0.AppendLine("What's up?");

            Console.WriteLine(sb0.ToString());

            sb0.Insert(6, " nuostabus");
            Console.WriteLine(sb0.ToString());

            sb0.Remove(7, 3);
            Console.WriteLine(sb0.ToString());
            */

            Console.WriteLine(NumberTriangle());

        }

        static string NumberTriangle()
        {
            StringBuilder output = new StringBuilder();
            int input = IntAsk();
            Console.WriteLine();

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    output.Append(i+1);
                }
                output.AppendLine();
            }

            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < input-i; j++)
                {
                    output.Append(input-i);
                }
                output.AppendLine();
            }

            return output.ToString();
        }



        static int IntAsk()
        {
            Console.WriteLine("Please write an int number: ");
            string? input = Console.ReadLine();

            for (;;)
            {
                if (Int32.TryParse(input, out _) == false)
                {
                    Console.WriteLine("That is not an int, try again");
                    input = Console.ReadLine();
                }
                else
                {
                    return Convert.ToInt32(input);
                }
            }
        }
    }
}