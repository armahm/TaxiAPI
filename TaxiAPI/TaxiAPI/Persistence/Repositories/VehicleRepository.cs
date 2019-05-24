using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiAPI.Domain.Models;
using TaxiAPI.Domain.Repositories;
using TaxiAPI.Persistence.Contexts;

namespace TaxiAPI.Persistence.Repositories
{
    public class VehicleRepository : BaseRepository, IVehicleRepository
    {
        public VehicleRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Vehicle>> ListAsync()
        {
            return await _context.Vehicles.Include(p => p.Company)
                                          .ToListAsync();
        }
    }
}
