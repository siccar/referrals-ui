using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Data
{
    public class Location
    {
        public Location()
        {
            Id = Guid.NewGuid().ToString();
            Physical_Addresses = new List<PhysicalAddress>();
        }
        public string Id { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public IEnumerable<PhysicalAddress> Physical_Addresses { get; set; }
    }
}
