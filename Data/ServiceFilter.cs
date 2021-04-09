using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Data
{
    public class ServiceFilter
    {
        public ServiceFilter()
        {
            Categories = new List<string>();
        }
        public string Postcode { get; set; }

        public List<string> Categories { get; set; }

        public string SelectedCategory { get; set; }

        public bool SearchForOrgansation { get; set; }
    }
}
