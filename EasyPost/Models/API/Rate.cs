﻿using System;
using EasyPost._base;
using Newtonsoft.Json;

namespace EasyPost.Models.API
{
#pragma warning disable CA1724 // Naming conflicts with Parameters.Beta.Rate
    /// <summary>
    ///     Class representing an <a href="https://www.easypost.com/docs/api#rate-object">EasyPost rate</a>.
    /// </summary>
    public class Rate : EasyPostObject
    {
        #region JSON Properties

        [JsonProperty("billing_type")]
        public string? BillingType { get; set; }
        [JsonProperty("carbon_offset")]
        public CarbonOffset? CarbonOffset { get; set; }
        [JsonProperty("carrier")]
        public string? Carrier { get; set; }
        [JsonProperty("carrier_account_id")]
        public string? CarrierAccountId { get; set; }
        [JsonProperty("currency")]
        public string? Currency { get; set; }
        [JsonProperty("delivery_date")]
        public DateTime? DeliveryDate { get; set; }
        [JsonProperty("delivery_date_guaranteed")]
        public bool? DeliveryDateGuaranteed { get; set; }
        [JsonProperty("delivery_days")]
        public int? DeliveryDays { get; set; }
        [JsonProperty("est_delivery_days")]
        public int? EstDeliveryDays { get; set; }
        [JsonProperty("list_currency")]
        public string? ListCurrency { get; set; }
        [JsonProperty("list_rate")]
        public string? ListRate { get; set; }
        [JsonProperty("rate")]
        public string? Price { get; set; } // "Rate" is the enclosing class name
        [JsonProperty("retail_currency")]
        public string? RetailCurrency { get; set; }
        [JsonProperty("retail_rate")]
        public string? RetailRate { get; set; }
        [JsonProperty("service")]
        public string? Service { get; set; }
        [JsonProperty("shipment_id")]
        public string? ShipmentId { get; set; }

        #endregion

    }
}
#pragma warning disable CA1724 // Naming conflicts with Parameters.Beta.Rate
