using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class AccountBalance
	{
		[JsonProperty(PropertyName="CR")]
		public string Currency;

		[JsonProperty(PropertyName="SOD")]
		public double TransferTotal;

		[JsonProperty(PropertyName="C")]
		public double Cash;

		public AccountBalance()
		{
		}
	}
}