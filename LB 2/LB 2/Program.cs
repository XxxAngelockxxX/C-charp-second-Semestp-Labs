namespace LB_2
{
    internal class Program
    {
        static void Main()
        {
            Admin admin = new Admin("admin1","hbvvhbv@gmail.com", "124578");
            Moderator moderator = new Moderator("moder1", "hbhbv@gmail.com", "546987");
            RegularUser regularUser = new RegularUser("user1", "vhbv@gmail.com", "123123");
            RegularUser regularUser1 = new RegularUser("user1", "vhbv@gmail.com", "123123");
            RegularUser regularUser2 = new RegularUser("user1", "vhbv@gmail.com", "123123");
            List<User> users = new List<User>();
            users.Add(admin);
            users.Add(moderator);
            users.Add(regularUser);
            users.Add(regularUser1);
            users.Add(regularUser2);
            foreach (User user in users)
            { 
                if (user.Authenticate(user.Email))
                {
                    user.DisplayInfo();
                }
                if(user is Admin admin1)
                {
                    admin1.BlockUser(regularUser1);
                }
                else if (user == moderator)
                {
                    moderator.ModerateContent();
                }
                else
                {
                    regularUser.PostComment();
                }
               
            }
        }
    }
}
