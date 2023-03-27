namespace Domain.Entities
{
    public class Admin : IBaseEntity
    {
        public Admin() { }
        public Admin(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}