using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Obilet_CaseStudy.Helpers;
using Obilet_CaseStudy.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Obilet_CaseStudy.Services
{
    public interface IBusLocationsService
    {
        Task<ApiResponse> GetBusLocations(string sessionId, string deviceId);
    }

    public class BusLocationsService : IBusLocationsService
    {
        #region - Variable

        private readonly IAPIClient _apiClient;
        private readonly IConfiguration _configuration;

        #endregion

        #region - Ctor

        public BusLocationsService(IAPIClient apiClient, IConfiguration configuration)
        {
            _apiClient = apiClient;
            _configuration = configuration;
        }

        #endregion

        public async Task<ApiResponse> GetBusLocations(string sessionId, string deviceId)
        {
            ApiResponse response = new ApiResponse
            {
                StatusCode = 400,
                IsSuccess = false
            };

            string endpoint = Globals.ApiUrl + _configuration.GetSection("Config:GetBusLocations").Value;

            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                {"Authorization","Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1" }
            };

            var data = new BaseRequest<string>
            {
                Data = null,
                Language = "tr-TR",
                Date = DateTime.Now.AddDays(1),
                DeviceSession = new DeviceSession
                {
                    DeviceId = deviceId,
                    SessionId = sessionId
                }

            };
            var jsonData = JsonConvert.SerializeObject(data);

            var result = await _apiClient.PostAsync(endpoint, jsonData, headers);
            if (result.IsSuccess)
            {
                response.IsSuccess = true;
                response.Data = result.Data;
                response.DataObject = result.DataObject;
                response.StatusCode = 200;
            }
            else
            {
                response.Reason = result.Reason;
            }

            return response;
        }
    }
}