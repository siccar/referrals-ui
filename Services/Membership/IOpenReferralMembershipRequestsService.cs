using OpenReferralPOV.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Services
{
    public interface IOpenReferralMembershipRequestsService
    {
        Task<IEnumerable<MembershipRequests>> GetAsync();
        Task<IEnumerable<MembershipRequests>> GetOrgJoinRequests();

        Task HandleDenyRequest(MembershipRequests requests);


        Task HandleGrantRequest(MembershipRequests requests);
    }
}
