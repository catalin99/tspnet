using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    public partial class User
    {
        public bool DeleteUser(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var user = ctx.Users.FirstOrDefault(u => u.ID == id);
                if (user != default(User))
                {
                    ctx.Users.Remove(user);
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public User GetUserById(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var user = ctx.Users.FirstOrDefault(u => u.ID == id);
                if (user != default(User))
                    return user;
                return null;
            }
        }

        public List<User> GetAllUsers()
        {
            using (Model1Container ctx = new Model1Container())
            {
                var userList = ctx.Users.ToList();
                return userList;
            }
        }

        public User Update(int id, string firstName, string lastName, string email, string password, string phone, string address)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var user = ctx.Users.FirstOrDefault(u => u.ID == id);
                user.FirstName = firstName;
                user.LastName = lastName;
                user.Email = email;
                user.Password = password;
                user.Phone = phone;
                user.Address = address;
                ctx.SaveChanges();
                return user;
            }
        }
        public User CreateUser(string firstName, string lastName, string email, string password, string phone, string address)
        {
            using (Model1Container ctx = new Model1Container())
            {
                User user = new User()
                {
                    ID = new Random().Next(1,20000),
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Password = password,
                    Phone = phone,
                    Address = address,
                };
                ctx.Users.Add(user);
                ctx.SaveChanges();
                return user;
            }
        }

        public bool Login(string email, string password)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var user = ctx.Users.FirstOrDefault(u => u.Email == email);
                if (user != default(User))
                {
                    if (user.Password == password)
                        return true;
                }
                return false;
            }
        }

    }
}
