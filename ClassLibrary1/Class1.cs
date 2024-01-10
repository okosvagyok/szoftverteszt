namespace ClassLibrary1
{
    public class Class1
    {
        bool EvenOdd(int number)
        {
            Console.Write("Kérek egy számot: ");
            number = int.Parse(Console.ReadLine());
            if (number%2 == 0)
            {
                Console.WriteLine($"A megadott szám ({number}) páros.");
                return true;
            }
            else
            {
                Console.WriteLine($"A megadott szám ({number}) páratlan.");
                return false;
            }
        }
    }
}