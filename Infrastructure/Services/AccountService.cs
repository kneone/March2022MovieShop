using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        public Task<bool> RegisterUser(RegisterModel model)
        {
            // need to go to user table and get the user record by email
            // check if the email user entered does not exists in the database
            // if email does not exists then hash the password with salt and save the salt and hashed password in the database
            throw new NotImplementedException();
        }

        public Task<bool> ValidateUser(string email, string password)
        {
            // get the user record by email
            // check if user exists in the database, only if user exisst then compare the hashes 
            // if hashes are equal then correct password.
            throw new NotImplementedException();
        }
    }
}
