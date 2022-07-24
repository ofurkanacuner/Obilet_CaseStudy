using Newtonsoft.Json;
using System;

namespace Obilet_CaseStudy.Models.Response
{
    public class BusJourneysResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("partner-id")]
        public int PartnerId { get; set; }

        [JsonProperty("partner-name")]
        public string PartnerName { get; set; }

        [JsonProperty("route-id")]
        public int RouteId { get; set; }

        [JsonProperty("bus-type")]
        public string BusType { get; set; }

        [JsonProperty("bus-type-name")]
        public string BusTypeName { get; set; }

        [JsonProperty("total-seats")]
        public int TotalSeats { get; set; }

        [JsonProperty("available-seats")]
        public int AvailableSeats { get; set; }

        [JsonProperty("journey")]
        public Journey Journey { get; set; }

        [JsonProperty("features")]
        public Feature[] Features { get; set; }

        [JsonProperty("origin-location")]
        public string OriginLocation { get; set; }

        [JsonProperty("destination-location")]
        public string DestinationLocation { get; set; }

        [JsonProperty("is-active")]
        public bool IsActive { get; set; }

        [JsonProperty("origin-location-id")]
        public int OriginLocationId { get; set; }

        [JsonProperty("destination-location-id")]
        public int DestinationLocationid { get; set; }

        [JsonProperty("is-promoted")]
        public bool IsPromoted { get; set; }

        [JsonProperty("cancellation-offset")]
        public int CancellationOffset { get; set; }

        [JsonProperty("has-bus-shuttle")]
        public bool HasBusShuttle { get; set; }

        [JsonProperty("disable-sales-without-gov-id")]
        public bool DisableSalesWithOutGovId { get; set; }

        [JsonProperty("display-offset")]
        public string DisplayOffset { get; set; }

        [JsonProperty("partner-rating")]
        public float? PartnerRating { get; set; }

        [JsonProperty("has-dynamic-pricing")]
        public bool HasDynamicPricing { get; set; }

        [JsonProperty("disable-sales-without-hes-code")]
        public bool DisableSalesWithOutHesCode { get; set; }

        [JsonProperty("disable-single-seat-selection")]
        public bool DisableSingleSeatSelection { get; set; }

        [JsonProperty("change-offset")]
        public int ChangeOffset { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("display-coupon-code-input")]
        public bool DisplayCouponCodeInput { get; set; }

        [JsonProperty("disable-sales-without-date-of-birth")]
        public bool DisableSalesWithOutDateOfBirth { get; set; }

        [JsonProperty("open-offset")]
        public int? OpenOffset { get; set; }

        [JsonProperty("display-buffer")]
        public object DisplayBuffer { get; set; }
    }

    public class Journey
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("stops")]
        public Stop[] Stops { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("departure")]
        public DateTime Departure { get; set; }

        [JsonProperty("arrival")]
        public DateTime Arrival { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("original-price")]
        public float OriginalPrice { get; set; }

        [JsonProperty("internet-price")]
        public float InternetPrice { get; set; }

        [JsonProperty("provider-internet-price")]
        public float? ProviderInternetPrice { get; set; }

        [JsonProperty("booking")]
        public object Booking { get; set; }

        [JsonProperty("busname")]
        public string BusName { get; set; }

        [JsonProperty("policy")]
        public Policy Policy { get; set; }

        [JsonProperty("features")]
        public string[] Features { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("available")]
        public object Available { get; set; }
    }

    public class Policy
    {
        [JsonProperty("max-seats")]
        public object MaxSeats { get; set; }

        [JsonProperty("max-single")]
        public int? MaxSingle { get; set; }

        [JsonProperty("max-single-males")]
        public int? MaxSingleMales { get; set; }

        [JsonProperty("max-single-females")]
        public int? MaxSingleFemales { get; set; }

        [JsonProperty("mixed-genders")]
        public bool MixedGenders { get; set; }

        [JsonProperty("govid")]
        public bool Govid { get; set; }

        [JsonProperty("lht")]
        public bool lht { get; set; }
    }

    public class Stop
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("station")]
        public string Station { get; set; }

        [JsonProperty("time")]
        public DateTime? Time { get; set; }

        [JsonProperty("is-origin")]
        public bool IsOrigin { get; set; }

        [JsonProperty("is-destination")]
        public bool IsDestination { get; set; }
    }

    public class Feature
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is-promoted")]
        public bool IsPromoted { get; set; }

        [JsonProperty("back-color")]
        public string BackColor { get; set; }

        [JsonProperty("fore-color")]
        public string ForeColor { get; set; }
    }
}