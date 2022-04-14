using ApplicationCore.Contracts.Repositories;
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
        private readonly IUserRepository _userRepository;

        public AccountService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> RegisterUser(RegisterModel model)
        {
            // need to go to user table and get the user record by email
            // check if the email user entered does not exists in the database

            var user = await _userRepository.GetUserByEmail(model.Email);
            if (user != null)
            {
                // 
                throw new Exception("Duplicate Email, please login");
            }


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
