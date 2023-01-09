using System;
using Newtonsoft.Json;

namespace Bank;

public partial class Transaction
{
    public Transaction()
    {
    }

    [JsonProperty("Amount")]
    public double Amount { get; set; }

    [JsonProperty("Comment")]
    public string Comment { get; set; }

    [JsonProperty("TransactionTimeUtc")]
    public string TransactionTimeUtc { get; set; }

    public char TransactionType { get; set; }

    public int DestinationAccountNumber { get; set; }
    public int AccountNumber { get; set; }
}

