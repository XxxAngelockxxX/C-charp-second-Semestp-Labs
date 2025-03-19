using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_2
{
    internal class Moderator:User
    {
        public Moderator(string email, string username, string password):base(email, username, password)
        {
            
        }
        public void ModerateContent()
        {
            Console.WriteLine("Контент модеровано.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Роль: Модератор");
        }
    }
}
