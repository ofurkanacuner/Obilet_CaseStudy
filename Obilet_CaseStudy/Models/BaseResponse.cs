using Newtonsoft.Json;
using System.Collections.Generic;

namespace Obilet_CaseStudy.Models
{
    public class BaseResponse<T>
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public List<T> Data { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }

        [JsonProperty("user-message")]
        public object UserMessage { get; set; }

        [JsonProperty("api-request-id")]
        public object ApiRequestId { get; set; }

        [JsonProperty("controller")]
        public object Controller { get; set; }

        [JsonProperty("client-request-id")]
        public object ClientRequestId { get; set; }
    }
}
