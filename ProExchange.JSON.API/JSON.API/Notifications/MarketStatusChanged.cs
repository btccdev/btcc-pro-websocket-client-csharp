using Newtonsoft.Json;
using ProExchange.JSON.API;
using System;

namespace ProExchange.JSON.API.Notifications
{
	[JsonObject]
	public class MarketStatusChanged : Notification
	{
		[JsonProperty]
		public char Status;

		[JsonProperty]
		public long Reopen;

		public MarketStatusChanged()
		{
		}

		public MarketStatusChanged(char status)
		{
			this.Status = status;
		}
	}
}