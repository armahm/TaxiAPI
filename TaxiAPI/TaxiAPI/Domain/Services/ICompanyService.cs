using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiAPI.Domain.Models;
using TaxiAPI.Domain.Services.Communication;

namespace TaxiAPI.Domain.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> ListAsync();
        Task<CompanyResponse> SaveAsync(Company company);
        Task<CompanyResponse> UpdateAsync(int id, Company company);
        Task<CompanyResponse> DeleteAsync(int id);
    }
}
