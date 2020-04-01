using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestUser();
            Console.ReadKey();
        }
        static void TestUser()
        {
            using (Model1Container context = new Model1Container())
            {
                User p = new User()
                {
                    ID = 212312312,
                    FirstName = "Julie",
                    LastName = "Andrew",
                    Email = "julieandrew@yahoo.com",
                    Password = "hahaha1234",
                    Phone = "1234567890",
                    Address = "Str Moara de Foc, Nr 1, Iasi"
                };
                context.Users.Add(p);
                context.SaveChanges();
                var items = context.Users;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.ID, x.FirstName);
            }
        }

    }
}
