public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; } // Consider hashing in production
    public string Email { get; set; }
}
