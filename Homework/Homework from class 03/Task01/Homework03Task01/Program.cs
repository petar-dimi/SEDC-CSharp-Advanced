namespace Homework03Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            UserDatabase.DisplayAllUsers();

           
            int searchId = 1;
            User userById = UserDatabase.SearchById(searchId);
            Console.WriteLine($"\nSearch by Id {searchId}: {(userById != null ? userById.Name : "Not Found")}");

           
            string searchName = "Bobski";
            List<User> usersByName = UserDatabase.SearchByName(searchName);
            Console.WriteLine($"\nSearch by Name '{searchName}': {usersByName.Count} user(s) found.");
            foreach (var user in usersByName)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
            }

           
            int searchAge = 30;
            List<User> usersByAge = UserDatabase.SearchByAge(searchAge);
            Console.WriteLine($"\nSearch by Age {searchAge}: {usersByAge.Count} user(s) found.");
            foreach (var user in usersByAge)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
            }
        }
    }
}
