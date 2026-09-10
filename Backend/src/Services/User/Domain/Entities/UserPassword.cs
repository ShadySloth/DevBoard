namespace User.Domain.Entities;

public class UserPassword
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string PasswordHash { get; set; }
}