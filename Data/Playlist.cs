namespace OpenReferralPOV.Data
{
    public class Playlist
    {
        public Playlist()
        {
            Services = new string[] { };
        }
        public string UserId { get; set; }
        public string[] Services { get; set; }
    }
}
