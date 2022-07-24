using Newtonsoft.Json;
using System;

namespace Obilet_CaseStudy.Models.Request
{
    public class BusJourneysRequest
    {
        [JsonProperty("origin-id")]
        public int OriginId { get; set; }

        [JsonProperty("destination-id")]
        public int DestinationId { get; set; }

        [JsonProperty("departure-date")]
        public DateTime DepartureDate { get; set; }
    }
}