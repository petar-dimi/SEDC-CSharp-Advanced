using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBeingFit
{
    public class App
    {
        private List<User> users = new List<User>();
        private List<Trainer> trainers = new List<Trainer>();
        private User currentUser = null;

        public void Run()
        {
            SeedData(); // Pre-load some trainers for demonstration purposes
            while (true)
            {
                Console.WriteLine("Welcome to TryBeingFit App!");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("3. Exit");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Login();
                        break;
                    case "2":
                        Register();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void SeedData()
        {
            trainers.Add(new Trainer("John", "Doe"));
            trainers.Add(new Trainer("Jane", "Smith"));
        }

        private void Login()
        {
            Console.Write("Enter username: ");
            var username = Console.ReadLine();

            Console.Write("Enter password: ");
            var password = Console.ReadLine();

            currentUser = users.Find(u => u.Username == username && u.Password == password);

            if (currentUser != null)
            {
                Console.WriteLine($"Welcome {currentUser.FirstName}!");
                ShowUserMenu(currentUser);
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }

        private void Register()
        {
            Console.Write("Enter first name: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            var lastName = Console.ReadLine();
            Console.Write("Enter username (at least 6 characters): ");
            var username = Console.ReadLine();
            Console.Write("Enter password (at least 6 characters with 1 number): ");
            var password = Console.ReadLine();

            if (!ValidateUserDetails(firstName, lastName, username, password))
                return;

            var newUser = new User(firstName, lastName, username, password);
            users.Add(newUser);
            Console.WriteLine("Registration successful! You can now login.");
        }

        private void ShowUserMenu(User user)
        {
            if (user is PremiumUser)
                ShowPremiumMenu((PremiumUser)user);
            else
                ShowStandardMenu(user);
        }

        private void ShowStandardMenu(User user)
        {
            while (true)
            {
                Console.WriteLine("\n--- Standard User Menu ---");
                Console.WriteLine("1. Train");
                Console.WriteLine("2. Upgrade to Premium");
                Console.WriteLine("3. Account");
                Console.WriteLine("4. Log Out");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Train(user);
                        break;
                    case "2":
                        UpgradeToPremium(user);
                        return;
                    case "3":
                        ShowAccountInfo(user);
                        break;
                    case "4":
                        currentUser = null;
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void ShowPremiumMenu(PremiumUser user)
        {
            while (true)
            {
                Console.WriteLine("\n--- Premium User Menu ---");
                Console.WriteLine("1. Train");
                Console.WriteLine("2. Account");
                Console.WriteLine("3. Log Out");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Train(user);
                        break;
                    case "2":
                        ShowAccountInfo(user);
                        break;
                    case "3":
                        currentUser = null;
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private void Train(User user)
        {
            Console.WriteLine("Training session started!");
            // Add logic for live or video training
        }

        private void UpgradeToPremium(User user)
        {
            if (user is PremiumUser)
            {
                Console.WriteLine("You are already a Premium user.");
                return;
            }

            var premiumUser = new PremiumUser(user.FirstName, user.LastName, user.Username, user.Password);
            users.Remove(user);
            users.Add(premiumUser);
            Console.WriteLine("Upgrade to Premium successful!");
        }

        private void ShowAccountInfo(User user)
        {
            Console.WriteLine($"Account Info:\nName: {user.FirstName} {user.LastName}\nUsername: {user.Username}");
        }

        private bool ValidateUserDetails(string firstName, string lastName, string username, string password)
        {
            if (firstName.Length < 2 || lastName.Length < 2)
            {
                Console.WriteLine("First name and last name must be at least 2 characters long.");
                return false;
            }
            if (username.Length < 6)
            {
                Console.WriteLine("Username must be at least 6 characters long.");
                return false;
            }
            if (password.Length < 6 || !HasNumber(password))
            {
                Console.WriteLine("Password must be at least 6 characters long and contain at least 1 number.");
                return false;
            }
            return true;
        }

        private bool HasNumber(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }
     }
    }
