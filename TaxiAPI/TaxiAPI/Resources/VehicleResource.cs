using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiAPI.Resources
{
    public class VehicleResource
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public CompanyResource Company { get; set; }
    }
}
