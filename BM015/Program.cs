namespace BM015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //BreakSkip();
            ForNesting();
        }

        static void ForLoop()
        {
            for (int i = 0; i < 10; i++) // double tab to create template automagically
            {
                Console.WriteLine(i);
            }
        }

        static void BreakSkip()
        {
            for (int i = 0; i < 10; i++)
            {
                int skaicius = 5;
                if (i == skaicius)
                {
                    Console.WriteLine("skipio");
                    continue; // will skip everything below and jump back to top
                }

                if (i == 8)
                {
                    break; // will stop once i becomes 8
                }

                Console.WriteLine(i);
            }
        }

        static void ForNesting()
        {
            for (int i = 0; i < 10; i++) // double tab to create template automagically
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static int ForSubstring(string dnr, string element)
        {
            var count = 0;

            for (int i = 0; i < dnr.Length; i+=4)
            {
                if (dnr.Substring(i, 3) == element)
                {
                    count++;
                }
            }

            return count;
        }
    }
}