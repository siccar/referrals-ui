using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [RegularExpression(@"(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX]][0-9][A-HJKSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) [0-9][A-Z-[CIKMOV]]{2})",
 ErrorMessage = "The Postcode must be a valid UK Postcode.")]
        public string Postcode { get; set; }
        public double Proximity { get; set; }

        public List<string> Categories { get; set; }

        public string SelectedCategory { get; set; }

        public bool SearchForOrgansation { get; set; }
    }
}
