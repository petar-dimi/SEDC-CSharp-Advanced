using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBeingFit
{
    public class PremiumUser : User
    {
        public PremiumUser(string firstName, string lastName, string username, string password)
            : base(firstName, lastName, username, password) { }
    }
}
