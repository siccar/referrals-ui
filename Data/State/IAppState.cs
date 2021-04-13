using System;
using System.Collections.Generic;

namespace OpenReferralPOV.Data.State
{
    public interface IAppState
    {
        Dictionary<string, string> SelectedOrgs { get; }

        event Action OnChange;

        void SetSelectedOrg(string userId, string org);
    }
}