<<<<<<< HEAD
﻿namespace OpenReferralPOV.Data
=======
﻿using System.Collections.Generic;

namespace OpenReferralPOV.Data
>>>>>>> master
{
    public class Playlist
    {
        public Playlist()
        {
<<<<<<< HEAD
            Services = new string[] { };
        }
        public string UserId { get; set; }
        public string[] Services { get; set; }
=======
            Services = new List<string>();
        }
        public string Id { get; set; }
        public List<string> Services { get; set; }
>>>>>>> master
    }
}
