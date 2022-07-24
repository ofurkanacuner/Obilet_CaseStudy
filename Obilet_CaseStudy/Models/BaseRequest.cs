using Newtonsoft.Json;
using System;

namespace Obilet_CaseStudy.Models
{
    public class BaseRequest<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("device-session")]
        public DeviceSession DeviceSession { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }
    public class DeviceSession
    {
        [JsonProperty("session-id")]
        public string SessionId { get; set; }

        [JsonProperty("device-id")]
        public string DeviceId { get; set; }
    }
}