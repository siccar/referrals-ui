﻿using System.Collections.Generic;

namespace OpenReferralPOV.Data
{
    public class Playlist
    {
        public Playlist()
        {
            Services = new List<string>();
        }
        public string Id { get; set; }
        public List<string> Services { get; set; }
    }
}
