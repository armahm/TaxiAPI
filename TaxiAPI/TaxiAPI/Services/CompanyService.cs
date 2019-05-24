using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiAPI.Domain.Models;
using TaxiAPI.Domain.Repositories;
using TaxiAPI.Domain.Services;
using TaxiAPI.Domain.Services.Communication;

namespace TaxiAPI.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRespository _companyRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(ICompanyRespository companyRepository, IUnitOfWork unitOfWork)
        {
            _companyRepository = companyRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _companyRepository.ListAsync();
        }

        public async Task<CompanyResponse> SaveAsync(Company company)
        {
            try
            {
                await _companyRepository.AddAsync(company);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(company);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new CompanyResponse($"An error occurred when saving the company: {ex.Message}");
            }
        }

        public async Task<CompanyResponse> UpdateAsync(int id, Company company)
        {
            var existingCompany = await _companyRepository.FindByIdAsync(id);

            if (existingCompany == null)
                return new CompanyResponse("Company not found.");

            existingCompany.Name = company.Name;

            try
            {
                _companyRepository.Update(existingCompany);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(existingCompany);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new CompanyResponse($"An error occurred when updating the company: {ex.Message}");
            }
        }

        public async Task<CompanyResponse> DeleteAsync(int id)
        {
            var existingCompany = await _companyRepository.FindByIdAsync(id);

            if (existingCompany == null)
                return new CompanyResponse("Company not found.");

            try
            {
                _companyRepository.Remove(existingCompany);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(existingCompany);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new CompanyResponse($"An error occurred when deleting the company: {ex.Message}");
            }
        }
    }
}
