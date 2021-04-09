using OpenReferralPOV.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Services
{
    public class OpenReferralMockServiceFilterService : IOpenReferralServiceFilterService
    {
        public async Task<ServiceFilter> GetSearchFIlter()
        {
            return new ServiceFilter()
            {
                Postcode = string.Empty,
                SelectedCategory = string.Empty,
                Categories = new List<string>
                {
                    "Category A",
                    "Category B",
                    "Category C",
                }
            };
        }
    }
}
