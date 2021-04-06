using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Data
{
    public class Organization
    {
        public Organization()
        {
            RequestToJoinStatusMessage = "Request to join";
        }
        public string Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int CharityNumber { get; set; }
        public IEnumerable<string> ServicesIds { get; set; }
        public string Url { get; set; }

        public string RequestToJoinStatusMessage { get; set; }
    }
}
