using System.Threading.Tasks;
using TaxiAPI.Domain.Models;
using TaxiAPI.Domain.Services.Communication;

namespace TaxiAPI.Domain.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateUserAsync(User user, params ERole[] userRoles);
        Task<User> FindByEmailAsync(string email);
    }
}