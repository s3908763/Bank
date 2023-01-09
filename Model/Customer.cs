using System;

using Newtonsoft.Json;

namespace Bank;

public partial class Customer
{
    

    [JsonProperty("CustomerID")]
    public long CustomerId { get; set; }

    [JsonProperty("Name")]
    public string Name { get; set; }

    [JsonProperty("Address")]
    public string Address { get; set; }

    [JsonProperty("City")]
    public string City { get; set; }

    [JsonProperty("PostCode")]
    public long? PostCode { get; set; }

    [JsonProperty("Accounts")]
    public Account[] Accounts { get; set; }

    [JsonProperty("Login")]
    public Login Login { get; set; }
}

