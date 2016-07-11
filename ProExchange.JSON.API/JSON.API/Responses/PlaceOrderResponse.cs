using Newtonsoft.Json;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Requests;
using System;

namespace ProExchange.JSON.API.Responses
{
	[JsonObject]
	public class PlaceOrderResponse : Response<PlaceOrderRequest>
	{
		[JsonProperty("OID")]
		public string OrderId;

		[JsonProperty]
		public string Text;

		[JsonProperty]
		public int OrdRejReason;

		public PlaceOrderResponse()
		{
		}
	}
}