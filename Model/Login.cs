using System;
using Newtonsoft.Json;

namespace Bank;

public partial class Login
{
	public Login()
	{
	}


    [JsonProperty("LoginID")]
    public long LoginId { get; set; }

    [JsonProperty("PasswordHash")]
    public string PasswordHash { get; set; }
}

