using System.Text.Json.Serialization;

namespace LFGWebApp 
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }  
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public string Bio { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt {get; set;}
        public DateTime LastUpdated { get; set; }
    }
}