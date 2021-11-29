/*using System;
using System.IO;
using System.Linq;
using AssignmentDNP2.Persistence;
using Models;

namespace AssignmentDNP2.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private ApiDbContext file = new ApiDbContext();

        public User validateUser(string username, string password)
        {
            User first = file.Users.FirstOrDefault(user => user.UserName.Equals(username));

            if (first == null)
            {
                throw new Exception("User not found");
            }
            
            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect Password");
            }

            return first;
        }
    }
}*/