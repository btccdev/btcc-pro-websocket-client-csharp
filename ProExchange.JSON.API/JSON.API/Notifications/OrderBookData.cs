using Newtonsoft.Json;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class OrderBookData
	{
		[JsonProperty]
		public char Side;

		[JsonProperty]
		public double Size;

		[JsonProperty]
		public double Price;

		public OrderBookData()
		{
		}
	}
}