using Newtonsoft.Json;
using ProExchange.JSON.API;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class Delivery : AccountNotification
	{
		[JsonProperty("DID")]
		public string DeliveryId;

		[JsonProperty]
		public long Timestamp;

		[JsonProperty]
		public string Symbol;

		[JsonProperty]
		public char Side;

		[JsonProperty]
		public double Quantity;

		[JsonProperty]
		public char Status;

		[JsonProperty]
		public double Amount;

		public Delivery()
		{
		}
	}
}