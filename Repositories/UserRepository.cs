using ApiAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiAuth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new () {Id = 1, Username = "batman", Password = "batman123", Role = "manager"},
                new () {Id = 2, Username = "robin", Password = "robin123", Role = "employee"}
            };

            return users.FirstOrDefault(x => string.Equals(x.Username, username, StringComparison.CurrentCultureIgnoreCase)
            && x.Password == password);

        }
        
    }
}
