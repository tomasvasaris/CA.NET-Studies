namespace BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World!");
            Console.WriteLine("");

            Console.Write("Išvedimas ");
            Console.Write("vienoje ");
            Console.Write("eilutėje.");
            Console.WriteLine("\nNauja eilutė");

            Console.WriteLine("---------------------------");
            Console.WriteLine("Išvedimas " + "vienoje " + "eilutėje.");             // concatenation
            Console.WriteLine("{0} {1} {2}", "Išvedimas", "vienoje", "eilutėje.");  // composition
            Console.WriteLine($"{"Išvedimas"} {"vienoje"} {"eilutėje."}");          // interpolation

            Console.WriteLine("---------------------------");
            Console.WriteLine("Text in \"brackets\"");
            Console.WriteLine("Text in \"br\u00C6ckets\"");
            Console.WriteLine("Text \tin \t\"brackets\"");

            Console.ReadKey();
            Console.Clear();

            Console.Write("Write something: ");
            //Console.WriteLine("Here you go: " + Console.ReadLine());
            //Console.WriteLine("Here you go: {0}", Console.ReadLine());
            //Console.WriteLine($"Here you go: {Console.ReadLine()}");

            Console.Write("Write a character: ");
            var key = Console.ReadKey();
            Console.WriteLine("\nYou wrote \"{0}\"", key.KeyChar);
            */

            Console.WriteLine("Write something.");
            Console.WriteLine("First letter: \"{0}\"", Console.ReadLine()[0]);

        }
    }
}