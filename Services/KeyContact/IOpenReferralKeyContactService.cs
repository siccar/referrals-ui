using OpenReferralPOV.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Services
{
    public interface IOpenReferralKeyContactService
    {
        Task<KeyContact> AddKeyContact(KeyContact contact);
        Task<IEnumerable<KeyContact>> GetAllKeyContacts();

        Task<IEnumerable<KeyContact>> GetPendingAdminRequests();


        Task HandleAdminGrantRequest(string orgId, string userId);

        Task<IEnumerable<KeyContact>> GetOrgsICanManage();

        Task<IEnumerable<KeyContact>> GetKeyContactsForOrg(string orgId);
    }
}