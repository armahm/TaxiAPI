using System.ComponentModel.DataAnnotations;

namespace TaxiAPI.Controllers.Resources
{
    public class RevokeTokenResource
    {
        [Required]
        public string Token { get; set; }
    }
}