
/*
using Models;

using System.Threading.Tasks;
using AssignmentDNP2.Persistence;



namespace AssignmentDNP2.Data
{
    public class UserLogin : IUserLogin 
    {
        public async Task<User> ValidateUser(string username)
        {
            ApiDbContext fileContext = new ApiDbContext();
            {
                foreach (User user in fileContext.Users)
                {
                    if (user.UserName.Equals(username))
                    {
                        return user;
                    }
                }

                return null;

            }
        }
    }
}*/