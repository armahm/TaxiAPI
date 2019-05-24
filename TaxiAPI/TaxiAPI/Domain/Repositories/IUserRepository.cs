using System.Threading.Tasks;
using TaxiAPI.Domain.Models;

namespace TaxiAPI.Domain.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user, ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}
