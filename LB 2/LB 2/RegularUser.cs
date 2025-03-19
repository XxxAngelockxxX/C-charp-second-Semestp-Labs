using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LB_2
{
    internal class RegularUser : User
    {
        public RegularUser(string email, string username, string password) : base(email, username, password)
        {

        }
        public void PostComment()
        {
            Console.WriteLine("Коментар опубліковано.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Роль: Звичайний користувач");
        }
    }
}
