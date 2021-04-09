using OpenReferralPOV.Data;
using OpenReferralPOV.Data.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenReferralPOV.Services
{
    public interface IOpenReferralService
    {
        Task<Location> AddLocation(Location location);        
        Task<Service> AddService(Service service);
        Task<IEnumerable<Service>> GetServicesAsync();

        Task<Service> GetServiceById(string id);

        Task<IEnumerable<TagEnum>> GetServiceTagsAsync(string serviceId);
        Task<Service> UpdateService(Service service);
    }
}