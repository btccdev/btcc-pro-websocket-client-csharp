using Newtonsoft.Json;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Notifications;
using ProExchange.JSON.API.Requests;
using System;

namespace ProExchange.JSON.API.Responses
{
	[JsonObject]
	public class RetrieveOrderResponse : Response<RetrieveOrderRequest>
	{
		[JsonProperty]
		public ExecReport Report;

		[JsonProperty]
		public int OrdRejReason;

		public RetrieveOrderResponse()
		{
		}
	}
}