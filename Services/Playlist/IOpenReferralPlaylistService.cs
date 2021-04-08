using OpenReferralPOV.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenReferralPOV.Services
{
    public interface IOpenReferralPlaylistService
    {
        Task<Playlist> Update(Playlist playlist);

        Task<Playlist> Get();
    }
}
