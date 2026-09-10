using User.Domain.Entities;

namespace User.Domain.Interfaces;

public interface IUserCredentialRepository
{
    Task<UserCredential> GetUserCredentialByUserIdAsync(Guid userId);
    Task<UserCredential> CreateUserCredentialAsync(UserCredential userCredential);
    Task<UserCredential> UpdateUserCredentialAsync(UserCredential userCredential);
    Task DeleteUserCredentialAsync(Guid userId);
}