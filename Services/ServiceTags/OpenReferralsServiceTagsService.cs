using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OpenReferralPOV.Data;
using OpenReferralPOV.Services.HttpClientAdapter;

namespace OpenReferralPOV.Services.ServiceTags
{
    public class OpenReferralsServiceTagsService : IOpenReferralServiceTagsService
    {
        private IHttpClientAdapter _httpClientAdapter;
        private readonly string _ApiBaseAddress = string.Empty;

        public OpenReferralsServiceTagsService(IHttpClientAdapter httpClientAdapter, IConfiguration configuration)
        {
            _httpClientAdapter = httpClientAdapter;
            _ApiBaseAddress = configuration["ORApi:BaseUrl"];
        }
        public async Task<Data.ServiceTags> Get(string serviceId)
        {
            var responseString = await _httpClientAdapter.GetAsync(new Uri($"{ _ApiBaseAddress}/ServiceTags/{serviceId}"));
            var serviceTags = JsonConvert.DeserializeObject<Data.ServiceTags>(responseString);
            return serviceTags;
        }

        public async Task<Data.ServiceTags> Update(Data.ServiceTags serviceTags)
        {
            var responseString = await _httpClientAdapter.PostAsync(new Uri($"{ _ApiBaseAddress}/ServiceTags"), serviceTags);
            var serTags = JsonConvert.DeserializeObject<Data.ServiceTags>(responseString);
            return serTags;
        }
    }
}
