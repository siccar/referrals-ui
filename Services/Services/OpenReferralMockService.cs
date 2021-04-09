using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Web;
using Newtonsoft.Json;
using OpenReferralPOV.Data;
using OpenReferralPOV.Data.Enums;
using OpenReferralPOV.Services.HttpClientAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OpenReferralPOV.Services
{
    public class OpenReferralMockService : IOpenReferralService
    {
        private IHttpClientAdapter _httpClientAdapter;
        private readonly string _ApiBaseAddress = string.Empty;

        public OpenReferralMockService(IHttpClientAdapter httpClientAdapter, IConfiguration configuration)
        {
            _httpClientAdapter = httpClientAdapter;
            _ApiBaseAddress = configuration["ORApi:BaseUrl"];
        }
       

        public async Task<Service> GetServiceById(string id)
        {
            var services = await GetServicesAsync();
            return services.ToList().First(x => x.Id == id);
        }

        public async Task<IEnumerable<Service>> GetServicesAsync()
        {
            //var responseString = await _httpClientAdapter.GetAsync(new Uri($"{ _ApiBaseAddress}/Services"));
            //var services = JsonConvert.DeserializeObject<IEnumerable<Service>>(responseString);

            var services = new List<Service>()
            {
                new Service()
                {
                    Id = "1",
                    Name = "Siccar Service",
                    Description = "Service A Descr",
                    OrganizationId = "67b7f2b70148413697d6fd4d996cc612",
                },
                new Service()
                {
                    Id = "2",
                    Name = "NHS Service",
                    Description = "Service B Descr",
                    OrganizationId = "6ff3d38250564b32ab20d4e231f25e02",
                },
                new Service()
                {
                    Id = "3",
                    Name = "SP TEST Service",
                    Description = "Service C Descr",
                    OrganizationId = "da1f1111be40485999938fb93fa2e07f",
                }
                ,
                new Service()
                {
                    Id = "4",
                    Name = "Charity 65 Service",
                    Description = "Service D Descr",
                    OrganizationId = "1bd38745-d401-4d6f-a9c0-a0e4b3ef141c",
                }
            };

            return services;
        }

        public async Task<IEnumerable<TagEnum>> GetServiceTagsAsync(string serviceId)
        {
            //var responseString = await _httpClientAdapter.GetAsync(new Uri($"{ _ApiBaseAddress}/tags/{serviceId}"));
            //var tags = JsonConvert.DeserializeObject<IEnumerable<TagEnum>>(responseString);

            //return tags;

            return new List<TagEnum>()
            {
                TagEnum.Tag1,TagEnum.Tag2, TagEnum.Tag3
            };
        }

        public async Task<Service> UpdateService(Service service)
        {
            //var responseString = await _httpClientAdapter.PutAsync(new Uri($"{ _ApiBaseAddress}/Services"), service);
            //var updatedService = JsonConvert.DeserializeObject<Service>(responseString);
            //return updatedService;

            return service;
        }

        public async Task<Location> AddLocation(Location location)
        {
            //var responseString = await _httpClientAdapter.PostAsync(new Uri($"{ _ApiBaseAddress}/Location"), location);
            //var addedLocation = JsonConvert.DeserializeObject<Location>(responseString);
            //return addedLocation;


            return location;
        }


        public async Task<Service> AddService(Service service)
        {
            //var responseString = await _httpClientAdapter.PostAsync(new Uri($"{ _ApiBaseAddress}/Services"), service);
            //var addedService = JsonConvert.DeserializeObject<Service>(responseString);
            //return addedService;

            return service;
        }

    }
}
