using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03Task01
{
    public class UserDatabase
    {
        private static List<User> users = new List<User>();

        
        static UserDatabase()
        {
            users.Add(new User(1, "Risto", 30));
            users.Add(new User(2, "Slave", 25));
            users.Add(new User(3, "Bob", 35));
            users.Add(new User(4, "Bobski", 30));
        }

      
        public static User SearchById(int id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }

        
        public static List<User> SearchByName(string name)
        {
            return users.Where(user => user.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        
        public static List<User> SearchByAge(int age)
        {
            return users.Where(user => user.Age == age).ToList();
        }

        
        public static void DisplayAllUsers()
        {
            Console.WriteLine("User List:");
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
            }
        }
    }
}
