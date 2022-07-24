#region - Using

using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Obilet_CaseStudy.Helpers;
using Obilet_CaseStudy.Models.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

#endregion

namespace Obilet_CaseStudy.Services
{
    public interface ISessionService
    {
        Task<ApiResponse> GetSession();
    }

    public class SessionService : ISessionService
    {
        #region - Variable

        private readonly IAPIClient _apiClient;
        private readonly IConfiguration _configuration;

        #endregion

        #region - Ctor

        public SessionService(IAPIClient apiClient, IConfiguration configuration)
        {
            _apiClient = apiClient;
            _configuration = configuration;
        }

        #endregion

        public async Task<ApiResponse> GetSession()
        {
            ApiResponse response = new ApiResponse
            {
                StatusCode = 400,
                IsSuccess = false
            };

            string endpoint = Globals.ApiUrl + _configuration.GetSection("Config:GetSession").Value;

            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                {"Authorization","Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1" }
            };

            var data = new GetSessionRequest
            {
                Browser = new Browser
                {
                    Name = "Chrome",
                    Version = "47.0.0.12"
                },
                Type = 1,
                Connection = new Connection
                {
                    Ipaddress = "172.28.48.1",
                    Port = "5117"
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