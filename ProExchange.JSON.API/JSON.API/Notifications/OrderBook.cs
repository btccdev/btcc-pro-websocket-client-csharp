using Newtonsoft.Json;
using ProExchange.JSON.API;
using System;
using System.Collections.Generic;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class OrderBook : Notification
	{
		[JsonProperty]
		public long Timestamp;

		[JsonProperty]
		public string Symbol;

		[JsonProperty]
		public int Version;

		[JsonProperty]
		public char Type;

		[JsonProperty]
		public List<OrderBookData> List;

		public OrderBook()
		{
		}
	}
}