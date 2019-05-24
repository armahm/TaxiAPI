using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiAPI.Domain.Models;

namespace TaxiAPI.Domain.Repositories
{
    public interface ICompanyRespository
    {
        Task<IEnumerable<Company>> ListAsync();
        Task AddAsync(Company company);
        Task<Company> FindByIdAsync(int id);
        void Update(Company company);
        void Remove(Company company);
    }
}
