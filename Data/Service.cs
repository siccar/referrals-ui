using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Data
{
    public class Service
    {
        public Service()
        {
            Id = Guid.NewGuid().ToString();
            Regular_Schedules = new List<RegularSchedule>();
            Service_At_Locations = new List<ServiceAtLocation>();
            Contacts = new List<string>();

            Tags = new List<int>();
        }

        public string Description { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string OrganizationId { get; set; }
        public IEnumerable<RegularSchedule> Regular_Schedules { get; set; }
        public IEnumerable<ServiceAtLocation> Service_At_Locations { get; set; }
        public IEnumerable<string> Contacts { get; set; }
        public string Status { get; set; }
        public string Url { get; set; }

        public IEnumerable<int> Tags { get; set; }
        public int? Category { get; set; }
    }
}
