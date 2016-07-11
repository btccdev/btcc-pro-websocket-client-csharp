using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class ActiveContract
	{
		[JsonProperty]
		public string Symbol;

		[JsonProperty]
		public double Quantity;

		[JsonProperty]
		public double Price;

		[JsonProperty]
		public string Index;

		public ActiveContract()
		{
		}
	}
}