using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiAPI.Domain.Models;

namespace TaxiAPI.Domain.Repositories
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> ListAsync();
    }
}
