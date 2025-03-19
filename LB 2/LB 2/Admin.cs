namespace LB_2
{
    internal class Admin:User
    {
        public Admin(string email, string username, string password) : base(email, username, password) 
        {
            
        }
        public void BlockUser(User user)
        {
            Console.WriteLine($"{UserName} : Blocked");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Роль: Адміністратор");
        }
    }
}
