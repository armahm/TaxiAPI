using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiAPI.Domain.Models;
using TaxiAPI.Domain.Repositories;
using TaxiAPI.Domain.Services;

namespace TaxiAPI.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<IEnumerable<Vehicle>> ListAsync()
        {
            return await _vehicleRepository.ListAsync();
        }
    }
}
