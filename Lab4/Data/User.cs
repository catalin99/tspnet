using System;
using System.Collections.Generic;
using System.Text;

namespace ProjTspNet.Data
{
    public class User
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public User()
        {
            ID = Guid.NewGuid();
        }

        public static User CreateUser(string firstName, string lastName, string email, string password, string phone, string address)
        {
            return new User
            {
                ID = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                Phone = phone,
                Address = address
            };
        }
    }
}
