using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Data
{
    public class ServiceTags
    {
        public ServiceTags()
        {
            Tags = new List<int>();
        }
        public string ServiceId { get; set; }
        public List<int> Tags { get; set; }
    }
}
