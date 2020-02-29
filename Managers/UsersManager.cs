using GenericController.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController.Managers
{
    public class UsersManager : Services.IUserService
    {
        /// <summary>
        /// only for test
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<List<User>> GetList(Models.Filter model)
        {
            return new List<User>
            {
                new User{
                    ID = 1,
                    Firstname = "SaeedSafaee",
                    Email = "test@gmail.com"
                },
                new User{
                    ID = 2,
                    Firstname = "al",
                    Email = "ali@gmail.com"
                },
                new User{
                    ID = 3,
                    Firstname = "test",
                    Email = "test@gmail.com"
                },

            };        
        }

        /// <summary>
        /// only for test
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<User> GetItem(int ID)
        {
            return new User
            {
                ID = 1,
                Firstname = "SaeedSafaee",
                Email = "test@gmail.com"
            };
        }

        public Task<User> EditItem(int ID)
        {
            throw new NotImplementedException();
        }

        public bool AddItem(User model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }       
    }
}
