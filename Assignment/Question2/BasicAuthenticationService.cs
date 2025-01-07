using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly Dictionary<string, string> storedCredentials;
        private readonly Dictionary<string, List<string>> userRoles;

        public BasicAuthenticationService()
        {
            // Initialize the stored credentials and user roles  
            storedCredentials = new Dictionary<string, string>
        {
            { "admin", "password" },
            { "user", "userpassword" }
        };

            userRoles = new Dictionary<string, List<string>>
        {
            { "admin", new List<string> { "admin", "user" } },
            { "user", new List<string> { "user" } }
        };
        }

        public bool AuthenticateUser(string username, string password)
        {
            if (storedCredentials.TryGetValue(username, out var storedPassword))
            {
                return storedPassword == password;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (userRoles.TryGetValue(username, out var roles))
            {
                return roles.Contains(role);
            }
            return false;
        }
    }
}
