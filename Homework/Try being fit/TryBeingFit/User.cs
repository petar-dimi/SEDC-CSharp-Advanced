using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBeingFit
{
    public class User
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Username { get; }
        public string Password { get; }

        public User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }
    }
}
