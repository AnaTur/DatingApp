namespace DatingApp.API.Models
{
    public class User
    {
        public User(string userName)
        {
            UserName = userName;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}