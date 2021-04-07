using OpenReferralPOV.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Services
{
    public interface IOpenReferralOrganisationService
    {
        Task<Organization> AddOrganization(Organization organization);
        Task<IEnumerable<Organization>> GetAllOrganisations();

        Task RequestToJoinOrganisationAsMember(string orgId);

        Task RequestToJoinOrganisationAsAdmin(string orgId);
    }
}
