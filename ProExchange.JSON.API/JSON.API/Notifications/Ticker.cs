using Newtonsoft.Json;
using ProExchange.JSON.API;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class Ticker : Notification
	{
		[JsonProperty]
		public string Symbol;

		[JsonProperty]
		public double BidPrice;

		[JsonProperty]
		public double AskPrice;

		[JsonProperty]
		public double Open;

		[JsonProperty]
		public double High;

		[JsonProperty]
		public double Low;

		[JsonProperty]
		public double Last;

		[JsonProperty]
		public double LastQuantity;

		[JsonProperty]
		public double PrevCls;

		[JsonProperty]
		public double Volume;

		[JsonProperty]
		public double Volume24H;

		[JsonProperty]
		public long Timestamp;

		[JsonProperty]
		public double ExecutionLimitDown;

		[JsonProperty]
		public double ExecutionLimitUp;

		public Ticker()
		{
		}
	}
}