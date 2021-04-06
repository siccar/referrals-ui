using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OpenReferralPOV.Data;
using OpenReferralPOV.Services.HttpClientAdapter;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenReferralPOV.Services
{
    public class OpenReferralKeyContactService : IOpenReferralKeyContactService
    {
        private IHttpClientAdapter _httpClientAdapter;
        private readonly string _ApiBaseAddress = string.Empty;

        public OpenReferralKeyContactService(IHttpClientAdapter httpClientAdapter, IConfiguration configuration)
        {
            _httpClientAdapter = httpClientAdapter;
            _ApiBaseAddress = configuration["ORApi:BaseUrl"];
        }

        public async Task<IEnumerable<KeyContact>> GetAsync()
        {
            var responseString = await _httpClientAdapter.GetAsync(new Uri($"{ _ApiBaseAddress}/KeyContact"));
            var keycontacts = JsonConvert.DeserializeObject<IEnumerable<KeyContact>>(responseString);

            return keycontacts;
        }

        public async Task<KeyContact> AddKeyContact(KeyContact keycontact)
        {
            var responseString = await _httpClientAdapter.PostAsync(new Uri($"{ _ApiBaseAddress}/KeyContacts"), keycontact);
            var addedKeyContact = JsonConvert.DeserializeObject<KeyContact>(responseString);
            return addedKeyContact;
        }

        public async Task<IEnumerable<KeyContact>> GetPendingAdminRequests()
        {
            var responseString = await _httpClientAdapter.GetAsync(new Uri($"{ _ApiBaseAddress}/KeyContact/admin/requests"));
            var keycontacts = JsonConvert.DeserializeObject<IEnumerable<KeyContact>>(responseString);

            return keycontacts;
        }

        public async Task HandleAdminGrantRequest(string orgId, string userId)
        {
            var responseString = await _httpClientAdapter.GetAsync(new Uri($"{ _ApiBaseAddress}/KeyContact/admin/confirm/{orgId}/{userId}"));
        }
    }
}
