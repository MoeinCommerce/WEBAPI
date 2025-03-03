using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class WebShippingDetail
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public double VehiclePrice { get; set; }
        public string VehicleDescription { get; set;}
    }
}
