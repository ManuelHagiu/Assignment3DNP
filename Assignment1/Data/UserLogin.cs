
using Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileData;


namespace Assignment1.Data
{
    public class UserLogin : IUserLogin 
    {
        public async Task<User> ValidateUser(string username)
        {
            FileContext fileContext = new FileContext();
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
}