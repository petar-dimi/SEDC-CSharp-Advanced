namespace Homework04Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInConsole printer = new PrintInConsole();

            
            printer.Print("Hello, SEDC");
            printer.Print(1337);
            printer.Print(45.67);

            
            List<string> names = new List<string> { "Petar", "Slave", "Risto" };
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("\nPrinting names:");
            printer.PrintCollection(names);

            Console.WriteLine("\nPrinting numbers:");
            printer.PrintCollection(numbers);
        }
    }
}
