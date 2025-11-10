using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class WebShippingDetail
    {
        public long Id { get; set; }
        public long VehicleId { get; set; }
        public string VehicleName { get; set; }
        public double VehiclePrice { get; set; }
        public string VehicleDescription { get; set;}
    }
}
