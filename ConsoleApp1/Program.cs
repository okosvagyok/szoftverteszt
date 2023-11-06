namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Szia, {nev}!");
            Console.Write("Nemed: ");
            string nem = Console.ReadLine();
            Console.WriteLine($"Ez esetben, kedves {nev}, te egy {nem} vagy.");
        }
    }
}