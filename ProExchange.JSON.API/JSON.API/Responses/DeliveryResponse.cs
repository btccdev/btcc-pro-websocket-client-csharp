using Newtonsoft.Json;
using ProExchange.JSON.API;
using ProExchange.JSON.API.Requests;
using System;

namespace ProExchange.JSON.API.Responses
{
	[JsonObject]
	public class DeliveryResponse : Response<DeliveryRequest>
	{
		[JsonProperty("DID")]
		public string DeliveryId;

		public DeliveryResponse()
		{
		}
	}
}