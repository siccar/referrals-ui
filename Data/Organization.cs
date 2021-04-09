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
            JoinAsMemberButtonDisabled = false;
            RequestToJoinStatusMessage = "Request to join";
            RequestToAdminister = "Request to Administer";
        }
        public string Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int CharityNumber { get; set; }
        public IEnumerable<string> ServicesIds { get; set; }
        public string Url { get; set; }


        // Fields added to aid rendering
        public string RequestToJoinStatusMessage { get; set; }
        public string RequestToAdminister { get; set; }

        public bool JoinAsMemberButtonDisabled { get; set; }

        public bool JoinAsAdminButtonDisabled { get; set; }
    }
}
