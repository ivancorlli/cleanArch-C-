namespace ApiWeb.src.user.domain
{
    public interface IUser
    {
        Guid Id { get; set; }
        string Email { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        bool EmailVerified { get; set; }
        string status { get; set; }

        string Name { get; set; } 
        string Surname { get; set; }
        string Birthday { get; set; }
        string Gender { get; set; }

    }
}
