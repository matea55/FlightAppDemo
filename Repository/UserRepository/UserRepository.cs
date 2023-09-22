using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private FlightAppContext _context { get; set; }

        public UserRepository(FlightAppContext context)
        {
           this._context = context;
        }
        public void DeleteUser(int userId)
        {
            User user = _context.Users.Find(userId);
            _context.Users.Remove(user);
        }

        public User GetUserByID(int userId)
        {
            return _context.Users.Find(userId);
        }

        public User GetUserByUsername(string username)
        {
            return (User)_context.Users.Where(x=>x.Username.Equals(username)).FirstOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public void InsertUser(User user)
        {
            _context.Users.Add(user);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }
    }
}
