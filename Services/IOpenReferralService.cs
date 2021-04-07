using OpenReferralPOV.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Services
{
    public interface IOpenReferralService
    {
        Task<Organization> AddOrganization(Organization organization);
        Task<IEnumerable<Organization>> GetOrganizationsAsync();
        Task<Service> AddService(Service service);
        Task<IEnumerable<Service>> GetServicesAsync();
    }
}
