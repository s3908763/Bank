
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bank;

public partial class Account
{
    [JsonProperty("AccountNumber")]
    public int AccountNumber { get; set; }

    [JsonProperty("AccountType")]
    public char? AccountType { get; set; }

    [JsonProperty("CustomerID")]
    public int CustomerId { get; set; }

    [JsonProperty("Transactions")]
    public Transaction[]? Transactions { get; set; }
    public string AccountBalance { get; set; }

    internal static object GetAccountTypeName(char? accountType)
    {
        throw new NotImplementedException();
    }
}

public partial class Transaction
{
    //[JsonProperty("Amount")]
    //public double Amount { get; set; }

    //[JsonProperty("Comment")]
    //public string? Comment { get; set; }

    //[JsonProperty("TransactionTimeUtc")]
    //public string? TransactionTimeUtc { get; set; }
}