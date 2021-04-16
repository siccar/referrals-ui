using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Data
{
    public class ValidationError : Exception
    {
        public string Title;
        public int Status;
        public JObject Errors;
    }
}
