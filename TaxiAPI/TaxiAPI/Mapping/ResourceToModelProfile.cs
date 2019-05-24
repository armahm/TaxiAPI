using AutoMapper;
using TaxiAPI.Controllers.Resources;
using TaxiAPI.Domain.Models;
using TaxiAPI.Resources;

namespace TaxiAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCompanyResource, Company>();
            CreateMap<UserCredentialsResource, User>();
        }
    }
}
