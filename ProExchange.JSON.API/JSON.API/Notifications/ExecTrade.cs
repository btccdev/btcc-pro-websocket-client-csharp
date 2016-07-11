using Newtonsoft.Json;
using ProExchange.JSON.API;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class ExecTrade : Notification
	{
		[JsonProperty("TID")]
		public long TradeId;

		[JsonProperty]
		public long Timestamp;

		[JsonProperty]
		public string Symbol;

		[JsonProperty]
		public char Side;

		[JsonProperty]
		public double Size;

		[JsonProperty]
		public double Price;

		public ExecTrade()
		{
		}
	}
}