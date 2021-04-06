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
        Task<IEnumerable<KeyContact>> GetAsync();
    }
}
