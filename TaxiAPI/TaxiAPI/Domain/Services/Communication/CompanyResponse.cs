using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxiAPI.Domain.Models;

namespace TaxiAPI.Domain.Services.Communication
{
    public class CompanyResponse : BaseResponse
    {
        public Company Company { get; private set; }

        private CompanyResponse(bool success, string message, Company company) : base(success, message)
        {
            Company = company;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="company">Saved company.</param>
        /// <returns>Response.</returns>
        public CompanyResponse(Company company) : this(true, string.Empty, company)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public CompanyResponse(string message) : this(false, message, null)
        { }
    }
}
