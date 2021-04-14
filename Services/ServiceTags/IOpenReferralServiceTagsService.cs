using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenReferralPOV.Data.Enums;
using OpenReferralPOV.Data;

namespace OpenReferralPOV.Services.ServiceTags
{
    public interface IOpenReferralServiceTagsService
    {
        Task<Data.ServiceTags> Update(Data.ServiceTags serviceTags);

        Task<Data.ServiceTags> Get(string serviceId);
    }
}
