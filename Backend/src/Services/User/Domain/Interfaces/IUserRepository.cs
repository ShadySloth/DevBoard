namespace User.Domain.Interfaces;

public interface IUserRepository
{
    Task<Entities.User> GetUserByIdAsync(Guid userId);
    Task<Entities.User> GetUserByEmailAsync(string email);
    Task<Entities.User> GetUserByUsernameAsync(string username);
    Task<Entities.User> CreateUserAsync(Entities.User user);
    Task<Entities.User> UpdateUserAsync(Entities.User user);
    Task DeleteUserAsync(Guid userId);
}