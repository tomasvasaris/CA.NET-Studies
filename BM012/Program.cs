namespace BM012
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string Mokausi(string text) // Užduotis 11
        {
            string mokausi = text.ToLower().Contains("mokausi") ? "Taip" : "Ne";
            return mokausi;
        }

        public static string MokausiDar(string text) // Užduotis 11A
        {
            text = " " + text + " ";
            string mokausi = text.ToLower().Contains(" mokausi ") ? "Taip" : "Ne";
            return mokausi;
        }

        public static int ARaide(string text) // Užduotis 12
        {
            int mokausi = text.IndexOf("a")+1;
            return mokausi;
        }

    }
}