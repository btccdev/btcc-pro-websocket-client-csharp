using Newtonsoft.Json;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Notifications;
using ProExchange.JSON.API.Requests;
using System;

namespace ProExchange.JSON.API.Responses
{
	[JsonObject]
	public class QuoteResponse : Response<QuoteRequest>
	{
		[JsonProperty]
		public ProExchange.JSON.API.Notifications.Ticker Ticker;

		[JsonProperty]
		public ProExchange.JSON.API.Notifications.OrderBook OrderBook;

		[JsonProperty]
		public ProExchange.JSON.API.Notifications.PremiumAdjustment PremiumAdjustment;

		public QuoteResponse()
		{
		}
	}
}