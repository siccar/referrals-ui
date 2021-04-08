using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Web;
using Newtonsoft.Json;
using OpenReferralPOV.Data;
using OpenReferralPOV.Data.Enums;
using OpenReferralPOV.Services.HttpClientAdapter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace OpenReferralPOV.Services
{
    public class OpenReferralService : IOpenReferralService
    {
        private IHttpClientAdapter _httpClientAdapter;
        private readonly string _ApiBaseAddress = string.Empty;

        public OpenReferralService(IHttpClientAdapter httpClientAdapter, IConfiguration configuration)
        {
            _httpClientAdapter = httpClientAdapter;
            _ApiBaseAddress = configuration["ORApi:BaseUrl"];
        }

        public async Task<IEnumerable<Organization>> GetOrganizationsAsync()
        {
            var responseString = await _httpClientAdapter.GetAsync(new Uri($"{ _ApiBaseAddress}/Organizations"));
            var organizations = JsonConvert.DeserializeObject<IEnumerable<Organization>>(responseString);

            return organizations;
        }

        public async Task<Organization> AddOrganization(Organization organization)
        {
            var responseString = await _httpClientAdapter.PostAsync(new Uri($"{ _ApiBaseAddress}/Organizations"), organization);
            var addedOrganization = JsonConvert.DeserializeObject<Organization>(responseString);

            return addedOrganization;
        }

        public async Task<Service> AddService (Service service)
        {
            var responseString = await _httpClientAdapter.PostAsync(new Uri($"{ _ApiBaseAddress}/Services"), service);
            var addedService = JsonConvert.DeserializeObject<Service>(responseString);

            return addedService;
        }

        public async Task<IEnumerable<Service>> GetServicesAsync()
        {
            var responseString = await _httpClientAdapter.GetAsync(new Uri($"{ _ApiBaseAddress}/Services"));
            var services = JsonConvert.DeserializeObject<IEnumerable<Service>>(responseString);

            return services;
        }

        public async Task<IEnumerable<TagEnum>> GetServiceTagsAsync(string serviceId)
        {
            var responseString = await _httpClientAdapter.GetAsync(new Uri($"{ _ApiBaseAddress}/tags?serviceId={serviceId}"));
            var tags = JsonConvert.DeserializeObject<IEnumerable<TagEnum>>(responseString);

            return tags;
        }

        public async Task <Service> UpdateService(Service service)
        {
            var responseString = await _httpClientAdapter.PutAsync(new Uri($"{ _ApiBaseAddress}/Services"), service);
            var updatedService = JsonConvert.DeserializeObject<Service>(responseString);

            return updatedService;
        }

    }
}
