using System.Collections.Generic;
using System.Threading.Tasks;
using TaxiAPI.Domain.Models;

namespace TaxiAPI.Domain.Services
{
    public interface IVehicleService
    {
        Task<IEnumerable<Vehicle>> ListAsync();
    }
}
