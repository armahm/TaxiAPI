using System.ComponentModel.DataAnnotations;

namespace TaxiAPI.Resources
{
    public class SaveCompanyResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
