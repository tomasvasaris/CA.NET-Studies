namespace BasicMokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("išvedimas ");
            Console.Write("vienoje ");
            Console.Write("eilutėje.");
            Console.WriteLine("\nNauja eilutė");

            Console.WriteLine("----------------------------");
            Console.WriteLine("Išvedimas " + "vienoje " + "eilutėje.");             // concatenation
            Console.WriteLine("{0} {1} {2}", "Išvedimas", "vienoje", "eilutėje.");  // composition
            Console.WriteLine($"{"Išvedimas"} {"vienoje"} {"eilutėje."}");          // interpolation

            Console.WriteLine("----------------------------");


            Console.ReadKey();
        }
    }
}