namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Manager manager = new Manager("Alice", 101, 80000, 15000);
            manager.DisplayInfo();

            
            Programmer programmer = new Programmer("Bob", 102, 50, 160);
            programmer.DisplayInfo();
        }
    }
}
