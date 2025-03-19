using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_2
{
    internal class User
    {
        //властивості
        public string UserName { get; set;}
        public string Email { get; set; }
        private string _password { get; set; }

        public User(string email , string username , string password) 
        { 
            UserName = username;
            Email = email;
            _password = password;
        }
        public void SetPassword(string email)
        {
            Console.WriteLine("ENTER OLD password");
            string? oldPassword = Console.ReadLine();
            if (Authenticate(email))
                return;
            string? newPassword= Console.ReadLine();
            _password = newPassword;
        }
        public bool Authenticate(string email)
        {
            string? inputPassword = Console.ReadLine();
            return email == Email && _password == inputPassword;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"UserName: {UserName}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
