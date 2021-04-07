namespace OpenReferralPOV.Data
{
    public class KeyContact
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string OrgId { get; set; }
        public string OrgName { get; set; }
        public string UserEmail { get; set; }

        public string IsAdmin { get; set; }

        public string IsPending { get; set; }
    }
}
