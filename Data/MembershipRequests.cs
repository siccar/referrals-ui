using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Data
{
    public class MembershipRequests
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string OrgId { get; set; }

        public MembershipRequestsStatus Status { get; set; }
    }
}
