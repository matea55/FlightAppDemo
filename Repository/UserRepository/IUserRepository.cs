using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserRepository
{
    public interface IUserRepository
    {

            IEnumerable<User> GetUsers();
            User GetUserByID(int userId);
        User GetUserByUsername(string username);
        void InsertUser(User user);
            void DeleteUser(int userId);
            void UpdateUser(User user);
            void Save();
    }
}
