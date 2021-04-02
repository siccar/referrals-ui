using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Identity
{
    public interface IIdentityService
    {
        bool IsUserAuthenticated();
    }
}
