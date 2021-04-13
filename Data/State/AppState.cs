using System;
using System.Collections.Generic;

namespace OpenReferralPOV.Data.State
{
    public class AppState : IAppState
    {
        public Dictionary<string, string> SelectedOrgs { get; private set; }

        public event Action OnChange;

        public AppState()
        {
            SelectedOrgs = new Dictionary<string, string>();
        }

        public void SetSelectedOrg(string userId, string org)
        {
            if (SelectedOrgs.ContainsKey(userId))
            {
                SelectedOrgs[userId] = org;
            }
            else
            {
                SelectedOrgs.Add(userId, org);
            }
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}

